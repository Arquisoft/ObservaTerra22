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
    
    public partial class Area
    {
        public Area()
        {
            this.ContainedAreas = new HashSet<Area>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int AreaId { get; set; }
    
        public virtual ICollection<Area> ContainedAreas { get; set; }
        public virtual Area ContainerArea { get; set; }
        public virtual Indicator Indicator { get; set; }
    }
}
