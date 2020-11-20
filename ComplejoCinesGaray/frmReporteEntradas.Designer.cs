namespace ComplejoCinesGaray
{
    partial class frmReporteEntradas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vis_reporte_entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReportEntradas = new ComplejoCinesGaray.dsReportEntradas();
            this.rptEntradasview = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vis_reporte_entradasTableAdapter = new ComplejoCinesGaray.dsReportEntradasTableAdapters.vis_reporte_entradasTableAdapter();
            this.rbtFecha = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cboTipoEspectador = new System.Windows.Forms.ComboBox();
            this.btnMostrarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // vis_reporte_entradasBindingSource
            // 
            this.vis_reporte_entradasBindingSource.DataMember = "vis_reporte_entradas";
            this.vis_reporte_entradasBindingSource.DataSource = this.dsReportEntradas;
            // 
            // dsReportEntradas
            // 
            this.dsReportEntradas.DataSetName = "dsReportEntradas";
            this.dsReportEntradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptEntradasview
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vis_reporte_entradasBindingSource;
            this.rptEntradasview.LocalReport.DataSources.Add(reportDataSource2);
            this.rptEntradasview.LocalReport.ReportEmbeddedResource = "ComplejoCinesGaray.rptEntradas.rdlc";
            this.rptEntradasview.Location = new System.Drawing.Point(12, 12);
            this.rptEntradasview.Name = "rptEntradasview";
            this.rptEntradasview.ServerReport.BearerToken = null;
            this.rptEntradasview.Size = new System.Drawing.Size(596, 396);
            this.rptEntradasview.TabIndex = 0;
            // 
            // vis_reporte_entradasTableAdapter
            // 
            this.vis_reporte_entradasTableAdapter.ClearBeforeFill = true;
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Location = new System.Drawing.Point(93, 420);
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Size = new System.Drawing.Size(108, 17);
            this.rbtFecha.TabIndex = 13;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Fecha de función";
            this.rbtFecha.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 417);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cboTipoEspectador
            // 
            this.cboTipoEspectador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEspectador.FormattingEnabled = true;
            this.cboTipoEspectador.Items.AddRange(new object[] {
            "JUBILADO",
            "ADULTO",
            "INFANTE"});
            this.cboTipoEspectador.Location = new System.Drawing.Point(300, 420);
            this.cboTipoEspectador.Name = "cboTipoEspectador";
            this.cboTipoEspectador.Size = new System.Drawing.Size(141, 21);
            this.cboTipoEspectador.TabIndex = 16;
            // 
            // btnMostrarFiltro
            // 
            this.btnMostrarFiltro.Location = new System.Drawing.Point(447, 418);
            this.btnMostrarFiltro.Name = "btnMostrarFiltro";
            this.btnMostrarFiltro.Size = new System.Drawing.Size(159, 23);
            this.btnMostrarFiltro.TabIndex = 15;
            this.btnMostrarFiltro.Text = "Mostrar por tipo de espectador";
            this.btnMostrarFiltro.UseVisualStyleBackColor = true;
            this.btnMostrarFiltro.Click += new System.EventHandler(this.btnMostrarFiltro_Click);
            // 
            // frmReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 452);
            this.Controls.Add(this.cboTipoEspectador);
            this.Controls.Add(this.btnMostrarFiltro);
            this.Controls.Add(this.rbtFecha);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rptEntradasview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteEntradas";
            this.Text = "frmReporteEntradas";
            this.Load += new System.EventHandler(this.frmReporteEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptEntradasview;
        private System.Windows.Forms.BindingSource vis_reporte_entradasBindingSource;
        private dsReportEntradas dsReportEntradas;
        private dsReportEntradasTableAdapters.vis_reporte_entradasTableAdapter vis_reporte_entradasTableAdapter;
        private System.Windows.Forms.RadioButton rbtFecha;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cboTipoEspectador;
        private System.Windows.Forms.Button btnMostrarFiltro;
    }
}