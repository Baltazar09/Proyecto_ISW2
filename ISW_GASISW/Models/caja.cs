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
    
    public partial class caja
    {
        public caja()
        {
            this.historial_caja = new HashSet<historial_caja>();
            this.moviementos_caja = new HashSet<moviementos_caja>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public string numero { get; set; }
        public long SUCURSAL_id { get; set; }
    
        public virtual sucursal sucursal { get; set; }
        public virtual ICollection<historial_caja> historial_caja { get; set; }
        public virtual ICollection<moviementos_caja> moviementos_caja { get; set; }
    }
}
