using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clases
{
    public class Equipo
    {
        public int IDEquipo { get; set; }
        public string CentralEquipos { get; set; }
        public string JefeEquipo { get; set; }
        public int AñoDEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string JefeTEquipo { get; set; }
        public string LogoEquipo { get; set; }

        public Equipo()
        {

        }

        public Equipo(string Central, string Jefe, int Año, string Nombre, string JefeTecnico, string Logo)
        {
            this.CentralEquipos = Central;
            this.JefeEquipo = Jefe;
            this.AñoDEquipo = Año;
            this.NombreEquipo = Nombre;
            this.JefeTEquipo = JefeTecnico;
            this.LogoEquipo = Logo;
        }

    }
  
}
