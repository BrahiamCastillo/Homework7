using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework7.Models
{
    public partial class Personas
    {
        public Personas()
        {
            Auditorias = new HashSet<Auditorias>();
        }

        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<Auditorias> Auditorias { get; set; }
    }
}
