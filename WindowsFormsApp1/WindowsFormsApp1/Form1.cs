using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<string> busqueda = new BindingList<string>();
        BaseDeDatos Base;


        public Form1()
        {
            InitializeComponent();
            panelBusqueda.Location = new Point(0,0);
            panelBienvenida.Location = new Point(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelBienvenida.Hide();
            panelBusqueda.Show();

        }

        private void tbBusqueda_Click(object sender, EventArgs e)
        {
            tbBusqueda.Text = "";
        }

        private void panelBusqueda_Click(object sender, EventArgs e)
        {
            tbBusqueda.Text = "🔎Busqueda...";
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {

            listboxBusqueda.DataSource = Base.busqueda(tbBusqueda.Text);
            listboxBusqueda.Refresh();
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {

        }
    }
}
