//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISW_GASISW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kardex
    {
        public kardex()
        {
            this.inventario = new HashSet<inventario>();
        }
    
        public long id { get; set; }
        public int cantidad_producto { get; set; }
        public System.DateTime fecha { get; set; }
        public float precio_u { get; set; }
        public long LOTE_id { get; set; }
        public long SUCURSAL_id { get; set; }
        public float total_producto { get; set; }
        public long MOVIMIENTO_id { get; set; }
    
        public virtual ICollection<inventario> inventario { get; set; }
        public virtual sucursal sucursal { get; set; }
        public virtual lote lote { get; set; }
        public virtual movimiento movimiento { get; set; }
    }
}
