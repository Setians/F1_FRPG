using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clases
{
    public class Corredor
    {

        public int IdCorredor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string LugarNacimiento { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Imagen { get; set; }

        public Corredor()
        {
            
        }

        public Corredor(string Nombre, string Apellido,string LugarNacimiento, string Pais, DateTime FechaNacimiento,string Imagen)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.LugarNacimiento = LugarNacimiento;
            this.Pais = Pais;
            this.FechaNacimiento = FechaNacimiento;
            this.Imagen = Imagen;
        }

    }
}
