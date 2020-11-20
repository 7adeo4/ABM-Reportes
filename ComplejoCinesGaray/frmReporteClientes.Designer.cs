namespace ComplejoCinesGaray
{
    partial class frmReporteClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new ComplejoCinesGaray.dsClientes();
            this.rbtInicioMembresia = new System.Windows.Forms.RadioButton();
            this.rbtDNI = new System.Windows.Forms.RadioButton();
            this.btnMostrarCondicion = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.rvReporteClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CLIENTESTableAdapter = new ComplejoCinesGaray.dsClientesTableAdapters.CLIENTESTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENTESBindingSource
            // 
            this.CLIENTESBindingSource.DataMember = "CLIENTES";
            this.CLIENTESBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbtInicioMembresia
            // 
            this.rbtInicioMembresia.AutoSize = true;
            this.rbtInicioMembresia.Location = new System.Drawing.Point(219, 418);
            this.rbtInicioMembresia.Name = "rbtInicioMembresia";
            this.rbtInicioMembresia.Size = new System.Drawing.Size(106, 17);
            this.rbtInicioMembresia.TabIndex = 23;
            this.rbtInicioMembresia.TabStop = true;
            this.rbtInicioMembresia.Text = "Inicio Membresía";
            this.rbtInicioMembresia.UseVisualStyleBackColor = true;
            // 
            // rbtDNI
            // 
            this.rbtDNI.AutoSize = true;
            this.rbtDNI.Location = new System.Drawing.Point(169, 418);
            this.rbtDNI.Name = "rbtDNI";
            this.rbtDNI.Size = new System.Drawing.Size(44, 17);
            this.rbtDNI.TabIndex = 22;
            this.rbtDNI.TabStop = true;
            this.rbtDNI.Text = "DNI";
            this.rbtDNI.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCondicion
            // 
            this.btnMostrarCondicion.Location = new System.Drawing.Point(477, 412);
            this.btnMostrarCondicion.Name = "btnMostrarCondicion";
            this.btnMostrarCondicion.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarCondicion.TabIndex = 21;
            this.btnMostrarCondicion.Text = "Mostrar Nombre";
            this.btnMostrarCondicion.UseVisualStyleBackColor = true;
            this.btnMostrarCondicion.Click += new System.EventHandler(this.btnMostrarCondicion_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(410, 414);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(61, 20);
            this.txtFiltro.TabIndex = 20;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(101, 418);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtNombre.TabIndex = 19;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(12, 415);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(85, 23);
            this.btnMostrarTodo.TabIndex = 18;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // rvReporteClientes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CLIENTESBindingSource;
            this.rvReporteClientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporteClientes.LocalReport.ReportEmbeddedResource = "ComplejoCinesGaray.rptClientes.rdlc";
            this.rvReporteClientes.Location = new System.Drawing.Point(3, 12);
            this.rvReporteClientes.Name = "rvReporteClientes";
            this.rvReporteClientes.ServerReport.BearerToken = null;
            this.rvReporteClientes.Size = new System.Drawing.Size(598, 386);
            this.rvReporteClientes.TabIndex = 17;
            this.rvReporteClientes.Load += new System.EventHandler(this.rvReporteClientes_Load);
            // 
            // CLIENTESTableAdapter
            // 
            this.CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Orden por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtInicioMembresia);
            this.Controls.Add(this.rbtDNI);
            this.Controls.Add(this.btnMostrarCondicion);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.rvReporteClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteClientes";
            this.Text = "frmReporteClientes";
            this.Load += new System.EventHandler(this.frmReporteClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtInicioMembresia;
        private System.Windows.Forms.RadioButton rbtDNI;
        private System.Windows.Forms.Button btnMostrarCondicion;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.Button btnMostrarTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporteClientes;
        private System.Windows.Forms.BindingSource CLIENTESBindingSource;
        private dsClientes dsClientes;
        private dsClientesTableAdapters.CLIENTESTableAdapter CLIENTESTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}