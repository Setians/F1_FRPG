using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1.Clases;


namespace Formula1.Gestion
{
    class GestionCircuito
    {
        public void CargarCircuito(Circuito circuito)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "spInsertarCorredor";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@NOMBRECorredor", circuito.PrimerGPCircuito);
                conexion.agregarParametro("@ApellidoCorredor", circuito.NombreCircuito);
                conexion.agregarParametro("@LugarNacimientoCorredor", circuito.Longitud);
                conexion.agregarParametro("@FechaNacCorr", circuito.PaisCircuito);
                conexion.agregarParametro("@PaisCorredor", circuito.ImagenCircuito);
                conexion.setearSP(consulta);
                conexion.leerConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public string ObtenerNombre(string id)
        {

            Circuito circuito = new Circuito();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Nombre_Circuito from F1_Circuitos where F1_Circuitos.ID_Circuito = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    circuito.NombreCircuito = conexion.Lector.GetString(0);

                }
                return circuito.NombreCircuito;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public string ObtenerLongitud(string id)
        {

            Circuito Circuito = new Circuito();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Longitud from F1_Circuitos where F1_Circuitos.ID_Circuito ='" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Circuito.Longitud = conexion.Lector.GetString(0);

                }
                return Circuito.Longitud;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public string ObtenerPais(string id)
        {

            Circuito Circuito = new Circuito();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Pais_Circuito from F1_Circuitos where F1_Circuitos.ID_Circuito = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Circuito.PaisCircuito = conexion.Lector.GetString(0);

                }
                return Circuito.PaisCircuito;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public string ObtenerPrimerGP(string id)
        {

            Circuito Circuito = new Circuito();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "select PrimerGP_Circuito from F1_Circuitos where F1_Circuitos.ID_Circuito = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Circuito.PrimerGPCircuito = conexion.Lector.GetString(0);

                }
                return Circuito.PrimerGPCircuito;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public string ObtenerImagen(string id)
        {

            Circuito Circuito = new Circuito();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "select Imagen_Circuito from F1_Circuitos where F1_Circuitos.ID_Circuito = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    if (!conexion.Lector.IsDBNull(0))
                    {
                        Circuito.ImagenCircuito = conexion.Lector.GetString(0);
                    }
                    //else
                    //{
                    //    Circuito.ImagenCircuito = null;
                    //}
                }
                return Circuito.ImagenCircuito;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

    }
}
