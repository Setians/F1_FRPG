using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    class Corredor
    {
        public Corredor()
        {
            
        }

        public int IdCorredor{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string LugarNacimiento { get; set; }
        public string Pais { get; set; }
        DateTime FechaNacimiento { get; set; }
        
        
    }
}
