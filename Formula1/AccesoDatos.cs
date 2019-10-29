using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace Formula1
{
    public class AccesoDatos
    {

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private SqlDataAdapter da;
        private DataTable dt;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=localhost\\sqlexpressss; initial catalog=Formula_1; integrated security=true");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearSP(string sp)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        public void leerConsulta()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void accionEjecutar()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void borrarParametros()
        {
            try
            {
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregarParametro(string nombre, object valor)
        {
            try
            {
                comando.Parameters.AddWithValue(nombre, valor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable agragarDataGridView(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = consulta;

                da = new SqlDataAdapter(comando);
                dt = new DataTable();
                conexion.Open();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable LlenarDataGridViewConsulta(string consulta)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;

                da = new SqlDataAdapter(comando);
                dt = new DataTable();
                conexion.Open();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void llenarCbx(string consulta, ComboBox cb,string columna)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                conexion.Open();
                lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    cb.Items.Add(lector[columna].ToString());
                }
                lector.Close();
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se lleno el combobox"+ex.ToString());
            }

        }

        public void Llenar_Label(string consulta, Label lb,string columna)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lb.Text = lector[columna].ToString();   //  Items.Add(lector[columna].ToString());
            }
            lector.Close();
            conexion.Close();
        }



        public void cerrarConexion()
        {
            conexion.Close();
            conexion = null;
        }
    }
}
