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
    
    public partial class permisos
    {
        public permisos()
        {
            this.accesos = new HashSet<accesos>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public string url { get; set; }
    
        public virtual ICollection<accesos> accesos { get; set; }
    }
}
