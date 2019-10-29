using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Formula1
{
    public class GestionCorredor
    {
        /*
        public Corredor Obtener(int DNI)
        {

            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_Buscar_DNI";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@DNI", DNI);

                conexion.setearSP(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdPersona = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Apellido = conexion.Lector.GetString(2);
                    aux.Dni = conexion.Lector.GetInt32(3);
                    aux.Mail = conexion.Lector.GetString(4);
                    aux.Huella1 = conexion.Lector.GetString(5);
                    aux.Huella2 = conexion.Lector.GetString(6);
                    aux.Huella3 = conexion.Lector.GetString(7);
                }
                return aux;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }*/

        public void CargarCorredor(string Nombre, string apellido, string lNacimiento, string Pais, DateTime fecha, string DirIma)
        {
            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "spInsertarCorredor";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@NOMBRECorredor", Nombre);
                conexion.agregarParametro("@ApellidoCorredor", apellido);
                conexion.agregarParametro("@LugarNacimientoCorredor", lNacimiento);
                conexion.agregarParametro("@FechaNacCorr", fecha);
                conexion.agregarParametro("@PaisCorredor", Pais);
                conexion.agregarParametro("@ImagenCorredor", DirIma);



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
        public void ModificarPersonaSinHuellas(string Nombre, string apellido, int DNI, string Email, int TipoPer, int id)
        {
            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "SP_ModificarPersona";
            try
            {
                conexion.borrarParametros();
                conexion.agregarParametro("@NombrePersona", Nombre);
                conexion.agregarParametro("@ApellidoPersona", apellido);
                conexion.agregarParametro("@DNI", DNI);
                conexion.agregarParametro("@Email", Email);
                conexion.agregarParametro("@TipoPersona", TipoPer);
                conexion.agregarParametro("@id", id);
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

            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Nombre_Corredor from  F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.Nombre = conexion.Lector.GetString(0);

                }
                return aux.Nombre;

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

            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select Apellido_Corredor from F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.Apellido = conexion.Lector.GetString(0);

                }
                return aux.Apellido;

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

            Corredor aux = new Corredor();
            AccesoDatos conexion = new AccesoDatos();


            string consulta = "Select LugarN_Corredor from  F1_Corredores where ID_Corredor = '" + id + "'";
            try
            {
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.LugarNacimiento = conexion.Lector.GetString(0);

                }
                return aux.LugarNacimiento;

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
