using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBancarioUES
{
    public partial class AperturaForm : Form
    {
        public bool EntradasValidas = false;
        Usuario usuario;
        public AperturaForm(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            labelNombreUsuario.Text = usuario.nombreCompleto();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCrearTarjeta_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                Tarjeta nuevaTarjeta = new Tarjeta(usuario.usuario_id, Convert.ToInt32(textBoxNCuenta.Text), comboBoxTipo.SelectedItem.ToString(), -1);
                nuevaTarjeta.registarTarjeta();
                Close();
            }
        }

        private void ComboBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxTipo.SelectedItem != null)
            {
                e.Cancel = false;
                errorProviderApertura.SetError(comboBoxTipo, "");
            }
            else {
                e.Cancel = true;
                errorProviderApertura.SetError(comboBoxTipo, "Tiene que seleccionar el tipo de tarjeta ha usar");

            }
        }

        private void TextBoxNCuenta_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if (!Int32.TryParse(textBoxNCuenta.Text, out result))
            {
                e.Cancel = true;
                textBoxNCuenta.Focus();
                errorProviderApertura.SetError(textBoxNCuenta, "el Numero de Cuenta tiene que ser un numero");
            }
            else
            {
                e.Cancel = false;
                errorProviderApertura.SetError(textBoxNCuenta, "");
            }
        }
    }
}
