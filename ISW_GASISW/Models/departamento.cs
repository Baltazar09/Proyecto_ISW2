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
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class departamento
    {
        public departamento()
        {
            this.municipio = new HashSet<municipio>();
        }
    
        public long id { get; set; }

        [Required]
        public string nombre { get; set; }
    
        public virtual ICollection<municipio> municipio { get; set; }
    }
}
