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
    
    public partial class nota_credito_venta
    {
        public long id { get; set; }
        public long CLIENTE_id { get; set; }
        public System.DateTime plazo { get; set; }
        public System.DateTime fecha_extendido { get; set; }
        public long M_VENTA_id { get; set; }
        public bool estado { get; set; }
        public Nullable<System.DateTime> fecha_pagado { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual m_venta m_venta { get; set; }
    }
}
