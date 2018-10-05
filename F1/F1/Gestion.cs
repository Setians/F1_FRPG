using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace F1
{
    class Gestion
    {
        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }
        //ABMCorredores
        public DataTable ObtenerTodosLosCorredores()
        {
            return ObtenerTabla("Corredores", "Select * from F1_Corredores");
        }
        public DataTable ObtenerProductosFiltrados(int NroCorredor)
        {
            return ObtenerTabla("Productos", "Select * from Productos where IdCorredor > " + NroCorredor);
        }
        public void ArmarParametrosCorredores(ref SqlCommand Comando, string nombre,string apellido, string pais, string lugarn, string fecha )
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBRECorredor", SqlDbType.Char,30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@ApellidoCorredor", SqlDbType.Char, 30);
            SqlParametros.Value = apellido;
            SqlParametros = Comando.Parameters.Add("@LugarNacimientoCorredor", SqlDbType.Char,50);
            SqlParametros.Value = lugarn;
            SqlParametros = Comando.Parameters.Add("@FechaNacCorr", SqlDbType.SmallDateTime);
            SqlParametros.Value = fecha;
            SqlParametros = Comando.Parameters.Add("@PaisCorredor", SqlDbType.Char, 30);
            SqlParametros.Value = pais;
        }
        public void ArmarParametrosCorredoresEliminar(ref SqlCommand Comando, String id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        public void ArmarParametrosCorredores(ref SqlCommand Comando, string nombre, string apellido, string pais, string lugarn, string fecha,string id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBRECorredor", SqlDbType.Char, 30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@ApellidoCorredor", SqlDbType.Char, 30);
            SqlParametros.Value = apellido;
            SqlParametros = Comando.Parameters.Add("@LugarNacimientoCorredor", SqlDbType.Char, 50);
            SqlParametros.Value = lugarn;
            SqlParametros = Comando.Parameters.Add("@FechaNacCorr", SqlDbType.SmallDateTime);
            SqlParametros.Value = fecha;
            SqlParametros = Comando.Parameters.Add("@PaisCorredor", SqlDbType.Char, 30);
            SqlParametros.Value = pais;
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Char, 30);
            SqlParametros.Value = id;
        }


        //ABM Equipos
        public DataTable ObtenerTodosLosEquipos()
        {
            return ObtenerTabla("Equipos", "Select * from F1_Equipos");
        }
        public void ArmarParametrosEquipos(ref SqlCommand Comando, string nombre, string central, string Jefe, string JefeT, string Año)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreEquipo", SqlDbType.Char, 30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@CentralEquipo", SqlDbType.Char, 30);
            SqlParametros.Value = central;
            SqlParametros = Comando.Parameters.Add("@JefeEquipo", SqlDbType.Char, 50);
            SqlParametros.Value = Jefe;
            SqlParametros = Comando.Parameters.Add("@JefeTEquipo", SqlDbType.Char,30);
            SqlParametros.Value = JefeT;
            SqlParametros = Comando.Parameters.Add("@AñoEquipo", SqlDbType.Int);
            SqlParametros.Value = Año;
        }
        public void ArmarParametrosEquipoEliminar(ref SqlCommand Comando, String id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDEquipo", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        public void ArmarParametrosEquipos(ref SqlCommand Comando, string nombre, string central, string Jefe, string JefeT, string Año,string id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreEquipo", SqlDbType.Char, 30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@CentralEquipo", SqlDbType.Char, 30);
            SqlParametros.Value = central;
            SqlParametros = Comando.Parameters.Add("@JefeEquipo", SqlDbType.Char, 50);
            SqlParametros.Value = Jefe;
            SqlParametros = Comando.Parameters.Add("@JefeTEquipo", SqlDbType.Char, 30);
            SqlParametros.Value = JefeT;
            SqlParametros = Comando.Parameters.Add("@AñoEquipo", SqlDbType.Int);
            SqlParametros.Value = Año;
            SqlParametros = Comando.Parameters.Add("@IDEquipo", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        ///ABMCIRCUITOS
        public DataTable ObtenerTodosLosCircuitos()
        {
            return ObtenerTabla("Circuitos", "Select * from F1_Circuitos");
        }
        public void ArmarParametrosCircuitos(ref SqlCommand Comando, string nombre, string PrGP, string Pais, string Long)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreCircuito", SqlDbType.Char, 50);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@PrimerGPCircuito", SqlDbType.Char, 30);
            SqlParametros.Value = PrGP;
            SqlParametros = Comando.Parameters.Add("@PaisCircuito", SqlDbType.Char, 30);
            SqlParametros.Value = Pais;
            SqlParametros = Comando.Parameters.Add("@LongitudCircuito", SqlDbType.Char, 20);
            SqlParametros.Value = Long;
            
        }
        public void ArmarParametrosCircuitoEliminar(ref SqlCommand Comando, String id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCircuito", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        public void ArmarParametrosCircuitos(ref SqlCommand Comando, string nombre, string PrGP, string Pais, string Long, string id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreCircuito", SqlDbType.Char, 50);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@PrimerGPCircuito", SqlDbType.Char, 30);
            SqlParametros.Value = PrGP;
            SqlParametros = Comando.Parameters.Add("@PaisCircuito", SqlDbType.Char, 30);
            SqlParametros.Value = Pais;
            SqlParametros = Comando.Parameters.Add("@LongitudCircuito", SqlDbType.Char, 20);
            SqlParametros.Value = Long;
            SqlParametros = Comando.Parameters.Add("@IDCircuito", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        ///ABMTemporadas
        public void ArmarParametrosTemporada(ref SqlCommand Comando, string nombre, string id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreTemporada", SqlDbType.Char, 20);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = id;
        }

        public void ArmarParametrosTemporadaEliminar(ref SqlCommand Comando, String id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        public DataTable ObtenerTodosLasTemporadas()
        {
            return ObtenerTabla("Temporadas", "Select * from F1_Temporadas");
        }

        public DataTable ObtenerTodosLosAñosTemporadas()
        {
            return ObtenerTabla("Temporadas", "Select ID_Temporada from F1_Temporadas");
        }

        ///AbMCarreras
        public void ArmarParametrosCarreraEliminar(ref SqlCommand Comando, String id)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCarrera", SqlDbType.Int);
            SqlParametros.Value = id;
        }
        public DataTable ObtenerTodosLasCarreras()
        {
            return ObtenerTabla("Carreras", "Select * from F1_Carreras");
        }
        public void ArmarParametrosCarrera(ref SqlCommand Comando, string nombre, string id,string idCircuito, string idTemporada,string NumeroVueltas,String distancia)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreCarrera", SqlDbType.Char, 30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@IDCarrera", SqlDbType.Int);
            SqlParametros.Value = id;
            SqlParametros = Comando.Parameters.Add("@IDCircuito", SqlDbType.Int);
            SqlParametros.Value = idCircuito;
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = idTemporada;
            SqlParametros = Comando.Parameters.Add("@NumeroVueltas", SqlDbType.Int);
            SqlParametros.Value = NumeroVueltas;
            SqlParametros = Comando.Parameters.Add("@Distancia", SqlDbType.Char,20);
            SqlParametros.Value = distancia;
        }
        public void ArmarParametrosCarrera(ref SqlCommand Comando, string nombre,string idCircuito, string idTemporada, string NumeroVueltas, String distancia)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreCarrera", SqlDbType.Char, 30);
            SqlParametros.Value = nombre;
            SqlParametros = Comando.Parameters.Add("@IDCircuito", SqlDbType.Int);
            SqlParametros.Value = idCircuito;
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = idTemporada;
            SqlParametros = Comando.Parameters.Add("@NumeroVueltas", SqlDbType.Int);
            SqlParametros.Value = NumeroVueltas;
            SqlParametros = Comando.Parameters.Add("@Distancia", SqlDbType.Char, 20);
            SqlParametros.Value = distancia;
        }

        public DataTable ObtenerTodosLosNombresCarreras(string id)
        {
            return ObtenerTabla("Carreras", "Select Nombre_Carrera from F1_Carreras where id_Temporada= '"+id+"'");
        }
        ///Resultados

        public DataTable ObtenerTodosLosEquiposxCorredor()
        {
            return ObtenerTabla("Equipos", "select id_Corredor_CET, Nombre_Corredor, id_Equipo_CET, id_Temporadas_CET from F1_CorredoresxEquipoxTemporadas inner join F1_Corredores on (id_Corredor_CET = ID_Corredor)");
        }

        public DataTable ObtenerTodosLosResultados()
        {
            return ObtenerTabla("Equipos", "Select * from F1_CarrerasxCorredor");
        }

        public void ArmarParametrosEquipoXCorredor(ref SqlCommand Comando, string IdCorredor, string idEquipo, string idTemporada)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Int);
            SqlParametros.Value = IdCorredor;
            SqlParametros = Comando.Parameters.Add("@IDEquipo", SqlDbType.Int);
            SqlParametros.Value = idEquipo;
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = idTemporada;
        }
        public void ArmarParametrosEquipoXCorredorEliminar(ref SqlCommand Comando, string IdCorredor, string idEquipo, string idTemporada)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Int);
            SqlParametros.Value = IdCorredor;
            SqlParametros = Comando.Parameters.Add("@IDEquipo", SqlDbType.Int);
            SqlParametros.Value = idEquipo;
            SqlParametros = Comando.Parameters.Add("@IDTemporada", SqlDbType.Int);
            SqlParametros.Value = idTemporada;
        }
        public void ArmarParametrosCarreraXCorredor(ref SqlCommand Comando, string IdCarrera,string IdCorredor, string PosGrilla, string posFinal, string VueltasCompletadas,string Tiempo)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCarrera", SqlDbType.Int);
            SqlParametros.Value = IdCarrera;
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Int);
            SqlParametros.Value = IdCorredor;
            SqlParametros = Comando.Parameters.Add("@PosicionGrilla", SqlDbType.Int);
            SqlParametros.Value = PosGrilla;
            SqlParametros = Comando.Parameters.Add("@PosicionFinal", SqlDbType.Int);
            SqlParametros.Value = posFinal;
            SqlParametros = Comando.Parameters.Add("@VueltasCompletadas", SqlDbType.Int);
            SqlParametros.Value = VueltasCompletadas;
            SqlParametros = Comando.Parameters.Add("@Tiempo", SqlDbType.Time,7);
            SqlParametros.Value = Tiempo;
                     
        }
        public void ArmarParametrosCarreraXCorredorEliminar(ref SqlCommand Comando, string IdCarrera, string IdCorredor)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCarrera", SqlDbType.Int);
            SqlParametros.Value = IdCarrera;
            SqlParametros = Comando.Parameters.Add("@IDCorredor", SqlDbType.Int);
            SqlParametros.Value = IdCorredor;

        }

        public DataTable ObtenerResultadoCarrera(string idCarrera,string idCorredor,string puntos)
        {
      
            return ObtenerTabla("Equipos", "select PosicionFinal_CC, Nombre_Corredor, Nombre_Equipo, Posiciongrilla_CC, VueltasCompletadas_CC, Tiempo_CC, ("+puntos+") as Puntos from F1_CarrerasxCorredor inner join F1_Corredores on (idConductor_CC = ID_Corredor) inner join F1_CorredoresxEquipoxTemporadas on (id_Corredor_CET = ID_Corredor) inner join F1_Equipos on (ID_Equipo = id_Equipo_CET) where IDCarrera_CC = '"+idCarrera+ "'and id_Corredor_CET = '"+idCorredor+"' order by PosicionFinal_CC asc");
        }



    }
}
