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
    public partial class EliminarEquipo : Form
    {
        public EliminarEquipo()
        {
            InitializeComponent();
        }

        private void ButEliminarCorr_Click(object sender, EventArgs e)
        {

        }

        private void EliminarEquipo_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
        }

        private void ButEliminarEqui_Click(object sender, EventArgs e)
        {
            Equipos Equi= new Equipos();
            if (tbxEliminar.Text.ToString() != string.Empty)
            {
                if (Equi.CompararID(tbxEliminar.Text) == true)
                {
                    DataSet dsAgregar;
                    Gestion g = new Gestion();
                    dsAgregar = new DataSet();
                    SqlCommand Comando = new SqlCommand();
                    g.ArmarParametrosEquipoEliminar(ref Comando, tbxEliminar.Text);
                    AccesoDatos ad = new AccesoDatos();
                    ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarEquipo");
                    MessageBox.Show("Equipo Eliminado");
                }
                else { MessageBox.Show("No existe ese ID."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un Id del Equipo a eliminar");
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

        private void ButEliminarEqui_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
