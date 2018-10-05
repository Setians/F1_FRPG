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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        private void ButRef_Click(object sender, EventArgs e)
        {
            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosEquipos();
            DGVEquipos.DataSource = dtEquipos;
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            this.butRegresar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();

            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosEquipos();
            DGVEquipos.DataSource = dtEquipos;

            F1.Close();
        }

        private void Equipos_FormClosing(object sender, FormClosingEventArgs e)
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
            AgregarEquipo Corr = new AgregarEquipo();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
        }
        private void ButEliminar_Click(object sender, EventArgs e)
        {
            EliminarEquipo Corr = new EliminarEquipo();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
        }
        public bool CompararID(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosEquipos();
            DGVEquipos.DataSource = dtEquipos;
            bool result = false;
            for (int i = 0; i < DGVEquipos.RowCount - 1; i++)
            {
                if (DGVEquipos.Rows[i].Cells["ID_Equipo"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }

        private void ButModificar_Click(object sender, EventArgs e)
        {
            ModificarEquipo Equi = new ModificarEquipo();
            Equi.ShowDialog();
            if (Equi.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
