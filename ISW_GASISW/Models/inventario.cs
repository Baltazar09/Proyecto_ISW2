//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISW_GASISW.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventario
    {
        public long id { get; set; }
        public long PRODUCTO_id { get; set; }
        public int cantidad { get; set; }
        public System.DateTime fecha { get; set; }
        public long KARDEX_id { get; set; }
        public float precio_u { get; set; }
    
        public virtual kardex kardex { get; set; }
        public virtual producto producto { get; set; }
    }
}
