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
    
    public partial class Indicator
    {
        public Indicator()
        {
            this.Observations = new HashSet<Observation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual Measure Measure { get; set; }
        public virtual ICollection<Observation> Observations { get; set; }
        public virtual ITime ITime { get; set; }
    }
}