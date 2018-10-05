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
    public partial class AgregarTemporada : Form
    {
        public AgregarTemporada()
        {
            InitializeComponent();
        }

        private void AgregarTemporada_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            if(CompararID(tbxId.Text)==false)
            {
                g.ArmarParametrosTemporada(ref Comando, tbxNombre.Text, tbxId.Text);
                AccesoDatos ad = new AccesoDatos();
                ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarTemporada");
                MessageBox.Show("Temporada Agregada");
                Refrescar();
            }
            else
            {
                MessageBox.Show("Ya existe esa temporada");
            }
          
            
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
    }
}
