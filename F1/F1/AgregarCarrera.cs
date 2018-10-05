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
    public partial class AgregarCarrera : Form
    {
        public AgregarCarrera()
        {
            InitializeComponent();
        }

        private void AgregarCarrera_Load(object sender, EventArgs e)
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

        private void butAgregar_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            if (CompararIDTemp(tbxIdTempo.Text) == true)
            {
                if(CompararIDCirc(tbxIDCirc.Text) == true)
                {
                    g.ArmarParametrosCarrera(ref Comando, tbxNombre.Text, tbxIDCirc.Text, tbxIdTempo.Text, tbxNumeroVueltas.Text, tbxDistancia.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarCarrera");
                    MessageBox.Show("Carrera Agregada");
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("No existe ese Circuito");
                }
                
            }
            else
            {
                MessageBox.Show("No existe esa temporada");
            }
           

        }
        public bool CompararIDTemp(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLosAñosTemporadas();
            DGVCarrera.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarrera.RowCount - 1; i++)
            {
                if (DGVCarrera.Rows[i].Cells["ID_Temporada"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarrera.DataSource = null;
            Refrescar();
            return result;
        }
        public bool CompararIDCirc(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLosCircuitos();
            DGVCarrera.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarrera.RowCount - 1; i++)
            {
                if (DGVCarrera.Rows[i].Cells["ID_Circuito"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarrera.DataSource = null;
            Refrescar();
            return result;
        }
        public void Refrescar()
        {

            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtCorredores;
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

        private void tbxIdTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxIDCirc_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxNumeroVueltas_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void tbxDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
