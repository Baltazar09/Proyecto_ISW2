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
    
    public partial class proveedor
    {
        public proveedor()
        {
            this.m_compra = new HashSet<m_compra>();
            this.m_orden_compra = new HashSet<m_orden_compra>();
            this.producto = new HashSet<producto>();
        }
    
        public long id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public long MUNICIPIO_id { get; set; }
    
        public virtual ICollection<m_compra> m_compra { get; set; }
        public virtual ICollection<m_orden_compra> m_orden_compra { get; set; }
        public virtual municipio municipio { get; set; }
        public virtual ICollection<producto> producto { get; set; }
    }
}
