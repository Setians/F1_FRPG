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
    public partial class Circuitos : Form
    {
        public Circuitos()
        {
            InitializeComponent();
        }

        private void Circuitos_Load(object sender, EventArgs e)
        {
            this.butRegresar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();

            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosCircuitos();
            DGVCircuitos.DataSource = dtEquipos;

            F1.Close();
        }

        private void ButRef_Click(object sender, EventArgs e)
        {

            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLosCircuitos();
            DGVCircuitos.DataSource = dtEquipos;
        }

        private void Circuitos_FormClosing(object sender, FormClosingEventArgs e)
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

        public bool CompararID(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLosCircuitos();
            DGVCircuitos.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCircuitos.RowCount - 1; i++)
            {
                if (DGVCircuitos.Rows[i].Cells["ID_Circuito"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }

        private void ButAgregar_Click(object sender, EventArgs e)
        {
            AgregarCircuito Circ = new AgregarCircuito();
            Circ.ShowDialog();
            if (Circ.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void ButEliminar_Click(object sender, EventArgs e)
        {
            EliminarCircuito Circ = new EliminarCircuito();
            Circ.ShowDialog();
            if (Circ.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void ButModificar_Click(object sender, EventArgs e)
        {
            ModificarCircuito Circ = new ModificarCircuito();
            Circ.ShowDialog();
            if (Circ.DialogResult == DialogResult.Yes)
            {

            }
        }
    }
}
