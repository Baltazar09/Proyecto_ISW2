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
    
    public partial class categoria_producto
    {
        public categoria_producto()
        {
            this.producto = new HashSet<producto>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<producto> producto { get; set; }
    }
}
