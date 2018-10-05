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
    public partial class ModificarCarrera : Form
    {
        public ModificarCarrera()
        {
            InitializeComponent();
        }

        private void ModificarCarrera_Load(object sender, EventArgs e)
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
        public void Refrescar()
        {

            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtCorredores;
        }
        public bool CompararIDCarrera(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarrera.RowCount - 1; i++)
            {
                if (DGVCarrera.Rows[i].Cells["ID_Carrera"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            return result;
        }
        private void ButBuscarDatosID_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.ToString() != string.Empty)
            {
                if (CompararIDCarrera(tbxId.Text) == true)
                {
                    AsignarTextBoxes(tbxId.Text);
                }
                else { MessageBox.Show("No existe esa Carrera."); }

            }
            else
            {
                MessageBox.Show("Debe incertar un ID de Carrera a Modificar");
            }
        }
        public void AsignarTextBoxes(string id)
        {

            Gestion gp = new Gestion();
            DataTable dtEquipos;
            dtEquipos = gp.ObtenerTodosLasCarreras();
            DGVCarrera.DataSource = dtEquipos;
            for (int i = 0; i < DGVCarrera.RowCount - 1; i++)
            {
                if (DGVCarrera.Rows[i].Cells["ID_Carrera"].Value.ToString() == id)
                {
                    tbxIDCirc.Text = DGVCarrera.Rows[i].Cells["ID_Circuito_Carrera"].Value.ToString();
                    tbxIdTempo.Text = DGVCarrera.Rows[i].Cells["id_Temporada"].Value.ToString();
                    tbxNombre.Text = DGVCarrera.Rows[i].Cells["Nombre_Carrera"].Value.ToString();
                    tbxNumeroVueltas.Text = DGVCarrera.Rows[i].Cells["NumeroVueltas_Carrera"].Value.ToString();
                    tbxDistancia.Text = DGVCarrera.Rows[i].Cells["Distancia_Carrera"].Value.ToString();
                }
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
        private void butModificar_Click(object sender, EventArgs e)
        {
            if (tbxId.Text.ToString() == string.Empty || tbxDistancia.Text.ToString() == string.Empty
                || tbxNombre.Text.ToString() == string.Empty || tbxIDCirc.Text.ToString() == string.Empty
                || tbxNumeroVueltas.Text.ToString() == string.Empty
                || tbxIdTempo.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Debe llenar los Campos para modificar un registro");
            }
            else
            {
                if (CompararIDCarrera(tbxId.Text) == true)
                {
                    if(CompararIDTemp(tbxIdTempo.Text)==true)
                    {
                        if(CompararIDCirc(tbxIDCirc.Text)==true)
                        {
                            DataSet dsAgregar;
                            Gestion g = new Gestion();
                            dsAgregar = new DataSet();
                            SqlCommand Comando = new SqlCommand();
                            g.ArmarParametrosCarrera(ref Comando, tbxNombre.Text,tbxId.Text,tbxIDCirc.Text,tbxIdTempo.Text,tbxNumeroVueltas.Text,tbxDistancia.Text);
                            AccesoDatos ad = new AccesoDatos();
                            ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarCarrera");
                            MessageBox.Show("Carrera Modificada.");
                            Refrescar();
                        }
                        else
                        {
                            MessageBox.Show("No existe ese Circuito");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe esa Temporada");
                    }

                }
                else { MessageBox.Show("No existe ese ID de Carrera."); }
            }
        }
    }
}
