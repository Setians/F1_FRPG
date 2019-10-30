using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clases
{
    public class Temporada
    {
        public int ID_Temporada { get; set; }
        public string Nombre_Temporada { get; set; }

        public Temporada()
        { }

        public Temporada(string Nombre)
        {
            this.Nombre_Temporada = Nombre;
        }

    }
}
