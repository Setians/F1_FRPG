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

            Corredor corredor = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Nombre_Corredor from  F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    corredor.Nombre = conexion.Lector.GetString(0);

                }
                return corredor.Nombre;

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
        public string ObtenerApellido(string id)
        {

            Corredor corredor = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Apellido_Corredor from F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    corredor.Apellido = conexion.Lector.GetString(0);

                }
                return corredor.Apellido;

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
        public string ObtenerLugarNacimiento(string id)
        {

            Corredor corredor = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select LugarN_Corredor from  F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    corredor.LugarNacimiento = conexion.Lector.GetString(0);

                }
                return corredor.LugarNacimiento;

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
