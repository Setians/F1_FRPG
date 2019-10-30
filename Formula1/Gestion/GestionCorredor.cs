using Formula1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Formula1.Gestion
{
    public class GestionCorredor
    {
        public void CargarCorredor(Corredor corredor)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "spInsertarCorredor";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@NOMBRECorredor", corredor.Nombre);
                conexion.agregarParametro("@ApellidoCorredor", corredor.Apellido);
                conexion.agregarParametro("@LugarNacimientoCorredor", corredor.LugarNacimiento);
                conexion.agregarParametro("@FechaNacCorr", corredor.FechaNacimiento);
                conexion.agregarParametro("@PaisCorredor", corredor.Pais);
                conexion.agregarParametro("@ImagenCorredor", corredor.Imagen);
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
