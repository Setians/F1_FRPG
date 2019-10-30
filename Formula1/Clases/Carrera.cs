using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Clases
{
    public class Carrera
    {
        public int idCarrera { get; set; }
        public int idCircuitoCarrera { get; set; }
        public int idTemporada { get; set; }
        public string NombreCarrera { get; set; }
        public int NumeroVueltasCarrera { get; set; }
        public string DistanciaCarrera { get; set; }

        public Carrera()
        {
        }
        public Carrera(int idCircuito, int idtemporada, string NombreCarrera, int vueltas, string Distancia)
        {
            this.idCircuitoCarrera = idCircuito;
            this.idTemporada = idtemporada;
            this.NombreCarrera = NombreCarrera;
            this.NumeroVueltasCarrera = vueltas;
            this.DistanciaCarrera = Distancia;
        }

    }
}
