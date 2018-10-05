using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class Temporadas : Form
    {
        public Temporadas()
        {
            InitializeComponent();
        }

        private void Temporadas_Load(object sender, EventArgs e)
        {
            this.butRegresar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            label3.Hide();
            comboBox1.Hide();
            RButXCorredor.Show();
            RbutXEquipo.Show();
            checkBox1.Checked = false;
            CargarComboboxTemporada();
            CBXTemp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvTemp2.Hide();
        }



        private void Temporadas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label3.Show();
                comboBox1.Show();
                RButXCorredor.Hide();
                RButXCorredor.Checked = false;
                RbutXEquipo.Hide();
                RbutXEquipo.Checked = false;
            }
            else
            {

                label3.Hide();
                comboBox1.Hide();
                RButXCorredor.Show();

                RbutXEquipo.Show();

            }
        }

        private void butAgregarTemp_Click(object sender, EventArgs e)
        {
            AgregarTemporada Corr = new AgregarTemporada();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            CBXTemp.Items.Clear();
            CargarComboboxTemporada();
        }

        private void butEliminarTemp_Click(object sender, EventArgs e)
        {
            EliminarTemporada Corr = new EliminarTemporada();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            CBXTemp.Items.Clear();
            CargarComboboxTemporada();
        }

        private void CargarComboboxTemporada()
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosAñosTemporadas();
            DGVTemp.DataSource = dtCorredores;
            for (int i = 0; i < DGVTemp.RowCount - 1; i++)
            {

                CBXTemp.Items.Add(DGVTemp.Rows[i].Cells["ID_Temporada"].Value.ToString());

            }
            DGVTemp.DataSource = null;
        }
        private void CargarComboboxCarrera()
        {
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosNombresCarreras(CBXTemp.Text);
            DGVTemp.DataSource = dtCorredores;
            for (int i = 0; i < DGVTemp.RowCount - 1; i++)
            {

                comboBox1.Items.Add(DGVTemp.Rows[i].Cells["Nombre_Carrera"].Value.ToString());

            }
            DGVTemp.DataSource = null;
        }

        private void ButModificarTemp_Click(object sender, EventArgs e)
        {
            ModificarTemporada Corr = new ModificarTemporada();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            CBXTemp.Items.Clear();
            CargarComboboxTemporada();
        }

        private void butAgregarCarrera_Click(object sender, EventArgs e)
        {
            AgregarCarrera Corr = new AgregarCarrera();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            comboBox1.Items.Clear();
            CargarComboboxCarrera();
        }

        private void CBXTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            CargarComboboxCarrera();
        }

        private void butEliminarCarrera_Click(object sender, EventArgs e)
        {
            EliminarCarrera Corr = new EliminarCarrera();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            comboBox1.Items.Clear();
            CargarComboboxCarrera();
        }

        private void butModificarCarrera_Click(object sender, EventArgs e)
        {
            ModificarCarrera Corr = new ModificarCarrera();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            comboBox1.Items.Clear();
            CargarComboboxCarrera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultadoCarrera Corr = new ResultadoCarrera();
            Corr.ShowDialog();
            if (Corr.DialogResult == DialogResult.Yes)
            {

            }
            comboBox1.Items.Clear();
            CargarComboboxCarrera();
        }

        private void RButXCorredor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Gestion gp = new Gestion();
            DataTable dtCorredores;
            dtCorredores = gp.ObtenerTodosLosResultados();
            dgvTemp2.DataSource = dtCorredores;
            for (int i = 0; i < dgvTemp2.RowCount - 1; i++)
            {

                DGVTemp.Rows[i]=g.;

            }
            //DGVTemp.DataSource = null;
            */
        }
        
    }
}
