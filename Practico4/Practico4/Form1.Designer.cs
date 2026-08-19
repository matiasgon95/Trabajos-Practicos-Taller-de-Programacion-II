namespace Practico4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.LSaldo = new System.Windows.Forms.Label();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.DTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.LSexo = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PBUser = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.TxtFoto);
            this.panel1.Controls.Add(this.TSaldo);
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
            this.panel1.Controls.Add(this.DTPFechaNacimiento);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LFechaNac);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Font = new System.Drawing.Font("Papyrus", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(118, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 280);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(151, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 49);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TxtFoto
            // 
            this.TxtFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFoto.Location = new System.Drawing.Point(131, 189);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(236, 20);
            this.TxtFoto.TabIndex = 11;
            // 
            // TSaldo
            // 
            this.TSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSaldo.Location = new System.Drawing.Point(131, 158);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(236, 20);
            this.TSaldo.TabIndex = 10;
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.Location = new System.Drawing.Point(29, 150);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(82, 34);
            this.LSaldo.TabIndex = 9;
            this.LSaldo.Text = "Saldo:";
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujer.Location = new System.Drawing.Point(216, 122);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(63, 25);
            this.RBMujer.TabIndex = 8;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Checked = true;
            this.RBHombre.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombre.Location = new System.Drawing.Point(132, 122);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(78, 25);
            this.RBHombre.TabIndex = 7;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // DTPFechaNacimiento
            // 
            this.DTPFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNacimiento.Location = new System.Drawing.Point(258, 87);
            this.DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            this.DTPFechaNacimiento.Size = new System.Drawing.Size(81, 20);
            this.DTPFechaNacimiento.TabIndex = 6;
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(132, 54);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(236, 20);
            this.TBApellido.TabIndex = 5;
            this.TBApellido.Leave += new System.EventHandler(this.TBApellido_Leave);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(132, 24);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(236, 20);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.Leave += new System.EventHandler(this.TBNombre_Leave);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.SystemColors.Control;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFoto.Location = new System.Drawing.Point(35, 187);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Location = new System.Drawing.Point(30, 116);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(74, 34);
            this.LSexo.TabIndex = 3;
            this.LSexo.Text = "Sexo:";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Location = new System.Drawing.Point(30, 82);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(222, 34);
            this.LFechaNac.TabIndex = 2;
            this.LFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(30, 46);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(104, 34);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.ForeColor = System.Drawing.Color.White;
            this.LNombre.Location = new System.Drawing.Point(30, 16);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(96, 34);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PBUser
            // 
            this.PBUser.BackColor = System.Drawing.Color.Transparent;
            this.PBUser.Image = ((System.Drawing.Image)(resources.GetObject("PBUser.Image")));
            this.PBUser.Location = new System.Drawing.Point(521, 12);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(280, 280);
            this.PBUser.TabIndex = 2;
            this.PBUser.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Eliminar,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(38, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Nacimiento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Saldo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Foto";
            this.Column7.Image = ((System.Drawing.Image)(resources.GetObject("Column7.Image")));
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ruta";
            this.Column8.Name = "Column8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PBUser);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker DTPFechaNacimiento;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox PBUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

