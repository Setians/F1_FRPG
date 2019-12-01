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
           "Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre" +
           " from F1_Corredores ";
            string where = " ";
            //if (chxPais.Checked == true)
            //{
            //    where = "where Pais_Corredor = " + "'" + ddlFiltroPaises.SelectedItem.ToString() + "' ";
            //}

            string order = " order by id asc";
            if (cbxOrdenadosFechaNacimiento.Checked == true)
            {
                order = " order by CONVERT( VARCHAR , FechaN_Corredor , 112 ) desc";
            }
            consulta = consulta + where + order;
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

            label1.Font = new Font(pfc.Families[0], Convert.ToSingle(10), FontStyle.Regular);
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

        private void chxPais_CheckedChanged(object sender, EventArgs e)
        {

            //AccesoDatos a = new AccesoDatos();
            //string consulta = "Select DISTINCT Pais_Corredor from F1_Corredores";
            //if (chxPais.Checked == true)
            //{
            //    a.llenarCbx(consulta, ddlFiltroPaises, "Pais_Corredor");

            //}
            //else
            //{
            //    ddlFiltroPaises.Items.Clear();
            //    Filtros();
            //}
            //a.cerrarConexion();
        }

        private void ddlFiltroPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtros();

        }

        private void cbxOrdenadosFechaNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            Filtros();
        }

        private void btnAgregarCircuito_Click(object sender, EventArgs e)
        {
            GestionCircuito g = new GestionCircuito();
            string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\Corredores\\");
            string Destino = "";
            if (File.Exists(PBXCircuito.ImageLocation.ToString()))
            {
                string ruta = PBXCircuito.ImageLocation.ToString();
                string[] extencion = ruta.Split('.');
                Destino = imagepath + TxtNombre.Text + TxtApellido.Text + '.' + extencion[1];
                File.Copy(PBXCircuito.ImageLocation.ToString(), Destino, true);

            }
            Circuito corredor = new Circuito(MtxtFecha.Text,TxtNombre.Text, TxtPais.Text, TxtLugar.Text, Destino);
            g.CargarCircuito(corredor);
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

        private void DGVCircuitos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

    }
}
