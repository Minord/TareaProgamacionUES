using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestorBancarioUES
{

    public partial class CrearUsuarioForm : Form
    {
        //el objeto usuario que sera retornado de este formulario
        private Usuario nuevoUsuario;

        //
        public Usuario GetNuevoUsuario(){
            return nuevoUsuario;
        }


        public CrearUsuarioForm()
        {
            InitializeComponent();
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCrearUsuario_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                //crear nuevo usuario
                string nombres = textBoxNombre.Text;
                string apellidos = textBoxApellidos.Text;
                int edad = Int32.Parse(textBoxEdad.Text);
                string recidencia = textBoxRecidencia.Text;
                string telefono = textBoxTelefono.Text;
                string email = textBoxEmail.Text;

                nuevoUsuario = new Usuario(nombres, apellidos, edad, recidencia, telefono, email, -1);
                Close();
            }
        }

        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                e.Cancel = true;
                textBoxNombre.Focus();
                errorProviderCrearUsuario.SetError(textBoxNombre, "No puede ser espacios en blanco");
            }
            else if (float.TryParse(textBoxNombre.Text, out result))
            {
                e.Cancel = true;
                textBoxNombre.Focus();
                errorProviderCrearUsuario.SetError(textBoxNombre, "No puede ser un numero");
            }
            else {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxNombre, "");
            }
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxEmail.Text, @"^\w*@\w*\.\w*$")) {
                e.Cancel = true;
                textBoxEmail.Focus();
                errorProviderCrearUsuario.SetError(textBoxEmail, "El formato tiene que ser emailname@mail.com");
            } else {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxEmail, "");
            }
        }

        private void TextBoxApellidos_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                e.Cancel = true;
                textBoxApellidos.Focus();
                errorProviderCrearUsuario.SetError(textBoxApellidos, "No puede ser espacios en blanco");
            }
            else if (float.TryParse(textBoxApellidos.Text, out result))
            {
                e.Cancel = true;
                textBoxApellidos.Focus();
                errorProviderCrearUsuario.SetError(textBoxApellidos, "No Puede ser un numero");
            }
            else
            {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxApellidos, "");
            }
        }

        private void TextBoxEdad_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if (!Int32.TryParse(textBoxEdad.Text, out result))
            {
                e.Cancel = true;
                textBoxEdad.Focus();
                errorProviderCrearUsuario.SetError(textBoxEdad, "La edad tiene que ser un numero entero");
            }
            else {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxEdad, "");
            }
        }

        private void TextBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxTelefono.Text, @"^\d{4}-\d{4}$")) {
                e.Cancel = true;
                textBoxTelefono.Focus();
                errorProviderCrearUsuario.SetError(textBoxTelefono, "El campo tiene que seguir el formato de 0000-0000");
            } else {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxTelefono, "");
            }
        }

        private void TextBoxRecidencia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRecidencia.Text)) {
                e.Cancel = true;
                textBoxRecidencia.Focus();
                errorProviderCrearUsuario.SetError(textBoxRecidencia, "Este campo no puede estar vacio");
            }
            else {
                e.Cancel = false;
                errorProviderCrearUsuario.SetError(textBoxRecidencia, "");
            }
        }
    }
}
