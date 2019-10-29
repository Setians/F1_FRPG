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

namespace Formula1
{
    public partial class Corredores : Form
    {
        public Corredores()
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
            string consulta = "Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores";
            string order = " order by id asc";
            consulta = consulta + order;
            DGVCorredores.DataSource = conexion.LlenarDataGridViewConsulta(consulta);
            conexion.cerrarConexion();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Corredores_Load(object sender, EventArgs e)
        {
            llenarDgv();
            string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "F1 Font Files (with important Message)\\Formula1-Bold.otf");
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(imagepath);
            foreach(Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], Convert.ToSingle(8.10) , FontStyle.Regular);
            }

            label1.Font = new Font(pfc.Families[0], Convert.ToSingle(10), FontStyle.Regular);
            label30.Font = new Font(pfc.Families[0], Convert.ToSingle(10), FontStyle.Regular);
            imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "F1 Font Files (with important Message)\\Formula1-Regular.otf");
            pfc.AddFontFile(imagepath);
            DGVCorredores.DefaultCellStyle.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            DGVCorredores.AlternatingRowsDefaultCellStyle.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            
            label2.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label4.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label6.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label8.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label10.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label12.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label14.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label16.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label18.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            label3.Font = new Font(pfc.Families[1], Convert.ToSingle(8.10), FontStyle.Regular);
            
            DGVCorredores.Focus();
            // DGVCorredores.CurrentCell = DGVCorredores.Rows[0].Cells[0];
            //DGVCorredores.ClearSelection();
            PanelFiltros.Hide();
            





        }

        private void DGVCorredores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PanelCorredores.Show();
                DataGridViewRow row = this.DGVCorredores.Rows[e.RowIndex];
                AccesoDatos a = new AccesoDatos();
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Select Pais_Corredor from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label4, "Pais_Corredor");
                consulta = "Select CONVERT( VARCHAR , FechaN_Corredor , 103 )as fecha from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label18, "fecha");
                consulta = "Select LugarN_Corredor from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label3, "LugarN_Corredor");
                consulta = "Select Imagen_Corredor from F1_Corredores where ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label6, "Imagen_Corredor");
                string imagepath = label6.Text;
                label6.Text = "label6";
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                conexion.cerrarConexion();
                
                
            }
        }

        private void DGVCorredores_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index >= 0 && e.Row.Selected==true )
            {
                PanelCorredores.Show();
                
                PanelFiltros.Hide();
                DataGridViewRow row = this.DGVCorredores.Rows[e.Row.Index];
                AccesoDatos a = new AccesoDatos();
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "Select Pais_Corredor from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label4, "Pais_Corredor");
                consulta = "Select CONVERT( VARCHAR , FechaN_Corredor , 103 )as fecha from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label18, "fecha");
                consulta = "Select LugarN_Corredor from F1_Corredores where F1_Corredores.ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label3, "LugarN_Corredor");
                consulta = "Select Imagen_Corredor from F1_Corredores where ID_Corredor = " + row.Cells["ID"].Value.ToString();
                conexion.Llenar_Label(consulta, label6, "Imagen_Corredor");
                string imagepath = label6.Text;
                label6.Text = "label6";
                pictureBox1.Image = Image.FromFile(imagepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                conexion.cerrarConexion();
                
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVCorredores.ClearSelection();
            PanelCorredores.Hide();
            PanelFiltros.Show();
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            AccesoDatos a = new AccesoDatos();
            string consulta = "Select DISTINCT Pais_Corredor from F1_Corredores";
            if (chxPais.Checked ==true)
            {
                a.llenarCbx(consulta, CbxFiltroPaises, "Pais_Corredor");
                
            }
            else
            {
                CbxFiltroPaises.Items.Clear();
                llenarDgv();

            }
            a.cerrarConexion();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccesoDatos a = new AccesoDatos();
            string consulta = "Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores where Pais_Corredor = " + "'"+CbxFiltroPaises.SelectedItem.ToString()+ "'";
            string order = " order by id asc";

            if (cbxOrdenadosFechaNacimiento.Checked == true)
            {
                order = " order by CONVERT( VARCHAR , FechaN_Corredor , 112 ) desc";
            }

            
            consulta = consulta + order;
         
            DGVCorredores.DataSource= a.LlenarDataGridViewConsulta(consulta);
            DGVCorredores.ClearSelection();
            a.cerrarConexion();
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            AccesoDatos a = new AccesoDatos();
            
            if (cbxOrdenadosFechaNacimiento.Checked == true)
            {
                string consulta = "Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores ";
                    
                   if(chxPais.Checked == true)
                   {
                    consulta = consulta + " where Pais_Corredor = " + "'"+CbxFiltroPaises.SelectedItem.ToString()+ "'";
                   }
                    
                  consulta = consulta +  " order by CONVERT( VARCHAR , FechaN_Corredor , 112 ) desc";
                DGVCorredores.DataSource = a.LlenarDataGridViewConsulta(consulta);

            }
            else
            {
                string consulta = "Select ID_Corredor as ID, (Nombre_Corredor+ ' '+ Apellido_Corredor )as Nombre from F1_Corredores ";

                if (chxPais.Checked == true)
                {
                    consulta = consulta + " where Pais_Corredor = " + "'" + CbxFiltroPaises.SelectedItem.ToString() + "'";
                }

                consulta = consulta + " order by ID asc";
                DGVCorredores.DataSource = a.LlenarDataGridViewConsulta(consulta);


            }
            a.cerrarConexion();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionCorredor g = new GestionCorredor();
            string imagepath = Path.Combine(Application.StartupPath, @"..\..\..\" + "imagenes\\Corredores\\");
            string Destino = "";
            if (File.Exists(PBXCorredor.ImageLocation.ToString()))
            {
                string ruta = PBXCorredor.ImageLocation.ToString();
                string[] extencion = ruta.Split('.');
                Destino = imagepath + TxtNombre.Text + TxtApellido.Text + '.' + extencion[1];
                File.Copy(PBXCorredor.ImageLocation.ToString(), Destino ,true);
                
            }
            
            g.CargarCorredor(TxtNombre.Text, TxtApellido.Text, TxtLugar.Text, TxtPais.Text, DateTime.Parse(MtxtFecha.Text), Destino);
            MessageBox.Show("El registro se cargo correctamente","",MessageBoxButtons.OK);
            llenarDgv();
        }

        private void PBXCorredor_Click(object sender, EventArgs e)
        {
            OpenFileDialog ObtenerImagen = new OpenFileDialog();
            ObtenerImagen.InitialDirectory = "C:\\Users\\Public\\Pictures";
            ObtenerImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif  ";

            if(ObtenerImagen.ShowDialog()== DialogResult.OK)
            {
                PBXCorredor.ImageLocation = ObtenerImagen.FileName;
                
            }
            else
            {
                MessageBox.Show("No se selecciono imagen","Sin Seleccion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }



    }
}
