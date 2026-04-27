namespace PryFranciaTest
{
    partial class FrmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaProducto));
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbListaProd = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblListaProd = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbdatos = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.opEquipo = new System.Windows.Forms.RadioButton();
            this.opRepuesto = new System.Windows.Forms.RadioButton();
            this.grbAdicional = new System.Windows.Forms.GroupBox();
            this.chbGarantia = new System.Windows.Forms.CheckBox();
            this.chbEnvio = new System.Windows.Forms.CheckBox();
            this.chbInstalacion = new System.Windows.Forms.CheckBox();
            this.cmbPrioducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.grbDatosClientes.SuspendLayout();
            this.grbdatos.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.grbAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.btnSiguiente);
            this.grbDatosClientes.Controls.Add(this.btnRegistrar);
            this.grbDatosClientes.Controls.Add(this.cmbListaProd);
            this.grbDatosClientes.Controls.Add(this.txtNombre);
            this.grbDatosClientes.Controls.Add(this.lblListaProd);
            this.grbDatosClientes.Controls.Add(this.lblNombre);
            this.grbDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosClientes.Location = new System.Drawing.Point(12, 12);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Size = new System.Drawing.Size(390, 150);
            this.grbDatosClientes.TabIndex = 6;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "DatosCliente";
            this.grbDatosClientes.Enter += new System.EventHandler(this.grbDatosClientes_Enter);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(290, 121);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 23);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(290, 40);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 28);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbListaProd
            // 
            this.cmbListaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaProd.FormattingEnabled = true;
            this.cmbListaProd.Location = new System.Drawing.Point(128, 89);
            this.cmbListaProd.Name = "cmbListaProd";
            this.cmbListaProd.Size = new System.Drawing.Size(140, 23);
            this.cmbListaProd.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 21);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblListaProd
            // 
            this.lblListaProd.AutoSize = true;
            this.lblListaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProd.Location = new System.Drawing.Point(11, 94);
            this.lblListaProd.Name = "lblListaProd";
            this.lblListaProd.Size = new System.Drawing.Size(92, 16);
            this.lblListaProd.TabIndex = 7;
            this.lblListaProd.Text = "Lista Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // grbdatos
            // 
            this.grbdatos.Controls.Add(this.btnFinalizar);
            this.grbdatos.Controls.Add(this.grbTipo);
            this.grbdatos.Controls.Add(this.grbAdicional);
            this.grbdatos.Controls.Add(this.cmbPrioducto);
            this.grbdatos.Controls.Add(this.lblProducto);
            this.grbdatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdatos.Location = new System.Drawing.Point(12, 12);
            this.grbdatos.Name = "grbdatos";
            this.grbdatos.Size = new System.Drawing.Size(390, 259);
            this.grbdatos.TabIndex = 12;
            this.grbdatos.TabStop = false;
            this.grbdatos.Text = "Datos";
            this.grbdatos.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(276, 218);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(108, 31);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.opEquipo);
            this.grbTipo.Controls.Add(this.opRepuesto);
            this.grbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipo.Location = new System.Drawing.Point(6, 55);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(361, 49);
            this.grbTipo.TabIndex = 6;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            // 
            // opEquipo
            // 
            this.opEquipo.AutoSize = true;
            this.opEquipo.Location = new System.Drawing.Point(204, 20);
            this.opEquipo.Name = "opEquipo";
            this.opEquipo.Size = new System.Drawing.Size(64, 19);
            this.opEquipo.TabIndex = 7;
            this.opEquipo.TabStop = true;
            this.opEquipo.Text = "Equipo";
            this.opEquipo.UseVisualStyleBackColor = true;
            // 
            // opRepuesto
            // 
            this.opRepuesto.AutoSize = true;
            this.opRepuesto.Location = new System.Drawing.Point(55, 20);
            this.opRepuesto.Name = "opRepuesto";
            this.opRepuesto.Size = new System.Drawing.Size(78, 19);
            this.opRepuesto.TabIndex = 6;
            this.opRepuesto.TabStop = true;
            this.opRepuesto.Text = "Repuesto";
            this.opRepuesto.UseVisualStyleBackColor = true;
            // 
            // grbAdicional
            // 
            this.grbAdicional.Controls.Add(this.chbGarantia);
            this.grbAdicional.Controls.Add(this.chbEnvio);
            this.grbAdicional.Controls.Add(this.chbInstalacion);
            this.grbAdicional.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbAdicional.Location = new System.Drawing.Point(6, 121);
            this.grbAdicional.Name = "grbAdicional";
            this.grbAdicional.Size = new System.Drawing.Size(361, 91);
            this.grbAdicional.TabIndex = 5;
            this.grbAdicional.TabStop = false;
            this.grbAdicional.Text = "Adicional";
            // 
            // chbGarantia
            // 
            this.chbGarantia.AutoSize = true;
            this.chbGarantia.Location = new System.Drawing.Point(230, 41);
            this.chbGarantia.Name = "chbGarantia";
            this.chbGarantia.Size = new System.Drawing.Size(73, 19);
            this.chbGarantia.TabIndex = 13;
            this.chbGarantia.Text = "Garantia";
            this.chbGarantia.UseVisualStyleBackColor = true;
            // 
            // chbEnvio
            // 
            this.chbEnvio.AutoSize = true;
            this.chbEnvio.Location = new System.Drawing.Point(136, 41);
            this.chbEnvio.Name = "chbEnvio";
            this.chbEnvio.Size = new System.Drawing.Size(56, 19);
            this.chbEnvio.TabIndex = 12;
            this.chbEnvio.Text = "Envío";
            this.chbEnvio.UseVisualStyleBackColor = true;
            // 
            // chbInstalacion
            // 
            this.chbInstalacion.AutoSize = true;
            this.chbInstalacion.Location = new System.Drawing.Point(31, 41);
            this.chbInstalacion.Name = "chbInstalacion";
            this.chbInstalacion.Size = new System.Drawing.Size(85, 19);
            this.chbInstalacion.TabIndex = 11;
            this.chbInstalacion.Text = "Instalación";
            this.chbInstalacion.UseVisualStyleBackColor = true;
            this.chbInstalacion.CheckedChanged += new System.EventHandler(this.chbInstalacion_CheckedChanged);
            // 
            // cmbPrioducto
            // 
            this.cmbPrioducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioducto.FormattingEnabled = true;
            this.cmbPrioducto.Location = new System.Drawing.Point(108, 19);
            this.cmbPrioducto.Name = "cmbPrioducto";
            this.cmbPrioducto.Size = new System.Drawing.Size(174, 23);
            this.cmbPrioducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(11, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(68, 16);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Productos";
            // 
            // FrmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(423, 303);
            this.Controls.Add(this.grbdatos);
            this.Controls.Add(this.grbDatosClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Datos";
            this.Load += new System.EventHandler(this.FrmCargaProducto_Load);
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.grbdatos.ResumeLayout(false);
            this.grbdatos.PerformLayout();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbAdicional.ResumeLayout(false);
            this.grbAdicional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbListaProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblListaProd;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbdatos;
        private System.Windows.Forms.GroupBox grbAdicional;
        private System.Windows.Forms.CheckBox chbGarantia;
        private System.Windows.Forms.CheckBox chbEnvio;
        private System.Windows.Forms.CheckBox chbInstalacion;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.RadioButton opEquipo;
        private System.Windows.Forms.RadioButton opRepuesto;
        private System.Windows.Forms.ComboBox cmbPrioducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnFinalizar;
    }
}