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
    public partial class ModificarCircuito : Form
    {
        public ModificarCircuito()
        {
            InitializeComponent();
        }

        private void ModificarCircuito_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
        }

        private void ButBuscarDatosID_Click(object sender, EventArgs e)
        {
            Circuitos Circ = new Circuitos();
            if (tbxID.Text.ToString() != string.Empty)
            {
                if (Circ.CompararID(tbxID.Text) == true)
                {
                    AsignarTextBoxes(tbxID.Text);
                }
                else { MessageBox.Show("No existe ese ID."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un Id de Circuito existente.");
            }
        }
        public void AsignarTextBoxes(string id)
        {
            Circuitos Circ = new Circuitos();
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos= gp.ObtenerTodosLosCircuitos();
            Circ.DGVCircuitos.DataSource = dtCircuitos;
            for (int i = 0; i < Circ.DGVCircuitos.RowCount - 1; i++)
            {
                if (Circ.DGVCircuitos.Rows[i].Cells["ID_Circuito"].Value.ToString() == id)
                {
                    tbxNombre.Text = Circ.DGVCircuitos.Rows[i].Cells["Nombre_Circuito"].Value.ToString();
                    tbxPGP.Text = Circ.DGVCircuitos.Rows[i].Cells["PrimerGP_Circuito"].Value.ToString();
                    tbxPais.Text = Circ.DGVCircuitos.Rows[i].Cells["Pais_Circuito"].Value.ToString();
                    tbxLong.Text = Circ.DGVCircuitos.Rows[i].Cells["Longitud"].Value.ToString();
                }
            }

        }

        private void ButModificarCirc_Click(object sender, EventArgs e)
        {
            Circuitos Circ = new Circuitos();
            if (tbxID.Text.ToString() == string.Empty || tbxNombre.Text.ToString() == string.Empty ||
                tbxPGP.Text.ToString() == string.Empty || tbxPais.Text.ToString() == string.Empty
                || tbxLong.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Debe llenar los Campos para modificar un registro");
            }
            else
            {
                if (Circ.CompararID(tbxID.Text) == true)
                {
                    DataSet dsAgregar;
                    Gestion g = new Gestion();
                    dsAgregar = new DataSet();
                    SqlCommand Comando = new SqlCommand();
                    g.ArmarParametrosCircuitos(ref Comando, tbxNombre.Text, tbxPGP.Text, tbxPais.Text, tbxLong.Text,tbxID.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarCircuito");
                    MessageBox.Show("Circuito Modificado. Se requiere refrescar para ver los datos modificados.");

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

        private void tbxPGP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxLong_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
