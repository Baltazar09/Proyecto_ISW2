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
    
    public partial class usuario
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public long ROL_id { get; set; }
        public long EMPLEADO_id { get; set; }
    
        public virtual empleado empleado { get; set; }
        public virtual rol rol { get; set; }
    }
}
