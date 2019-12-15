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
    public partial class BuscarUsuarioForm : Form
    {

        public int idUsuarioSeleccionado = -1;

        public BuscarUsuarioForm()
        {
            InitializeComponent();
        }

        private void ButtonBuscarNombre_Click(object sender, EventArgs e)
        {
            DataTable dt = Usuario.buscarEnDBPorNombre(textBoxPalabra.Text);

            if (dt == null)
            {
                MessageBox.Show("No se  encontro ningun resultado");
            }
            else
            {
                dataGridViewUsuarios.DataSource = dt;
                dataGridViewUsuarios.Update();
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBuscarID_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Int32.TryParse(textBoxID.Text, out result))
            {
                DataTable dt = Usuario.buscarEnDBPorIdTable(result);

                    if (dt == null)
                    {
                        MessageBox.Show("No se  encontro ningun resultado");
                    }
                    else
                    {
                        dataGridViewUsuarios.DataSource = dt;
                        dataGridViewUsuarios.Update();
                    }
            }
            else
            {
                MessageBox.Show("El ID tiene que ser un numero entero");
            }
        }

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                idUsuarioSeleccionado = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["usuario_id"].Value);
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario en el dataGrid");
            
            }
        }
    }
}
