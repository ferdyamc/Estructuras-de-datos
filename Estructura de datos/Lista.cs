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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            TlsConsultar.Enabled = false;
            TlsEliminar.Enabled = false;
        }
        //Boton volve al menú
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Menu MiMenu = new Menu();
            MiMenu.Show();
            this.Hide();
        }

        List<ClsLIsta> MiListaMascotas = new List<ClsLIsta>(); //Crear lista del tipo de la clase ClsLista

        //Boton registrar
        private void TlsRegistrar_Click(object sender, EventArgs e)
        {
            

            if(ValidarNombre() == false) //llamar a los metodos para validar controles
            {
                return;
            }
            if(ValidarRaza() == false)
            {
                return;
            }
            if(ValidarEdad() == false)
            {
                return;
            }
            if(Existe(TxtNombre.Text))
            {
                EpvError.SetError(TxtNombre, "La mascota con ese nombre ya esta registrada");
                LimpiarControles();
                TxtNombre.Focus();
                return;
            }
            EpvError.SetError(TxtNombre, "");

            ClsLIsta MiLista = new ClsLIsta(); //Crear objeto del tipo ClsLista

            MiLista.Nombre = TxtNombre.Text; //Dar valor a las propiedades de la clase a partir de los valor ingresados en los controles del formulario
            MiLista.Raza = CmbRaza.SelectedItem.ToString();
            MiLista.Edad = int.Parse(TxtEdad.Text);

            MiListaMascotas.Add(MiLista); //Agregar objeto a la lista  MiListaMascotas

            DtgLista.DataSource = null; //Resetear Datagrid
            DtgLista.DataSource = MiListaMascotas; //Actualizat datagrid con los objetos de la lista

            LimpiarControles();//Llamar al metodo para limpiar controles

            TlsConsultar.Enabled = true;
        }
        //Metodo para validar que no se ingrese mascota con el mismo nombre
        private bool Existe(string Nombre)
        {
            foreach (ClsLIsta MiLista in MiListaMascotas)
            {
                if(MiLista.Nombre == Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        //Metodo para limpiar controles
        private void LimpiarControles()
        {
            TxtNombre.Clear();
            CmbRaza.SelectedIndex = 0;
            TxtEdad.Clear();
            TxtNombre.Focus();
        }
        //Metodo para validar edad
        private bool ValidarEdad()
        {
            int Edad;
            if (!int.TryParse(TxtEdad.Text, out Edad) || TxtEdad.Text =="" ){//si la edad es diferente de tipo entero o esta vacia (en el controles del formulario)
                EpvError.SetError(TxtEdad, "Debe ingresar un valor numerico para la edad");
                TxtEdad.Clear();
                TxtEdad.Focus();
                return false;
            }
            else
            {
                EpvError.SetError(TxtEdad, "") ;
                return true;
            }
        }
        //Metodo para validar raza
        private bool ValidarRaza()
        {
            if (string.IsNullOrEmpty(CmbRaza.Text))//Si no se selecciona un item en el control Raza
            {
                EpvError.SetError(CmbRaza, "Debe seleccionar alguna Raza");
                return false;
            }
            else
            {
                EpvError.SetError(CmbRaza, "");
                return true;
            }
        }

        //Metodo para validar nombre
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))//Si no se ha ingresao un valor en el control Nombre
            {
                EpvError.SetError(TxtNombre, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                EpvError.SetError(TxtNombre, "");
                return true;
            }
        }
        //Boton salir
        private void TlsSalir_Click(object sender, EventArgs e)
        {
            Inicio MiInicio = new Inicio();
            MiInicio.Show();
            this.Hide();
        }
        //Boton Consultar
        private void TlsConsultar_Click(object sender, EventArgs e)
        {
            if(ValidarNombre() == false)
            {
                return;
            }
            ClsLIsta MiLista = GetMascota(TxtNombre.Text);
            if(MiLista == null)
            {
                EpvError.SetError(TxtNombre, "La mascota no se encuentra registrada en la lista");
                LimpiarControles();
                return;
            }
            else
            {
                EpvError.SetError(TxtNombre, "");
                TxtNombre.Text = MiLista.Nombre;
                CmbRaza.Text = MiLista.Raza;
                TxtEdad.Text = MiLista.Edad.ToString();
                TlsEliminar.Enabled = true;
            }
        }

        //Metodo para obtener o consultar mascota
        private ClsLIsta GetMascota(string nombre)
        {
            return MiListaMascotas.Find(mascota => mascota.Nombre.Contains(nombre));
        }

        private void TlsEliminar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                EpvError.SetError(TxtNombre, "Debe consultar la mascota a eliminar");
                LimpiarControles();
                TlsEliminar.Enabled = false;
                return;
            }
            else
            {
                EpvError.SetError(TxtNombre, "");
                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de eliminar el registro?","Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if(Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLIsta MiLista in MiListaMascotas)
                    {
                        if(MiLista.Nombre == TxtNombre.Text)
                        {
                            MiListaMascotas.Remove(MiLista);
                            break;
                        }
                    }
                    LimpiarControles();
                    DtgLista.DataSource = null;
                    DtgLista.DataSource = MiListaMascotas;
                }
            }
        }
    }
}
