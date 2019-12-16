namespace GestorBancarioUES
{
    partial class TansaccionForm
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
            this.labelAc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTarjetas = new System.Windows.Forms.ComboBox();
            this.buttonHacer = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.errorProviderTransaccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAc
            // 
            this.labelAc.AutoSize = true;
            this.labelAc.Location = new System.Drawing.Point(120, 9);
            this.labelAc.Name = "labelAc";
            this.labelAc.Size = new System.Drawing.Size(104, 13);
            this.labelAc.TabIndex = 0;
            this.labelAc.Text = "Hacer Transacccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(144, 77);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 2;
            this.textBoxMonto.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxMonto_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccionar Tarjeta";
            // 
            // comboBoxTarjetas
            // 
            this.comboBoxTarjetas.FormattingEnabled = true;
            this.comboBoxTarjetas.Location = new System.Drawing.Point(144, 123);
            this.comboBoxTarjetas.Name = "comboBoxTarjetas";
            this.comboBoxTarjetas.Size = new System.Drawing.Size(99, 21);
            this.comboBoxTarjetas.TabIndex = 4;
            this.comboBoxTarjetas.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxTarjetas_Validating);
            // 
            // buttonHacer
            // 
            this.buttonHacer.Location = new System.Drawing.Point(123, 193);
            this.buttonHacer.Name = "buttonHacer";
            this.buttonHacer.Size = new System.Drawing.Size(112, 23);
            this.buttonHacer.TabIndex = 5;
            this.buttonHacer.Text = "HacerTransaccion";
            this.buttonHacer.UseVisualStyleBackColor = true;
            this.buttonHacer.Click += new System.EventHandler(this.ButtonHacer_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(243, 193);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(91, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // errorProviderTransaccion
            // 
            this.errorProviderTransaccion.ContainerControl = this;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(101, 22);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(22, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "NA";
            // 
            // TansaccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 228);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonHacer);
            this.Controls.Add(this.comboBoxTarjetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAc);
            this.Name = "TansaccionForm";
            this.Text = "TansaccionForm";
            this.Load += new System.EventHandler(this.TansaccionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTarjetas;
        private System.Windows.Forms.Button buttonHacer;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ErrorProvider errorProviderTransaccion;
        private System.Windows.Forms.Label labelNombre;
    }
}