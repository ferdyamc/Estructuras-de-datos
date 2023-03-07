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
    public partial class Cola : Form
    {
        public Cola()
        {
            InitializeComponent();
        }

        Queue<EmpleadoCola> MiColaEmpleado = new Queue<EmpleadoCola>();

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Menu MiMenu = new Menu();
            MiMenu.Show();
            this.Hide();
        }

        private void OpRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtIdentificacion.Text == "")
            {
                EpvError.SetError(TxtIdentificacion, "Debe Ingresear una identificación");
                TxtIdentificacion.Focus();
                return;
            }
            EpvError.SetError(TxtIdentificacion, "");

            if (TxtIdentificacion.Text == "")
            {
                EpvError.SetError(TxtNombre, "Debe Ingresear una Nombre");
                TxtNombre.Focus();
                return;
            }
            EpvError.SetError(TxtNombre, "");


            if (TxtSalarioAsignado.Text == "")
            {
                EpvError.SetError(TxtSalarioAsignado, "Debe Ingresar un Salario");
                TxtSalarioAsignado.Focus();
                return;
            }
            EpvError.SetError(TxtSalarioAsignado, "");

            decimal salario;

            if(!Decimal.TryParse(TxtSalarioAsignado.Text, out salario))
            {
                EpvError.SetError(TxtSalarioAsignado, "Debe ingresar un valor numerico");
                TxtSalarioAsignado.Focus();
                return;
            }
            EpvError.SetError(TxtSalarioAsignado, "");


            EmpleadoCola MiEmpleado = new EmpleadoCola();

            MiEmpleado.Identificacion = TxtIdentificacion.Text;
            MiEmpleado.Nombre = TxtNombre.Text;
            MiEmpleado.Salaio = Decimal.Parse(TxtSalarioAsignado.Text);
            MiEmpleado.Fecha = DttFecha.Value;

            MiColaEmpleado.Enqueue(MiEmpleado);

            DtgEmpleadosCola.DataSource = null;
            DtgEmpleadosCola.DataSource = MiColaEmpleado.ToList();

            Limpiar_controles();

            TxtIdentificacion.Focus();
        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            Inicio MiInicio = new Inicio();
            MiInicio.Show();
            this.Hide();
        }

        private void OpEliminar_Click(object sender, EventArgs e)
        {
            if(MiColaEmpleado.Count != 0)
            {
                EmpleadoCola MiEmpleado = new EmpleadoCola();

                if(MessageBox.Show("¿Desea eliminar el registro el cola?","Atención",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MiEmpleado = MiColaEmpleado.Dequeue();

                    TxtIdentificacion.Text = MiEmpleado.Identificacion;
                    TxtNombre.Text = MiEmpleado.Nombre;
                    TxtSalarioAsignado.Text = MiEmpleado.Salaio.ToString();
                    DttFecha.Value = MiEmpleado.Fecha;

                    DtgEmpleadosCola.DataSource = MiColaEmpleado.ToList();
                    MessageBox.Show("Se eliminó el registro en cola", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("La cola esta vacía", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            Limpiar_controles();
            TxtIdentificacion.Focus();
        }
        private void Limpiar_controles()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtSalarioAsignado.Clear();
        }
    }
}
