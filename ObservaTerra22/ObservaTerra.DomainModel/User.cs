//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObservaTerra.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Observations = new HashSet<Observation>();
            this.Organizations = new HashSet<Organization>();
            this.Roles = new HashSet<Role>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Observation> Observations { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}