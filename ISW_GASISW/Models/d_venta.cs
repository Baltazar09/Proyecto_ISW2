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
    
    public partial class d_venta
    {
        public long id { get; set; }
        public long PRODUCTO_id { get; set; }
        public int cantidad_producto { get; set; }
        public float total { get; set; }
        public long M_VENTA_id { get; set; }
    
        public virtual m_venta m_venta { get; set; }
        public virtual producto producto { get; set; }
    }
}
