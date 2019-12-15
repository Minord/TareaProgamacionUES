using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace GestorBancarioUES
{
    public partial class modificarUsuarioForm : Form
    {
        Usuario usuarioModificado;
        public modificarUsuarioForm(Usuario usuarioAModificar)
        {
            InitializeComponent();
            textBoxNombre.Text = usuarioAModificar.nombres;
            textBoxApellidos.Text = usuarioAModificar.apellidos;
            textBoxEdad.Text = usuarioAModificar.edad.ToString();
            textBoxRecidencia.Text = usuarioAModificar.recidencia;
            textBoxTelefono.Text = usuarioAModificar.telefono;
            textBoxEmail.Text = usuarioAModificar.email;
        }

        private void ButtonModificarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Close();
            }
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                e.Cancel = true;
                textBoxNombre.Focus();
                errorProviderModificarUsuario.SetError(textBoxNombre, "No puede ser espacios en blanco");
            }
            else if (float.TryParse(textBoxNombre.Text, out result))
            {
                e.Cancel = true;
                textBoxNombre.Focus();
                errorProviderModificarUsuario.SetError(textBoxNombre, "No puede ser un numero");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxNombre, "");
            }
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxEmail.Text, @"^\w*@\w*\.\w*$"))
            {
                e.Cancel = true;
                textBoxEmail.Focus();
                errorProviderModificarUsuario.SetError(textBoxEmail, "El formato tiene que ser emailname@mail.com");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxEmail, "");
            }
        }

        private void TextBoxApellidos_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                e.Cancel = true;
                textBoxApellidos.Focus();
                errorProviderModificarUsuario.SetError(textBoxApellidos, "No puede ser espacios en blanco");
            }
            else if (float.TryParse(textBoxApellidos.Text, out result))
            {
                e.Cancel = true;
                textBoxApellidos.Focus();
                errorProviderModificarUsuario.SetError(textBoxApellidos, "No Puede ser un numero");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxApellidos, "");
            }
        }

        private void TextBoxEdad_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if (!Int32.TryParse(textBoxEdad.Text, out result))
            {
                e.Cancel = true;
                textBoxEdad.Focus();
                errorProviderModificarUsuario.SetError(textBoxEdad, "La edad tiene que ser un numero entero");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxEdad, "");
            }
        }

        private void TextBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBoxTelefono.Text, @"^\d{4}-\d{4}$"))
            {
                e.Cancel = true;
                textBoxTelefono.Focus();
                errorProviderModificarUsuario.SetError(textBoxTelefono, "El campo tiene que seguir el formato de 0000-0000");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxTelefono, "");
            }
        }

        private void TextBoxRecidencia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRecidencia.Text))
            {
                e.Cancel = true;
                textBoxRecidencia.Focus();
                errorProviderModificarUsuario.SetError(textBoxRecidencia, "Este campo no puede estar vacio");
            }
            else
            {
                e.Cancel = false;
                errorProviderModificarUsuario.SetError(textBoxRecidencia, "");
            }
        }

        
    }
}
