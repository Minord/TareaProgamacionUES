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
    public partial class TansaccionForm : Form
    {
        Usuario usuario;
        string tipo;
        public TansaccionForm(Usuario usuario, string tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
            this.usuario = usuario;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonHacer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                agregarPuntos(float.Parse(textBoxMonto.Text));
                if (tipo == "abono")
                {
                    Abono a = new Abono(Convert.ToInt32(comboBoxTarjetas.SelectedItem.ToString()), float.Parse(textBoxMonto.Text));
                    int id = a.registrarAbono();
                    MessageBox.Show("Se ha insertado un abono con el id de " + id);
                }
                else if(tipo == "retiro") {
                    Retiro r = new Retiro(Convert.ToInt32(comboBoxTarjetas.SelectedItem.ToString()), float.Parse(textBoxMonto.Text));
                    int id = r.registrarRetiro();
                    MessageBox.Show("Se ha insertado un retiro con el id de " + id);
                }
                Close();
            }
        }

        private void TextBoxMonto_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (!float.TryParse(textBoxMonto.Text, out result))
            {
                e.Cancel = true;
                textBoxMonto.Focus();
                errorProviderTransaccion.SetError(textBoxMonto, "Tiene que ser un numero de punto flotante");
            }
            else {
                e.Cancel = false;
                errorProviderTransaccion.SetError(textBoxMonto, "");
            }
        }

        private void ComboBoxTarjetas_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxTarjetas.SelectedItem != null)
            {
                e.Cancel = false;
                errorProviderTransaccion.SetError(comboBoxTarjetas, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderTransaccion.SetError(comboBoxTarjetas, "Tiene que seleccionar la tarjeta ha usar");

            }
        }

        private void TansaccionForm_Load(object sender, EventArgs e)
        {
            if (tipo == "abono")
            {
                labelAc.Text = "Hacer Abono";
                buttonHacer.Text = "Abonar";
            }
            else if (tipo == "retiro")
            {
                labelAc.Text = "Hacer Retiro";
                buttonHacer.Text = "Retirar";
            }
            labelNombre.Text = usuario.nombreCompleto();
            setTarjetasEnComboBox();
        }

        private void setTarjetasEnComboBox() {
            string command = string.Format("SELECT tarjeta_id FROM Tarjetas WHERE usuario_id = {0}", usuario.usuario_id);
            DataTable dt = DataBase.SelectCommand(command);

            foreach (DataRow dr in dt.Rows) {
                comboBoxTarjetas.Items.Add(dr[0].ToString());

            }

        }

        private void agregarPuntos(float monto) {
            int puntos = 5;
            if (monto >= 500)
            {
                puntos = 20;
            }

            string sql_command = string.Format("INSERT INTO Puntos (usuario_id, cantidad, fecha_hora) VALUES ({0},{1},#{2}#)", usuario.usuario_id, puntos, DateTime.Now.ToString());

            DataBase.IUDCommand(sql_command);
        }
    }
}
