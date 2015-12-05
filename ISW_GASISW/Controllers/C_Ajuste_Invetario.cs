using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ISW_GASISW.Models;

namespace ISW_GASISW.Controllers
{
    public class C_Ajuste_Invetario
    {
        private gasiswEntities db = new gasiswEntities();

        public int guardarLote(int pro, int sec)
        {
            int contador = db.lote.Where(p => p.PRODUCTO_id == pro).Count();
            contador = contador + 1;
            lote L = new lote();
            L.nombre = contador.ToString();
            L.PRODUCTO_id = pro;
            L.SECCION_BODEGA_id = sec;

            db.lote.Add(L);
            db.SaveChanges();

            int id = Convert.ToInt16(db.lote.Max(p => p.id));
            return id;
        }

        public int guardarKardex(kardex K)
        {
            db.kardex.Add(K);
            db.SaveChanges();

            int id = Convert.ToInt16(db.kardex.Max(p => p.id));
            return id;
        }

        public void guardarInventario(int pro, int karde)
        {
            //Seleccionar Registro Anterior
            kardex kar = db.kardex.Where(p=>p.id==karde).Single();
            int conta = db.inventario.Where(p => p.PRODUCTO_id == pro).Count();
            if(conta==0)
            {
                inventario INew = new inventario();
                INew.PRODUCTO_id = pro;
                INew.cantidad = kar.cantidad_producto;
                INew.fecha = kar.fecha;
                INew.KARDEX_id = kar.id;
                INew.precio_u = kar.precio_u;

                db.inventario.Add(INew);
                db.SaveChanges();
            }
            else
            {
                List<inventario> Lista = db.inventario.Where(p => p.PRODUCTO_id == pro).ToList();
                inventario IActual = Lista.Last();
                inventario INew = new inventario();
                INew.PRODUCTO_id = pro;
                if(kar.MOVIMIENTO_id==1)
                {
                    int cantidad = kar.cantidad_producto + IActual.cantidad;
                    INew.cantidad = cantidad;
                    float suma = IActual.precio_u + kar.precio_u;
                    float promedio = suma / 2;
                    INew.precio_u = promedio;
                }
                else
                {
                    int cantidad = IActual.cantidad - kar.cantidad_producto;
                    INew.cantidad = cantidad;
                    INew.precio_u = IActual.precio_u;
                }
                INew.fecha = kar.fecha;
                INew.KARDEX_id = kar.id;

                db.inventario.Add(INew);
                db.SaveChanges();
            }
        }
    }
}