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
    public partial class Corredores : Form
    {
        public Corredores()
        {
            InitializeComponent();
        }

        private void Corredores_Load(object sender, EventArgs e)
        {
            this.butRegresar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
            
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosCorredores();

            DGVCorredor.DataSource = dtCorredores;

            F1.Close();
        }

        private void butRegresar_Click(object sender, EventArgs e)
        {

        }

        private void Corredores_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Estos son los valores posibles
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    {
                        Application.Exit();
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
            }
        }

        private void ButAgregar_Click(object sender, EventArgs e)
        {
            AgregarCorredor Corr = new AgregarCorredor();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {
               
            }
        }

        private void ButRef_Click(object sender, EventArgs e)
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosCorredores();
            DGVCorredor.DataSource = dtCorredores;
        }

        private void ButEliminar_Click(object sender, EventArgs e)
        {
            EliminarCorredor Corr = new EliminarCorredor();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
        }
        public bool CompararID(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosCorredores();
            DGVCorredor.DataSource = dtCorredores;
            bool result = false;
            for(int i=0; i < DGVCorredor.RowCount-1;i++)
            {
                if (DGVCorredor.Rows[i].Cells["ID_Corredor"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }

        private void ButModificar_Click(object sender, EventArgs e)
        {
            ModificarCorredor Corr = new ModificarCorredor();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
    
}
