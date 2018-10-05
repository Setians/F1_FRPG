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
    public partial class AgregarEquipo : Form
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void ButAgregarEqui_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            g.ArmarParametrosEquipos(ref Comando, tbxNombre.Text, tbxCentEqui.Text, tbxJefEqui.Text, tbxJefTecEqui.Text, tbxAñoEqui.Text);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarEquipo");
            MessageBox.Show("Equipo Agregado");
        }

        private void AgregarEquipo_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
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
