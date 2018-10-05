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
    public partial class ResultadoCarrera : Form
    {
        public ResultadoCarrera()
        {
            InitializeComponent();
        }

        private void ResultadoCarrera_Load(object sender, EventArgs e)
        {
            SqlConnection F1 = new SqlConnection();
            AccesoDatos ac = new AccesoDatos();
            F1 = ac.ObtenerConexion();
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();

            DGVCarreras.DataSource = dtCorredores;
            dtCorredores = gp.ObtenerTodosLosEquiposxCorredor();
            DGVTCE.DataSource = dtCorredores;
            dtCorredores = gp.ObtenerTodosLosResultados();
            DGVCC.DataSource = dtCorredores;
            F1.Close();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            if (CompararIDCarrera(tbxIdCarrera.Text) == true)
            {
                if (CompararIDCorredor(tbxIDCorredor.Text) == true)
                {
                    
                        AccesoDatos ad = new AccesoDatos();
                        g.ArmarParametrosCarreraXCorredor(ref Comando, tbxIdCarrera.Text, tbxIDCorredor.Text, tbxPosGrill.Text, tbxPorFin.Text, tbxVC.Text, MTbXTiempo.Text);
                        ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarCorredorXCarrera");
                        MessageBox.Show("Resutado Agregado Correctamente.");
                        RefrescarCar();
                        RefrescarCC();
                        RefrescarCET();
                    
                    
                }
                else
                {
                    MessageBox.Show("No existe ese Corredor");
                }

            }
            else
            {
                MessageBox.Show("No existe esa Carrera");
            }
            
        }
        public bool CompararIDCarrera(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasCarreras();
            DGVCarreras.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarreras.RowCount - 1; i++)
            {
                if (DGVCarreras.Rows[i].Cells["ID_Carrera"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarreras.DataSource = null;
            RefrescarCar();
            return result;
        }
        public void RefrescarCar()
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLasCarreras();
            DGVCarreras.DataSource = dtCorredores;
        }
        public void RefrescarCET()
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosEquiposxCorredor();
            DGVTCE.DataSource = dtCorredores;
        }
        public void RefrescarCC()
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosResultados();
            DGVCC.DataSource = dtCorredores;
        }

        public bool CompararIDCorredor(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLosCorredores();
            DGVCarreras.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarreras.RowCount - 1; i++)
            {
                if (DGVCarreras.Rows[i].Cells["ID_Corredor"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarreras.DataSource = null;
            RefrescarCar();
            return result;
        }
        public bool CompararIDEquipo(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLosEquipos();
            DGVCarreras.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarreras.RowCount - 1; i++)
            {
                if (DGVCarreras.Rows[i].Cells["ID_Equipo"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarreras.DataSource = null;
            RefrescarCar();
            return result;
        }
        public bool CompararIDTemporada(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasTemporadas();
            DGVCarreras.DataSource = dtCircuitos;
            bool result = false;
            for (int i = 0; i < DGVCarreras.RowCount - 1; i++)
            {
                if (DGVCarreras.Rows[i].Cells["ID_Temporada"].Value.ToString() == id)
                {
                    result = true;
                }
            }
            DGVCarreras.DataSource = null;
            RefrescarCar();
            return result;
        }
        public string TemporadaCarrera(string id)
        {
            Gestion gp = new Gestion();
            DataTable dtCircuitos;
            dtCircuitos = gp.ObtenerTodosLasCarreras();
            DGVCarreras.DataSource = dtCircuitos;
            string result= "xd";
            for (int i = 0; i < DGVCarreras.RowCount - 1; i++)
            {
                if (DGVCarreras.Rows[i].Cells["ID_Carrera"].Value.ToString() == id)
                {
                    result = DGVCarreras.Rows[i].Cells["ID_Temporada"].Value.ToString();
                }
            }
            DGVCarreras.DataSource = null;
            RefrescarCar();
            return result;
        }

        private void ButAgregarEquipo_Click(object sender, EventArgs e)
        {
            DataSet dsAgregar;
            Gestion g = new Gestion();
            dsAgregar = new DataSet();
            SqlCommand Comando = new SqlCommand();
            if (CompararIDTemporada(tbxTemporada.Text) == true)
            {
                if (CompararIDCorredor(tbxCorr.Text) == true)
                {
                    if (CompararIDEquipo(TbxEquipo.Text) == true)
                    {
                        AccesoDatos ad = new AccesoDatos();
                        g.ArmarParametrosEquipoXCorredor(ref Comando, tbxCorr.Text, TbxEquipo.Text, tbxTemporada.Text);
                        ad.EjecutarProcedimientoAlmacenado(Comando, "spInsertarEquipoXCorredor");
                        MessageBox.Show("Equipo Agregado Correctamente.");
                        RefrescarCar();
                        RefrescarCC();
                        RefrescarCET();
                    }
                    else
                    {
                        MessageBox.Show("No existe ese Equipo");
                    }

                }
                else
                {
                    MessageBox.Show("No existe ese Corredor");
                }

            }
            else
            {
                MessageBox.Show("No existe esa Temporada");
            }
        }
    }
}
