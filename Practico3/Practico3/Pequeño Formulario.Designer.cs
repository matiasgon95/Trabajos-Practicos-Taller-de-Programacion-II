namespace Practico2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.Lmodificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBMastercard = new System.Windows.Forms.CheckBox();
            this.CBVisa = new System.Windows.Forms.CheckBox();
            this.CBNaranja = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LTarjetas = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(27, 67);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "*DNI";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(27, 132);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(48, 13);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "*Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(27, 100);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(48, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "*Apellido";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(12, 21);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 3;
            this.LNya.Text = "Nombre y Apellido:";
            // 
            // Lmodificar
            // 
            this.Lmodificar.AutoSize = true;
            this.Lmodificar.ForeColor = System.Drawing.Color.Red;
            this.Lmodificar.Location = new System.Drawing.Point(131, 21);
            this.Lmodificar.Name = "Lmodificar";
            this.Lmodificar.Size = new System.Drawing.Size(49, 13);
            this.Lmodificar.TabIndex = 4;
            this.Lmodificar.Text = "modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(110, 60);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 1;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(110, 125);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 5;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(110, 93);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 3;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(51, 343);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(97, 51);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(158, 343);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(103, 51);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.CBMastercard);
            this.panel1.Controls.Add(this.CBVisa);
            this.panel1.Controls.Add(this.CBNaranja);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LTarjetas);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.Lmodificar);
            this.panel1.Location = new System.Drawing.Point(41, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 279);
            this.panel1.TabIndex = 10;
            // 
            // CBMastercard
            // 
            this.CBMastercard.AutoSize = true;
            this.CBMastercard.Location = new System.Drawing.Point(117, 251);
            this.CBMastercard.Name = "CBMastercard";
            this.CBMastercard.Size = new System.Drawing.Size(79, 17);
            this.CBMastercard.TabIndex = 11;
            this.CBMastercard.Text = "Mastercard";
            this.CBMastercard.UseVisualStyleBackColor = true;
            // 
            // CBVisa
            // 
            this.CBVisa.AutoSize = true;
            this.CBVisa.Location = new System.Drawing.Point(117, 228);
            this.CBVisa.Name = "CBVisa";
            this.CBVisa.Size = new System.Drawing.Size(46, 17);
            this.CBVisa.TabIndex = 10;
            this.CBVisa.Text = "Visa";
            this.CBVisa.UseVisualStyleBackColor = true;
            // 
            // CBNaranja
            // 
            this.CBNaranja.AutoSize = true;
            this.CBNaranja.Location = new System.Drawing.Point(117, 205);
            this.CBNaranja.Name = "CBNaranja";
            this.CBNaranja.Size = new System.Drawing.Size(63, 17);
            this.CBNaranja.TabIndex = 9;
            this.CBNaranja.Text = "Naranja";
            this.CBNaranja.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LTarjetas
            // 
            this.LTarjetas.AutoSize = true;
            this.LTarjetas.Location = new System.Drawing.Point(12, 205);
            this.LTarjetas.Name = "LTarjetas";
            this.LTarjetas.Size = new System.Drawing.Size(98, 13);
            this.LTarjetas.TabIndex = 7;
            this.LTarjetas.Text = "Tarjetas de crédito:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(27, 162);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 6;
            this.LTelefono.Text = "Telefono";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(310, 248);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 11;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varón";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(408, 248);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 12;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Practico2.Properties.Resources.varon;
            this.pbFoto.Location = new System.Drawing.Point(292, 47);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(192, 192);
            this.pbFoto.TabIndex = 13;
            this.pbFoto.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(363, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 50);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nuevo Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label Lmodificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTarjetas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CBNaranja;
        private System.Windows.Forms.CheckBox CBMastercard;
        private System.Windows.Forms.CheckBox CBVisa;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

