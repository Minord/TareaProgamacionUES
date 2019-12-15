namespace GestorBancarioUES
{
    partial class AperturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.textBoxNCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.buttonCrearTarjeta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProviderApertura = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApertura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apertura de tarjeta para el usuario";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(25, 51);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(22, 13);
            this.labelNombreUsuario.TabIndex = 1;
            this.labelNombreUsuario.Text = "NA";
            // 
            // textBoxNCuenta
            // 
            this.textBoxNCuenta.Location = new System.Drawing.Point(28, 103);
            this.textBoxNCuenta.Name = "textBoxNCuenta";
            this.textBoxNCuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNCuenta.TabIndex = 2;
            this.textBoxNCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNCuenta_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de Cuenta";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.comboBoxTipo.Location = new System.Drawing.Point(28, 170);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipo.TabIndex = 4;
            this.comboBoxTipo.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxTipo_Validating);
            // 
            // buttonCrearTarjeta
            // 
            this.buttonCrearTarjeta.Location = new System.Drawing.Point(88, 261);
            this.buttonCrearTarjeta.Name = "buttonCrearTarjeta";
            this.buttonCrearTarjeta.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearTarjeta.TabIndex = 5;
            this.buttonCrearTarjeta.Text = "Crear";
            this.buttonCrearTarjeta.UseVisualStyleBackColor = true;
            this.buttonCrearTarjeta.Click += new System.EventHandler(this.ButtonCrearTarjeta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // errorProviderApertura
            // 
            this.errorProviderApertura.ContainerControl = this;
            // 
            // AperturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCrearTarjeta);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNCuenta);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "AperturaForm";
            this.Text = "AperturaForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textBoxNCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button buttonCrearTarjeta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProviderApertura;
    }
}