using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GestorBancarioUES
{
    public partial class PanelPrincipal : Form
    {

        //Usuario Actual en la ventana
        Usuario usuarioActual;



        public PanelPrincipal()
        {
            InitializeComponent();
        }

        public void seleccionarUsuario(int usuario_id) {

        }

        public void actualizarUsuarioActual() {
            EnableButtons();
            labelNombreCompleto.Text = usuarioActual.nombreCompleto();
            labelEdad.Text = usuarioActual.edad.ToString();
            labelDireccion.Text = usuarioActual.recidencia;
            labelTelefono.Text = usuarioActual.telefono;
            labelEmail.Text = usuarioActual.email;
            actualizarPuntos();
        }

        public void EnableButtons() {
            buttonBorrar.Enabled = true;
            buttonActualizar.Enabled = true;
            buttonApertura.Enabled = true;
            buttonCancelar.Enabled = true;
            buttonDeposito.Enabled = true;
            buttonRetiro.Enabled = true;
        }

        public void actualizarPuntos() {
            //TODO crear implementacion de 
            labelPuntos.Text = "20";
        }

        public void ActualizarTarjetas() {

        }

        public void ActulizarTansacciones() {

        }

        /// <summary>
        /// Crear el formulario CrearUsuario para obtener informacion
        /// del nuevo usuario que va ha ser creado con las validaciones
        /// dentro del nuevo formulario
        /// </summary>
        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            CrearUsuarioForm crearUsuarioForm = new CrearUsuarioForm();
            crearUsuarioForm.ShowDialog();

            if (crearUsuarioForm.GetNuevoUsuario() != null) {
                usuarioActual = crearUsuarioForm.GetNuevoUsuario();
                actualizarUsuarioActual();
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            modificarUsuarioForm mu = new modificarUsuarioForm(usuarioActual);
            mu.ShowDialog();
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
 