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
    public partial class AgregarCorredor : Form
    {
        public AgregarCorredor()
        {
            InitializeComponent();
        }

        private void AgregarCorredor_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
        }

        private void ButAgregarCorr_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            g.ArmarParametrosCorredores(ref Comando,tbxNombre.Text,tbxApellido.Text,tbxPais.Text,tbxLugar.Text,tbxFecha.Text);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarCorredor");
            MessageBox.Show("Corredor Agregado");
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

        private void tbxApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxPais_TextChanged(object sender, EventArgs e)
        {
            
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

        private void tbxDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
