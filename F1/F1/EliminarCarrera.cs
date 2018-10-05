using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace F1
{
    public partial class EliminarCarrera : Form
    {
        public EliminarCarrera()
        {
            InitializeComponent();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.ToString() != string.Empty)
            {
                if (CompararID(tbxId.Text.ToString()) == true)
                {
                    DataSet dsAgregar;
                    Gestion g = new Gestion();
                    dsAgregar = new DataSet();
                    SqlCommand Comando = new SqlCommand();
                    g.ArmarParametrosCarreraEliminar(ref Comando, tbxId.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarCarrera");
                    MessageBox.Show("Carrera Eliminada");
                    Refrescar();
                }
                else { MessageBox.Show("No existe ese ID."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un Id de Carrera a eliminar");
            }
        }
          
        private void EliminarCarrera_Load(object sender, EventArgs e)
        {
           SqlConnection F1 = new SqlConnection();
             AccesoDatos ac = new AccesoDatos();
          F1 = ac.ObtenerConexion();
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();

                  DGVCarrera.DataSource = dtCorredores;

                 F1.Close();
        }
        public void Refrescar()
        {

            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtCorredores;
        }
        public bool CompararID(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarrera.RowCount - 1; i++)
            {
                if (DGVCarrera.Rows[i].Cells["ID_Carrera"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void tbxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

    }
}
