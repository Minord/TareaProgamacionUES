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
    public partial class PanelPrincipal : Form
    {

        //Usuario Actual en la ventana
        Usuario usuarioActual;

        //Base de datos
        OleDbConnection conexion = new OleDbConnection(@"Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jose Orellana\Desktop\Tutoria 8\Tutoria 8\Contactos.accdb");



        //Ventanas emergentes



        public PanelPrincipal()
        {
            InitializeComponent();
        }

        public void seleccionarUsuario(int usuario_id) {

        }

        public void actualizarUsuarioActual() {

        }

        public void actualizarPuntos() {

        }

        public void actualizarTarjetas() {

        }

        public void actulizarTansacciones() {

        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            CrearUsuarioForm f2 = new CrearUsuarioForm();
            f2.ShowDialog();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeposito_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRetiro_Click(object sender, EventArgs e)
        {

        }

        private void ButtonApertura_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
 