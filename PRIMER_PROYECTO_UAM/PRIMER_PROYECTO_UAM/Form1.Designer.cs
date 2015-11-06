namespace PRIMER_PROYECTO_UAM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.cmbprovincia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbuscarfoto = new System.Windows.Forms.Button();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.txtexaminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(18, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Direción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Provincia";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(86, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(86, 53);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(121, 20);
            this.txtapellido.TabIndex = 7;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(86, 89);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(121, 20);
            this.txtcedula.TabIndex = 8;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(86, 125);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(121, 20);
            this.txtedad.TabIndex = 9;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(86, 166);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(121, 20);
            this.txtdireccion.TabIndex = 10;
            // 
            // cmbprovincia
            // 
            this.cmbprovincia.FormattingEnabled = true;
            this.cmbprovincia.Location = new System.Drawing.Point(86, 191);
            this.cmbprovincia.Name = "cmbprovincia";
            this.cmbprovincia.Size = new System.Drawing.Size(121, 21);
            this.cmbprovincia.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbuscarfoto
            // 
            this.btnbuscarfoto.Location = new System.Drawing.Point(345, 13);
            this.btnbuscarfoto.Name = "btnbuscarfoto";
            this.btnbuscarfoto.Size = new System.Drawing.Size(53, 19);
            this.btnbuscarfoto.TabIndex = 13;
            this.btnbuscarfoto.Text = "....";
            this.btnbuscarfoto.UseVisualStyleBackColor = true;
            this.btnbuscarfoto.Click += new System.EventHandler(this.btnbuscarfoto_Click);
            // 
            // picfoto
            // 
            this.picfoto.Location = new System.Drawing.Point(298, 38);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(100, 125);
            this.picfoto.TabIndex = 14;
            this.picfoto.TabStop = false;
            // 
            // txtexaminar
            // 
            this.txtexaminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtexaminar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtexaminar.Location = new System.Drawing.Point(388, 181);
            this.txtexaminar.Name = "txtexaminar";
            this.txtexaminar.Size = new System.Drawing.Size(10, 20);
            this.txtexaminar.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 370);
            this.Controls.Add(this.txtexaminar);
            this.Controls.Add(this.picfoto);
            this.Controls.Add(this.btnbuscarfoto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbprovincia);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox cmbprovincia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbuscarfoto;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.TextBox txtexaminar;
    }
}

