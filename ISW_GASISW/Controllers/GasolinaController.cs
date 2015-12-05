using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISW_GASISW.Models;

namespace ISW_GASISW.Controllers
{
    public class GasolinaController : Controller
    {
        private gasiswEntities db = new gasiswEntities();
        //Llamando a la clase Arduino
        C_Arduino CARD = new C_Arduino();
        C_Ingreso_Caja CIC = new C_Ingreso_Caja();

        //
        // GET: /Gasolina/
        public ActionResult Index(string mensaje = "")
        {
            ViewBag.Estacion1 = db.estacion.Where(p => p.numero == 1).ToList();
            ViewBag.Estacion2 = db.estacion.Where(p => p.numero == 2).ToList();
            ViewBag.Estaciones = new SelectList(new[]
                                    {
                                        new { Id = "0", Name = "Seleccione una estacion"},
                                        new { Id = "1", Name = "Estacion #1" },
                                        new { Id = "2", Name = "Estacion #2" },
                                    }, "Id", "Name");
            ViewBag.TiposGas = new SelectList(db.producto.Where(p => p.CATEGORIA_PRODUCTO_id == 2).ToList(),"id","nombre");
            ViewBag.Mensaje = mensaje;
            return View();
        }

        //
        // POST: /Gasolina/
        [HttpPost]
        public ActionResult Index(M_PeticionArduino MPA)
        {
            //Validar que haya gasolina del tipo seleccionado
            int est = Convert.ToInt16(MPA.estacion);
            int tipo = Convert.ToInt16(MPA.tipo);
            int cant = Convert.ToInt16(MPA.giro);

            float cantidadActual = db.estacion.Where(p => p.numero == est && p.tipo == tipo).Select(p => p.cantidad).Single();
            if(cantidadActual>float.Parse(MPA.giro))
            {
                //hacerlo
                if (tipo == 4)        //Regular
                {
                    //Arbitrariamente se selecciono grados menores de 90
                    MPA.tipo = "1";
                    float giro = float.Parse(MPA.giro)*10;
                    float movimiento = 90 - giro;
                    MPA.giro = movimiento.ToString();
                    CARD.EnviarPeticion(MPA);
                }
                else if(tipo == 6)    //Disel
                {
                    //Arbitrariamente se selecciono grados mayores de 90
                    MPA.tipo = "2";
                    float giro = float.Parse(MPA.giro)*10;
                    float movimiento = 90 + giro;
                    MPA.giro = movimiento.ToString();
                    CARD.EnviarPeticion(MPA);
                }

                // Actualizando BD
                estacion E = db.estacion.Where(p => p.numero == est && p.tipo == tipo).Single();
                E.cantidad = E.cantidad - cant;
                db.SaveChanges();

                m_venta MV = new m_venta();
                MV.fecha_venta = DateTime.Today;
                MV.EMPLEADO_id = Convert.ToInt16(Session["Empleado_id"]);
                MV.total = 0;

                db.m_venta.Add(MV);
                db.SaveChanges();

                int MASTER = Convert.ToInt16(db.m_venta.Max(x => x.id));

                d_venta DV = new d_venta();
                DV.PRODUCTO_id = tipo;
                DV.cantidad_producto = cant;
                DV.M_VENTA_id = MASTER;
                producto pro = db.producto.Where(p => p.id == tipo).Single();
                DV.precio_u = pro.precio_venta_u;
                DV.total = (DV.precio_u * DV.cantidad_producto);

                db.d_venta.Add(DV);
                db.SaveChanges();

                m_venta MV2 = db.m_venta.Where(p => p.id == MASTER).Select(p => p).Single();
                MV2.total = DV.total;
                db.SaveChanges();

                facturacion F = new facturacion();
                F.TIPO_FACTURACION_id = 2;
                F.M_VENTA_id = MV.id;
                db.facturacion.Add(F);
                db.SaveChanges();

                CIC.Ingreso(Convert.ToInt16(Session["Caja_id"]), MV2.total, MASTER);

                //Redireccionar Exito
                return RedirectToAction("Index");
            }
            else
            {
                //Escribir Error
                string mensaje = "Lo sentimos no hay suficiente combustible de ese tipo en esta estacion";
                return RedirectToAction("Index", new { mensaje });
            }            
        }

    }
}
