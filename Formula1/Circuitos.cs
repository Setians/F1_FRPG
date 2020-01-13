﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Text;
using Formula1.Clases;
using Formula1.Gestion;

namespace Formula1
{
    public partial class Circuitos : Form
    {
        public Circuitos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarDgv()
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "Select ID_Circuito as ID, (Nombre_Circuito) as Nombre from F1_Circuitos";
            string order = " order by id asc";
            consulta = consulta + order;
            DGVCircuitos.DataSource = conexion.LlenarDataGridViewConsulta(consulta);
            conexion.cerrarConexion();
        }

        private void Filtros()
        {
            AccesoDatos a = new AccesoDatos();
            string consulta = "" +
           "Select ID_Circuito as ID, (Nombre_Circuito) as Nombre " +
           " from F1_Circuitos ";
            //string where = " ";
            string order = " order by id asc";
            if (ChxMayorLongitud.Checked == true)
            {
                order = " order by Longitud asc";
            }
            if (cbxOrdenadosPrimerGP.Checked == true)
            {
                order = " order by PrimerGP_Circuito asc";
            }
            consulta = consulta + order;
            //consulta = consulta + where + order;
            DGVCircuitos.DataSource = a.LlenarDataGridViewConsulta(consulta);
            DGVCircuitos.ClearSelection();
            a.cerrarConexion();
        }

        private void Fuente()
        {
            string fontPath = Path.Combine(Application.StartupPath, @"..\..\..\" + "F1 Font Files (with important Message)\\Formula1-Bold.otf");
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(fontPath);
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], Convert.ToSingle(8.10), FontStyle.Regular);
            }

            lbl_A_Circuito.Font = new Font(pfc.Families[0], Convert.ToSingle(10), FontStyle.Regular);
            //label30.Font = new Font(pfc.Families[0], Convert.ToSingle(10), FontStyle.Regular);
            fontPath = Path.Combine(Application.StartupPath, @"..\..\..\" + "F1 Font Files (with important Message)\\Formula1-Regular.otf");
            pfc.AddFontFile(fontPath);
            DGVCircuitos.DefaultCellStyle.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            DGVCircuitos.AlternatingRowsDefaultCellStyle.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);

            lblPais_D.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            lblLongitud_D.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            lblPGP_D.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Circuitos_Load(object sender, EventArgs e)
        {
            //Se llena la DGV con todos los corredores ordenados por id.
            llenarDgv();
            //Se establece la fuente a todos los controles de esta form
            Fuente();
            DGVCircuitos.Focus();
            PanelFiltros.Hide();
            txtMNombre.Hide();
            txtMNombre.Location =  lblNombre.PointToScreen(lblNombre.Location); 
            txtMLongitud.Hide();
            txtMLongitud.Location = lblLongitud_D.PointToScreen(Point.Empty);
            txtMPais.Hide();
            txtMPais.Location = lblPais_D.PointToScreen(Point.Empty);
            txtMPrimerGP.Hide();
            txtMPrimerGP.Location = lblPGP_D.PointToScreen(Point.Empty);
        }

        private void DGVCircuitos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index >= 0 && e.Row.Selected == true)
            {
                PanelCorredores.Show();
                PanelFiltros.Hide();
                DataGridViewRow row = this.DGVCircuitos.Rows[e.Row.Index];
                AccesoDatos conexion = new AccesoDatos();
                GestionCircuito gestionCircuito = new GestionCircuito();
                string id = row.Cells["ID"].Value.ToString();
                lblPais_D.Text = gestionCircuito.ObtenerPais(id);
                lblLongitud_D.Text = gestionCircuito.ObtenerLongitud(id);
                lblPGP_D.Text= gestionCircuito.ObtenerPrimerGP(id);
                lblNombre.Text = gestionCircuito.ObtenerNombre(id);
                if (gestionCircuito.ObtenerImagen(id) != null)
                {
                    string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + gestionCircuito.ObtenerImagen(id));
                    pbx_Circuito_Carga.Image = Image.FromFile(imagepath);
                    pbx_Circuito_Carga.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbx_Circuito_Carga.Image = null;
                }
                conexion.cerrarConexion();
            }

        }

        private void BtnFiltros_Click(object sender, EventArgs e)
        {
            DGVCircuitos.ClearSelection();
            PanelCorredores.Hide();
            PanelFiltros.Show();

        }

        private void ddlFiltroTemporadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtros();

        }


        private void ChxMayorLongitud_CheckedChanged(object sender, EventArgs e)
        {
            Filtros();
        }

        private void cbxOrdenadosPrimerGP_CheckedChanged(object sender, EventArgs e)
        {
            Filtros();
        }

        private void btnAgregarCircuito_Click(object sender, EventArgs e)
        {
            GestionCircuito g = new GestionCircuito();
            string imagepath = "imagenes\\Circuitos\\";
            string Destino = "";
            if (File.Exists(PBXCircuito.ImageLocation.ToString()))
            {
                string ruta = PBXCircuito.ImageLocation.ToString();
                string[] extencion = ruta.Split('.');
                Destino = imagepath + TxtNombre.Text + '.' + extencion[1];
            }
            Circuito circuito = new Circuito(TxtPrimerGP.Text,TxtNombre.Text, TxtLongitud.Text, TxtPrimerGP.Text, Destino);
            g.CargarCircuito(circuito);
            Destino = Path.Combine(Application.StartupPath, @"..\..\..\" + Destino);
            File.Copy(PBXCircuito.ImageLocation.ToString(), Destino, true);
            MessageBox.Show("El registro se cargo correctamente", "", MessageBoxButtons.OK);
            llenarDgv();
        }

        private void PBXCircuito_Click(object sender, EventArgs e)
        {
            OpenFileDialog ObtenerImagen = new OpenFileDialog();
            ObtenerImagen.InitialDirectory = "C:\\Users\\Public\\Pictures";
            ObtenerImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif  ";

            if (ObtenerImagen.ShowDialog() == DialogResult.OK)
            {
                PBXCircuito.ImageLocation = ObtenerImagen.FileName;

            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "Sin Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtMNombre.Show();
            lblNombre.Hide();
            txtMLongitud.Show();
            txtMPais.Show();
            txtMPrimerGP.Show();
        }
    }
}
