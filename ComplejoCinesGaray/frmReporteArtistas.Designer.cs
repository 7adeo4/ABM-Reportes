namespace ComplejoCinesGaray
{
    partial class frmReporteArtistas
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
            this.vis_reporte_artistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptviewerArtistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.rbtPais = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.btnMostrarFiltro = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.vis_reporte_artistasTableAdapter = new ComplejoCinesGaray.dsViewArtistasTableAdapters.vis_reporte_artistasTableAdapter();
            this.dsReportesArtistas = new ComplejoCinesGaray.dsReportesArtistas();
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_artistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesArtistas)).BeginInit();
            this.SuspendLayout();
            // 
            // rptviewerArtistas
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vis_reporte_artistasBindingSource;
            this.rptviewerArtistas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptviewerArtistas.LocalReport.ReportEmbeddedResource = "ComplejoCinesGaray.rptArtistas.rdlc";
            this.rptviewerArtistas.Location = new System.Drawing.Point(12, 12);
            this.rptviewerArtistas.Name = "rptviewerArtistas";
            this.rptviewerArtistas.ServerReport.BearerToken = null;
            this.rptviewerArtistas.Size = new System.Drawing.Size(596, 388);
            this.rptviewerArtistas.TabIndex = 0;
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(363, 418);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(141, 21);
            this.cboPais.TabIndex = 14;
            // 
            // rbtPais
            // 
            this.rbtPais.AutoSize = true;
            this.rbtPais.Location = new System.Drawing.Point(156, 417);
            this.rbtPais.Name = "rbtPais";
            this.rbtPais.Size = new System.Drawing.Size(47, 17);
            this.rbtPais.TabIndex = 11;
            this.rbtPais.TabStop = true;
            this.rbtPais.Text = "País";
            this.rbtPais.UseVisualStyleBackColor = true;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(90, 417);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtNombre.TabIndex = 10;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // btnMostrarFiltro
            // 
            this.btnMostrarFiltro.Location = new System.Drawing.Point(510, 416);
            this.btnMostrarFiltro.Name = "btnMostrarFiltro";
            this.btnMostrarFiltro.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarFiltro.TabIndex = 9;
            this.btnMostrarFiltro.Text = "Mostrar por país";
            this.btnMostrarFiltro.UseVisualStyleBackColor = true;
            this.btnMostrarFiltro.Click += new System.EventHandler(this.btnMostrarFiltro_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(9, 414);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // vis_reporte_artistasTableAdapter
            // 
            this.vis_reporte_artistasTableAdapter.ClearBeforeFill = true;
            // 
            // dsReportesArtistas
            // 
            this.dsReportesArtistas.DataSetName = "dsReportesArtistas";
            this.dsReportesArtistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReporteArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(620, 452);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.rbtPais);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.btnMostrarFiltro);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rptviewerArtistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteArtistas";
            this.Text = "frmReporteArtistas";
            this.Load += new System.EventHandler(this.frmReporteArtistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_artistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportesArtistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptviewerArtistas;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.RadioButton rbtPais;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.Button btnMostrarFiltro;
        private System.Windows.Forms.Button btnMostrar;
        private dsViewArtistasTableAdapters.vis_reporte_artistasTableAdapter vis_reporte_artistasTableAdapter;
        private System.Windows.Forms.BindingSource vis_reporte_artistasBindingSource;
        private dsReportesArtistas dsReportesArtistas;
    }
}