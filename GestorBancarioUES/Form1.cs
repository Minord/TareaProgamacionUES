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

        public void actualizarUsuarioActual() {
            if (usuarioActual != null)
            {
                SetButtons(true);
                labelNombreCompleto.Text = usuarioActual.nombreCompleto();
                labelEdad.Text = usuarioActual.edad.ToString();
                labelDireccion.Text = usuarioActual.recidencia;
                labelTelefono.Text = usuarioActual.telefono;
                labelEmail.Text = usuarioActual.email;
                actualizarPuntos();
                ActualizarTarjetas();
                actualizarBalance();
            }
            else
            {
                SetButtons(false);
                labelNombreCompleto.Text = "NA";
                labelEdad.Text = "NA";
                labelDireccion.Text = "NA";
                labelTelefono.Text = "NA";
                labelEmail.Text = "NA";
                labelPuntos.Text = "NA";
                labelBalance.Text = "NA";
                dataGridViewTarjetas.DataSource = null;
                dataGridViewTarjetas.Update();
                dataGridViewTransacciones.DataSource = null;
                dataGridViewTransacciones.Update();
            }
        }

        public void SetButtons(bool value) {
            buttonBorrar.Enabled = value;
            buttonActualizar.Enabled = value;
            buttonApertura.Enabled = value;
            buttonCancelar.Enabled = value;
            buttonDeposito.Enabled = value;
            buttonRetiro.Enabled = value;
        }

        public void actualizarPuntos() {
            labelPuntos.Text = usuarioActual.getPuntos().ToString();
        }

        public void actualizarBalance() {
            labelBalance.Text = Transaccion.getBanlancePorUsuarioID(usuarioActual.usuario_id).ToString("C");
        }

        public void ActualizarTarjetas() {
            DataTable dt = Tarjeta.getTargetasTablePorUsuarioID(usuarioActual.usuario_id);

            if (dt == null)
            {
                //MessageBox.Show("No se  encontro ningun resultado");
            }
            else
            {
                dataGridViewTarjetas.DataSource = dt;
                dataGridViewTarjetas.Update();
            }
            ActualizarTansacciones();
        }

        public void ActualizarTansacciones() {
            DataTable dt = Transaccion.getTransaccionesTablePorUsuarioID(usuarioActual.usuario_id);

            if (dt == null)
            {
                //MessageBox.Show("No se  encontro ningun resultado");
            }
            else
            {
                dataGridViewTransacciones.DataSource = dt;
                dataGridViewTransacciones.Update();
            }
            actualizarBalance();
            actualizarPuntos();
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
                int id = usuarioActual.registrarEnDB();
                actualizarUsuarioActual();
                MessageBox.Show(string.Format("Nuevo usuario ha sido registrado con el ID de {0}", id));
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarioForm bf = new BuscarUsuarioForm();
            bf.ShowDialog();
            if (bf.idUsuarioSeleccionado != -1) {
                usuarioActual = Usuario.buscarEnDBPorId(bf.idUsuarioSeleccionado);
                actualizarUsuarioActual();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            modificarUsuarioForm mu = new modificarUsuarioForm(usuarioActual);
            mu.ShowDialog();
            usuarioActual = Usuario.buscarEnDBPorId(usuarioActual.usuario_id);
            actualizarUsuarioActual();
            MessageBox.Show(string.Format("El usuario con el id {0} ha sido actualizado", usuarioActual.usuario_id));

        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            DataBase.IUDCommand(string.Format("DELETE FROM Usuarios WHERE usuario_id = {0}", usuarioActual.usuario_id));
            MessageBox.Show(string.Format("Se ha borrado el usuario con el ID de {0}", usuarioActual.usuario_id));
            usuarioActual = null;

            actualizarUsuarioActual();
        }

        private void ButtonDeposito_Click(object sender, EventArgs e)
        {
            TansaccionForm tf = new TansaccionForm(usuarioActual, "abono");
            tf.ShowDialog();
            ActualizarTansacciones();

        }

        private void ButtonRetiro_Click(object sender, EventArgs e)
        {
            TansaccionForm tf = new TansaccionForm(usuarioActual, "retiro");
            tf.ShowDialog();
            ActualizarTansacciones();

        }

        private void ButtonApertura_Click(object sender, EventArgs e)
        {
            AperturaForm af = new AperturaForm(usuarioActual);
            af.ShowDialog();
            ActualizarTarjetas();

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarjetas.SelectedRows.Count > 0)
            {
                int tarjeta_id = Convert.ToInt32(dataGridViewTarjetas.SelectedRows[0].Cells["tarjeta_id"].Value);
                Tarjeta.borrarTarjetaPorID(tarjeta_id);
                MessageBox.Show(string.Format("Se ha cancelado la tarjeta con el ID de {0}", tarjeta_id));
                ActualizarTarjetas();
            }
            else
            {
                MessageBox.Show("Seleccione una tarjeta en el dataGrid");
                ActualizarTarjetas();
            }
        }
    }
}
 