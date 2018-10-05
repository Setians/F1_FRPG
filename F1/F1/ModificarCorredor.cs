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
    public partial class ModificarCorredor : Form
    {
        public ModificarCorredor()
        {
            InitializeComponent();
        }

        private void ModificarCorredor_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
        }

        private void ButBuscarDatosID_Click(object sender, EventArgs e)
        {
            Corredores corr = new Corredores();
            if (tbxID.Text.ToString() != string.Empty)
            {
                if (corr.CompararID(tbxID.Text) == true)
                {
                    AsignarTextBoxes(tbxID.Text);
                }
                else { MessageBox.Show("No existe ese ID."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un Id de corredor a Modificar");
            }
        }
        public void AsignarTextBoxes(string id)
        {
            Corredores corr = new Corredores();
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosCorredores();
            corr.DGVCorredor.DataSource = dtCorredores;
            for (int i = 0; i < corr.DGVCorredor.RowCount - 1; i++)
            {
                if (corr.DGVCorredor.Rows[i].Cells["ID_Corredor"].Value.ToString() == id)
                {
                    tbxNombre.Text = corr.DGVCorredor.Rows[i].Cells["Nombre_Corredor"].Value.ToString();
                    tbxApellido.Text = corr.DGVCorredor.Rows[i].Cells["Apellido_Corredor"].Value.ToString();
                    tbxPais.Text = corr.DGVCorredor.Rows[i].Cells["Pais_Corredor"].Value.ToString();
                    tbxLugar.Text = corr.DGVCorredor.Rows[i].Cells["LugarN_Corredor"].Value.ToString();
                    tbxFecha.Text =  Convert.ToDateTime(corr.DGVCorredor.Rows[i].Cells["FechaN_Corredor"].Value).ToString("dd-MM-yyyy");
                    
                }
            }
            
        }

        private void ButModificarCorr_Click(object sender, EventArgs e)
        {
            Corredores corr = new Corredores();
            if (tbxID.Text.ToString() == string.Empty|| tbxNombre.Text.ToString()==string.Empty||
                tbxApellido.Text.ToString()==string.Empty||tbxPais.Text.ToString()==string.Empty
                ||tbxLugar.Text.ToString()==string.Empty||tbxFecha.Text.ToString()==string.Empty)
            {
                MessageBox.Show("Debe llenar los Campos para modificar un registro");
            }
            else
            {
                if (corr.CompararID(tbxID.Text) == true)
                {
                    DataSet dsAgregar;
                    Gestion g = new Gestion();
                    dsAgregar = new DataSet();
                    SqlCommand Comando = new SqlCommand();
                    g.ArmarParametrosCorredores(ref Comando, tbxNombre.Text, tbxApellido.Text, tbxPais.Text, tbxLugar.Text, tbxFecha.Text, tbxID.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarCorredor");
                    MessageBox.Show("Corredor Modificado. Se requiere refrescar para ver los datos modificados.");

                }
                else { MessageBox.Show("No existe ese ID."); }
            }
          


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


        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
