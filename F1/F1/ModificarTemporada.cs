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
    public partial class ModificarTemporada : Form
    {
        public ModificarTemporada()
        {
            InitializeComponent();
        }

        private void ModificarTemporada_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasTemporadas();

            DGVTemporada.DataSource = dtCorredores;

            F1.Close();
        }
        public void Refrescar()
        {

            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasTemporadas();
            DGVTemporada.DataSource = dtCorredores;
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
        public bool CompararID(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasTemporadas();
            DGVTemporada.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVTemporada.RowCount - 1; i++)
            {
                if (DGVTemporada.Rows[i].Cells["ID_Temporada"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }
        private void ButBuscarDatosID_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.ToString() != string.Empty)
            {
                if (CompararID(tbxId.Text) == true)
                {
                    AsignarTextBoxes(tbxId.Text);
                }
                else { MessageBox.Show("No existe esa temporada."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un año de temporada a Modificar");
            }
        }
        public void AsignarTextBoxes(string id)
        {
            
            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLasTemporadas();
            DGVTemporada.DataSource = dtEquipos;
            for (int i = 0; i < DGVTemporada.RowCount - 1; i++)
            {
                if (DGVTemporada.Rows[i].Cells["ID_Temporada"].Value.ToString() == id)
                {
                    textBox1.Text = DGVTemporada.Rows[i].Cells["Nombre_Temporada"].Value.ToString();
                    
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.ToString() == string.Empty || textBox1.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Debe llenar los Campos para modificar un registro");
            }
            else
            {
                if (CompararID(tbxId.Text) == true)
                {
                    DataSet dsAgregar;
                    Gestion g = new Gestion();
                    dsAgregar = new DataSet();
                    SqlCommand Comando = new SqlCommand();
                    g.ArmarParametrosTemporada(ref Comando, textBox1.Text, tbxId.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarTemporada");
                    MessageBox.Show("Temporada Modificada.");
                    Refrescar();

                }
                else { MessageBox.Show("No existe ese ID."); }
            }
        }
    }
}
