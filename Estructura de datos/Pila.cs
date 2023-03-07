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
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }
        Stack<Empleado> MiPilaEmpleado = new Stack<Empleado>();//Crear pila a partir de la clase empelado

        private void BtnBack_Click(object sender, EventArgs e)//Metodo para regresar al menu principal
        {
            Menu MiMenu = new Menu();
            MiMenu.Show();
            this.Hide();
        }

        private void OpSalir_Click(object sender, EventArgs e)//metodo para salir de la app
        {
            Inicio MiInicio = new Inicio();
            MiInicio.Show();
            this.Hide();
        }

        private void OpRegistrar_Click(object sender, EventArgs e)//metodo para registrar empleados (agregar empleados a la pila (MiPilaEmpleado)
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

            if (TxtSalarioDia.Text == "")
            {
                EpvError.SetError(TxtSalarioDia, "Debe Ingresar un Salario");
                TxtSalarioDia.Focus();
                return;
            }
            EpvError.SetError(TxtSalarioDia, "");

            decimal salario;

            if (!Decimal.TryParse(TxtSalarioDia.Text, out salario))
            {
                EpvError.SetError(TxtSalarioDia, "Debe ingresar un valor numerico");
                TxtSalarioDia.Focus();
                return;
            }
            EpvError.SetError(TxtSalarioDia, "");

            if (TxtDiasLaborados.Text == "")
            {
                EpvError.SetError(TxtDiasLaborados, "Debe Ingresear un número de días");
                TxtDiasLaborados.Focus();
                return;
            }
            EpvError.SetError(TxtDiasLaborados, "");

            decimal DiasLaborados;

            if (!Decimal.TryParse(TxtDiasLaborados.Text, out salario))
            {
                EpvError.SetError(TxtDiasLaborados, "Debe ingresar un valor numerico");
                TxtDiasLaborados.Focus();
                return;
            }
            EpvError.SetError(TxtDiasLaborados, "");

            Empleado MiEmpleado = new Empleado();

            MiEmpleado.Identificacion = TxtIdentificacion.Text;
            MiEmpleado.Nombre = TxtNombre.Text;
            MiEmpleado.SalarioDia = Decimal.Parse(TxtSalarioDia.Text);
            MiEmpleado.DíasLaborados = Int32.Parse(TxtDiasLaborados.Text);
            TxtDevengado.Text = MiEmpleado.CalcularDevengado(MiEmpleado.SalarioDia, MiEmpleado.DíasLaborados).ToString();

            MiPilaEmpleado.Push(MiEmpleado);
            DtgEmpleados.DataSource = null;
            DtgEmpleados.DataSource = MiPilaEmpleado.ToArray();

            LimpiarControles();
            TxtIdentificacion.Focus();

        }

        private void OpEliminar_Click(object sender, EventArgs e)//Metodo para eliminar
        {
            if(MiPilaEmpleado.Count != 0)
            {
                Empleado MiEmpleado = new Empleado();

                if (MessageBox.Show("¿Desea eiminar el registro en pila?", "Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) {
                    MiEmpleado = MiPilaEmpleado.Pop();
                    TxtIdentificacion.Text = MiEmpleado.Identificacion;
                    TxtNombre.Text = MiEmpleado.Nombre;
                    TxtSalarioDia.Text = MiEmpleado.SalarioDia.ToString();
                    TxtDiasLaborados.Text = MiEmpleado.DíasLaborados.ToString();
                    TxtDevengado.Text = MiEmpleado.Devengado.ToString();

                    DtgEmpleados.DataSource = MiPilaEmpleado.ToArray();

                    MessageBox.Show("Se eliminó el registro que estaba en pila", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay Registros en pila", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarControles();
        }
        private void LimpiarControles()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtSalarioDia.Clear();
            TxtDiasLaborados.Clear();
            TxtDevengado.Clear();
        }
    }
}
