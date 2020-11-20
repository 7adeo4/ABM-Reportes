namespace ComplejoCinesGaray
{
    partial class frmReporteFunciones
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
            this.vis_reporte_funcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRptFunciones = new ComplejoCinesGaray.dsRptFunciones();
            this.rptviewFunciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbtFecha = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.btnMostrarSala = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.vis_reporte_funcionesTableAdapter = new ComplejoCinesGaray.dsRptFuncionesTableAdapters.vis_reporte_funcionesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chb2D = new System.Windows.Forms.CheckBox();
            this.chk3D = new System.Windows.Forms.CheckBox();
            this.chk4D = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_funcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRptFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // vis_reporte_funcionesBindingSource
            // 
            this.vis_reporte_funcionesBindingSource.DataMember = "vis_reporte_funciones";
            this.vis_reporte_funcionesBindingSource.DataSource = this.dsRptFunciones;
            // 
            // dsRptFunciones
            // 
            this.dsRptFunciones.DataSetName = "dsRptFunciones";
            this.dsRptFunciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptviewFunciones
            // 
            reportDataSource1.Name = "dsRptFunciones";
            reportDataSource1.Value = this.vis_reporte_funcionesBindingSource;
            this.rptviewFunciones.LocalReport.DataSources.Add(reportDataSource1);
            this.rptviewFunciones.LocalReport.ReportEmbeddedResource = "ComplejoCinesGaray.rptFunciones.rdlc";
            this.rptviewFunciones.Location = new System.Drawing.Point(12, 12);
            this.rptviewFunciones.Name = "rptviewFunciones";
            this.rptviewFunciones.ServerReport.BearerToken = null;
            this.rptviewFunciones.Size = new System.Drawing.Size(596, 388);
            this.rptviewFunciones.TabIndex = 0;
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Location = new System.Drawing.Point(161, 419);
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Size = new System.Drawing.Size(55, 17);
            this.rbtFecha.TabIndex = 18;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Fecha";
            this.rbtFecha.UseVisualStyleBackColor = true;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(93, 419);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtNombre.TabIndex = 17;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // btnMostrarSala
            // 
            this.btnMostrarSala.Location = new System.Drawing.Point(515, 416);
            this.btnMostrarSala.Name = "btnMostrarSala";
            this.btnMostrarSala.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarSala.TabIndex = 16;
            this.btnMostrarSala.Text = "Mostrar por sala";
            this.btnMostrarSala.UseVisualStyleBackColor = true;
            this.btnMostrarSala.Click += new System.EventHandler(this.btnMostrarSala_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 417);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // vis_reporte_funcionesTableAdapter
            // 
            this.vis_reporte_funcionesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chb2D
            // 
            this.chb2D.AutoSize = true;
            this.chb2D.Location = new System.Drawing.Point(377, 417);
            this.chb2D.Name = "chb2D";
            this.chb2D.Size = new System.Drawing.Size(40, 17);
            this.chb2D.TabIndex = 21;
            this.chb2D.Text = "2D";
            this.chb2D.UseVisualStyleBackColor = true;
            this.chb2D.CheckedChanged += new System.EventHandler(this.chb2D_CheckedChanged);
            // 
            // chk3D
            // 
            this.chk3D.AutoSize = true;
            this.chk3D.Location = new System.Drawing.Point(423, 417);
            this.chk3D.Name = "chk3D";
            this.chk3D.Size = new System.Drawing.Size(40, 17);
            this.chk3D.TabIndex = 22;
            this.chk3D.Text = "3D";
            this.chk3D.UseVisualStyleBackColor = true;
            this.chk3D.CheckedChanged += new System.EventHandler(this.chk3D_CheckedChanged);
            // 
            // chk4D
            // 
            this.chk4D.AutoSize = true;
            this.chk4D.Location = new System.Drawing.Point(469, 417);
            this.chk4D.Name = "chk4D";
            this.chk4D.Size = new System.Drawing.Size(40, 17);
            this.chk4D.TabIndex = 23;
            this.chk4D.Text = "4D";
            this.chk4D.UseVisualStyleBackColor = true;
            this.chk4D.CheckedChanged += new System.EventHandler(this.chk4D_CheckedChanged);
            // 
            // frmReporteFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 452);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.rbtFecha);
            this.Controls.Add(this.chk4D);
            this.Controls.Add(this.chk3D);
            this.Controls.Add(this.chb2D);
            this.Controls.Add(this.btnMostrarSala);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rptviewFunciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteFunciones";
            this.Text = "frmReporteFunciones";
            this.Load += new System.EventHandler(this.frmReporteFunciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_funcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRptFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptviewFunciones;
        private System.Windows.Forms.RadioButton rbtFecha;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.Button btnMostrarSala;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.BindingSource vis_reporte_funcionesBindingSource;
        private dsRptFunciones dsRptFunciones;
        private dsRptFuncionesTableAdapters.vis_reporte_funcionesTableAdapter vis_reporte_funcionesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chk4D;
        private System.Windows.Forms.CheckBox chk3D;
        private System.Windows.Forms.CheckBox chb2D;
    }
}