namespace ComplejoCinesGaray
{
    partial class UserControlFunciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstFunciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbSubtitulado = new System.Windows.Forms.CheckBox();
            this.chbFeriado = new System.Windows.Forms.CheckBox();
            this.chbDiaPromo = new System.Windows.Forms.CheckBox();
            this.txtCodFuncion = new System.Windows.Forms.TextBox();
            this.cboPeliculas = new System.Windows.Forms.ComboBox();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.dtpHoraFuncion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFuncion = new System.Windows.Forms.DateTimePicker();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLaTetera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFunciones
            // 
            this.lstFunciones.FormattingEnabled = true;
            this.lstFunciones.Location = new System.Drawing.Point(374, 137);
            this.lstFunciones.Name = "lstFunciones";
            this.lstFunciones.Size = new System.Drawing.Size(197, 225);
            this.lstFunciones.TabIndex = 0;
            this.lstFunciones.SelectedIndexChanged += new System.EventHandler(this.lstFunciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo de funcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha funcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sala";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Idioma";
            // 
            // chbSubtitulado
            // 
            this.chbSubtitulado.AutoSize = true;
            this.chbSubtitulado.Location = new System.Drawing.Point(123, 185);
            this.chbSubtitulado.Name = "chbSubtitulado";
            this.chbSubtitulado.Size = new System.Drawing.Size(79, 17);
            this.chbSubtitulado.TabIndex = 1;
            this.chbSubtitulado.Text = "Subtitulado";
            this.chbSubtitulado.UseVisualStyleBackColor = true;
            // 
            // chbFeriado
            // 
            this.chbFeriado.AutoSize = true;
            this.chbFeriado.Location = new System.Drawing.Point(56, 438);
            this.chbFeriado.Name = "chbFeriado";
            this.chbFeriado.Size = new System.Drawing.Size(61, 17);
            this.chbFeriado.TabIndex = 16;
            this.chbFeriado.Text = "Feriado";
            this.chbFeriado.UseVisualStyleBackColor = true;
            // 
            // chbDiaPromo
            // 
            this.chbDiaPromo.AutoSize = true;
            this.chbDiaPromo.Location = new System.Drawing.Point(171, 438);
            this.chbDiaPromo.Name = "chbDiaPromo";
            this.chbDiaPromo.Size = new System.Drawing.Size(74, 17);
            this.chbDiaPromo.TabIndex = 17;
            this.chbDiaPromo.Text = "Dia promo";
            this.chbDiaPromo.UseVisualStyleBackColor = true;
            // 
            // txtCodFuncion
            // 
            this.txtCodFuncion.Location = new System.Drawing.Point(123, 142);
            this.txtCodFuncion.MaxLength = 1;
            this.txtCodFuncion.Name = "txtCodFuncion";
            this.txtCodFuncion.Size = new System.Drawing.Size(147, 20);
            this.txtCodFuncion.TabIndex = 0;
            this.txtCodFuncion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFuncion_KeyPress);
            // 
            // cboPeliculas
            // 
            this.cboPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeliculas.FormattingEnabled = true;
            this.cboPeliculas.Location = new System.Drawing.Point(123, 229);
            this.cboPeliculas.Name = "cboPeliculas";
            this.cboPeliculas.Size = new System.Drawing.Size(147, 21);
            this.cboPeliculas.TabIndex = 2;
            // 
            // cboSala
            // 
            this.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(123, 346);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(92, 21);
            this.cboSala.TabIndex = 5;
            this.cboSala.SelectedIndexChanged += new System.EventHandler(this.cboSala_SelectedIndexChanged);
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(123, 397);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(147, 21);
            this.cboIdioma.TabIndex = 6;
            // 
            // dtpHoraFuncion
            // 
            this.dtpHoraFuncion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFuncion.Location = new System.Drawing.Point(123, 271);
            this.dtpHoraFuncion.Name = "dtpHoraFuncion";
            this.dtpHoraFuncion.ShowUpDown = true;
            this.dtpHoraFuncion.Size = new System.Drawing.Size(147, 20);
            this.dtpHoraFuncion.TabIndex = 3;
            // 
            // dtpFechaFuncion
            // 
            this.dtpFechaFuncion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFuncion.Location = new System.Drawing.Point(123, 306);
            this.dtpFechaFuncion.Name = "dtpFechaFuncion";
            this.dtpFechaFuncion.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaFuncion.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(418, 400);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(101, 23);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(525, 400);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(86, 61);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(314, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(314, 438);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ComplejoCinesGaray.Properties.Resources.darkVader;
            this.pictureBox5.Location = new System.Drawing.Point(486, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ComplejoCinesGaray.Properties.Resources.estrellaDeLaMuerte;
            this.pictureBox4.Location = new System.Drawing.Point(374, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ComplejoCinesGaray.Properties.Resources.nuevetrescuartos;
            this.pictureBox3.Location = new System.Drawing.Point(262, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ComplejoCinesGaray.Properties.Resources.LibroReLoco;
            this.pictureBox2.Location = new System.Drawing.Point(150, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComplejoCinesGaray.Properties.Resources.losLentesDelLocoharry;
            this.pictureBox1.Location = new System.Drawing.Point(38, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lblLaTetera
            // 
            this.lblLaTetera.AutoSize = true;
            this.lblLaTetera.Location = new System.Drawing.Point(221, 349);
            this.lblLaTetera.Name = "lblLaTetera";
            this.lblLaTetera.Size = new System.Drawing.Size(10, 13);
            this.lblLaTetera.TabIndex = 18;
            this.lblLaTetera.Text = "-";
            // 
            // UserControlFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLaTetera);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtpFechaFuncion);
            this.Controls.Add(this.dtpHoraFuncion);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.cboPeliculas);
            this.Controls.Add(this.txtCodFuncion);
            this.Controls.Add(this.chbDiaPromo);
            this.Controls.Add(this.chbFeriado);
            this.Controls.Add(this.chbSubtitulado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstFunciones);
            this.Name = "UserControlFunciones";
            this.Size = new System.Drawing.Size(626, 481);
            this.Load += new System.EventHandler(this.UserControlFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFunciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbSubtitulado;
        private System.Windows.Forms.CheckBox chbFeriado;
        private System.Windows.Forms.CheckBox chbDiaPromo;
        private System.Windows.Forms.TextBox txtCodFuncion;
        private System.Windows.Forms.ComboBox cboPeliculas;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.DateTimePicker dtpHoraFuncion;
        private System.Windows.Forms.DateTimePicker dtpFechaFuncion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblLaTetera;
    }
}
