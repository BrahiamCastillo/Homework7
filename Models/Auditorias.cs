using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework7.Models
{
    public partial class Auditorias
    {
        public int Id { get; set; }
        public int PersonasId { get; set; }
        public int VacunasId { get; set; }
        public int ProvinciasId { get; set; }
        public int NumeroDosis { get; set; }
        public DateTime FechaVacunacion { get; set; }
        public DateTime FechaVacunaproxima { get; set; }

        public virtual Personas Personas { get; set; }
        public virtual Provincias Provincias { get; set; }
        public virtual Vacunas Vacunas { get; set; }
    }
}
