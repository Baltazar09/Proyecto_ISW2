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
    
    public partial class nota_credito_compra
    {
        public long id { get; set; }
        public System.DateTime plazo { get; set; }
        public System.DateTime fecha_extendido { get; set; }
        public long M_COMPRA_id { get; set; }
        public Nullable<System.DateTime> fecha_paga { get; set; }
        public bool estado { get; set; }
    
        public virtual m_compra m_compra { get; set; }
    }
}
