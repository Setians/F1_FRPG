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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ButTemp_Click(object sender, EventArgs e)
        {
            Temporadas temp = new Temporadas();
            this.Hide();
            temp.ShowDialog();
            if (temp.DialogResult == DialogResult.Yes)
            {
                this.Show();
            }
        }

        private void ButCorredores_Click(object sender, EventArgs e)
        {
            Corredores Corr = new Corredores();
            this.Hide();
            Corr.ShowDialog();            
            if (Corr.DialogResult == DialogResult.Yes)
            {
                this.Show();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ButEquipos_Click(object sender, EventArgs e)
        {
            Equipos Equi= new Equipos();
            this.Hide();
            Equi.ShowDialog();
            if (Equi.DialogResult == DialogResult.Yes)
            {
                this.Show();
            }
        }

        private void ButCircuitos_Click(object sender, EventArgs e)
        {
            Circuitos Equi = new Circuitos();
            this.Hide();
            Equi.ShowDialog();
            if (Equi.DialogResult == DialogResult.Yes)
            {
                this.Show();
            }
        }
    }
}
