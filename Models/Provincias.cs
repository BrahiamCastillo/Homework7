using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework7.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Auditorias = new HashSet<Auditorias>();
        }

        public int Id { get; set; }
        public string NombreProvincia { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual ICollection<Auditorias> Auditorias { get; set; }
    }
}
