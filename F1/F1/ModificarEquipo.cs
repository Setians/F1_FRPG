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
    public partial class ModificarEquipo : Form
    {
        public ModificarEquipo()
        {
            InitializeComponent();
        }

        private void ModificarEquipo_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
        }

        private void ButBuscarDatosID_Click(object sender, EventArgs e)
        {
            Equipos Equi= new Equipos();
            if (tbxID.Text.ToString() != string.Empty)
            {
                if (Equi.CompararID(tbxID.Text) == true)
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
            Equipos corr = new Equipos();
            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosEquipos();
            corr.DGVEquipos.DataSource = dtEquipos;
            for (int i = 0; i < corr.DGVEquipos.RowCount - 1; i++)
            {
                if (corr.DGVEquipos.Rows[i].Cells["ID_Equipo"].Value.ToString() == id)
                {
                    tbxNombre.Text = corr.DGVEquipos.Rows[i].Cells["Nombre_Equipo"].Value.ToString();
                    tbxCentEqui.Text = corr.DGVEquipos.Rows[i].Cells["Central_Equipos"].Value.ToString();
                    tbxJefEqui.Text = corr.DGVEquipos.Rows[i].Cells["Jefe_Equipo"].Value.ToString();
                    tbxJefTecEqui.Text = corr.DGVEquipos.Rows[i].Cells["JefeT_Equipo"].Value.ToString();
                    tbxAñoEqui.Text = corr.DGVEquipos.Rows[i].Cells["AñoD_Equipo"].Value.ToString();

                }
            }

        }

        private void ButModificarEqui_Click(object sender, EventArgs e)
        {
            Corredores corr = new Corredores();
            if (tbxID.Text.ToString() == string.Empty || tbxNombre.Text.ToString() == string.Empty ||
                tbxCentEqui.Text.ToString() == string.Empty || tbxJefEqui.Text.ToString() == string.Empty
                || tbxJefTecEqui.Text.ToString() == string.Empty || tbxAñoEqui.Text.ToString() == string.Empty)
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
                    g.ArmarParametrosEquipos(ref Comando, tbxNombre.Text, tbxCentEqui.Text, tbxJefEqui.Text, tbxJefTecEqui.Text, tbxAñoEqui.Text, tbxID.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarEquipo");
                    MessageBox.Show("Equipo Modificado. Se requiere refrescar para ver los datos modificados.");

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

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxCentEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxJefEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxJefTecEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void tbxAñoEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
