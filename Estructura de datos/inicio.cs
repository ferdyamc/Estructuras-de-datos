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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            if( !TxtPassword.Text.Any()){
                MessageBox.Show("Ingrese la contraseña", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPassword.Clear();
            }else if (TxtPassword.Text != "123")
            {
                MessageBox.Show("Contraseña incorrecta", "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPassword.Clear();
            }
            else{
                Menu datos = new Menu();
                datos.Show();
                this.Hide();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
