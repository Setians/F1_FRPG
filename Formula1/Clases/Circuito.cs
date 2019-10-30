using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clases
{
    public class Circuito
    {
        public int IDCircuito { get; set; }
        public DateTime PrimerGPCircuito { get; set; }
        public string NombreCircuito { get; set; }
        public string PaisCircuito { get; set; }
        public string Longitud { get; set; }
        public string ImagenCircuito { get; set;}

        public Circuito()
        {
           
        }

        public Circuito(DateTime PrimergpCircuito, string Nombre, string Pais, string Longitud, string Imagen)
        {
            this.PrimerGPCircuito = PrimergpCircuito;
            this.NombreCircuito = Nombre;
            this.PaisCircuito = Pais;
            this.Longitud = Longitud;
            this.ImagenCircuito = Imagen;
        }

    }
}
