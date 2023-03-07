using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_datos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void BtnPila_Click(object sender, EventArgs e)
        {
            Pila MiPila = new Pila();
            MiPila.Show();
            this.Hide();
        }
        private void BtnCola_Click(object sender, EventArgs e)
        {
            Cola MiCola = new Cola();
            MiCola.Show();
            this.Hide();
        }
        private void BtnLista_Click(object sender, EventArgs e)
        {
            Lista MiLista = new Lista();
            MiLista.Show();
            this.Hide();
        }
        private void BtnSalir_Click (object sender, EventArgs e)
        {
            Inicio MiInicio = new Inicio();
            MiInicio.Show();
            this.Hide();

        }
    }
}
