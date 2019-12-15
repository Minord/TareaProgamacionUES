namespace GestorBancarioUES
{
    partial class BuscarUsuarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBuscarNombre = new System.Windows.Forms.Button();
            this.buttonBuscarID = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(25, 95);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(369, 305);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Location = new System.Drawing.Point(12, 43);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalabra.TabIndex = 1;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(227, 43);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonBuscarNombre
            // 
            this.buttonBuscarNombre.Location = new System.Drawing.Point(118, 43);
            this.buttonBuscarNombre.Name = "buttonBuscarNombre";
            this.buttonBuscarNombre.Size = new System.Drawing.Size(103, 23);
            this.buttonBuscarNombre.TabIndex = 3;
            this.buttonBuscarNombre.Text = "Buscar Nombre";
            this.buttonBuscarNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarNombre.Click += new System.EventHandler(this.ButtonBuscarNombre_Click);
            // 
            // buttonBuscarID
            // 
            this.buttonBuscarID.Location = new System.Drawing.Point(333, 40);
            this.buttonBuscarID.Name = "buttonBuscarID";
            this.buttonBuscarID.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarID.TabIndex = 4;
            this.buttonBuscarID.Text = "Buscar ID";
            this.buttonBuscarID.UseVisualStyleBackColor = true;
            this.buttonBuscarID.Click += new System.EventHandler(this.ButtonBuscarID_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(227, 415);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 5;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(319, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar por nombre o apellido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar por usuario_id";
            // 
            // errorProviderBuscar
            // 
            this.errorProviderBuscar.ContainerControl = this;
            // 
            // BuscarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonBuscarID);
            this.Controls.Add(this.buttonBuscarNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPalabra);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "BuscarUsuarioForm";
            this.Text = "BuscarUsuarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonBuscarNombre;
        private System.Windows.Forms.Button buttonBuscarID;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderBuscar;
    }
}