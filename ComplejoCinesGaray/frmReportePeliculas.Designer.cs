namespace ComplejoCinesGaray
{
    partial class frmReportePeliculas
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
            this.vis_reporte_pelisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarFiltro = new System.Windows.Forms.Button();
            this.rbtGenero = new System.Windows.Forms.RadioButton();
            this.rbtPais = new System.Windows.Forms.RadioButton();
            this.rbtFecha = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cboMayorMenor = new System.Windows.Forms.ComboBox();
            this.vis_reporte_pelisTableAdapter = new ComplejoCinesGaray.dsViewReportPelisTableAdapters.vis_reporte_pelisTableAdapter();
            this.dsReportPelis = new ComplejoCinesGaray.dsReportPelis();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_pelisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vis_reporte_pelisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComplejoCinesGaray.rptPeliculas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(596, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 416);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(83, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarFiltro
            // 
            this.btnMostrarFiltro.Location = new System.Drawing.Point(513, 418);
            this.btnMostrarFiltro.Name = "btnMostrarFiltro";
            this.btnMostrarFiltro.Size = new System.Drawing.Size(95, 23);
            this.btnMostrarFiltro.TabIndex = 2;
            this.btnMostrarFiltro.Text = "Mostrar duración";
            this.btnMostrarFiltro.UseVisualStyleBackColor = true;
            this.btnMostrarFiltro.Click += new System.EventHandler(this.btnMostrarFiltro_Click);
            // 
            // rbtGenero
            // 
            this.rbtGenero.AutoSize = true;
            this.rbtGenero.Location = new System.Drawing.Point(101, 420);
            this.rbtGenero.Name = "rbtGenero";
            this.rbtGenero.Size = new System.Drawing.Size(60, 17);
            this.rbtGenero.TabIndex = 3;
            this.rbtGenero.TabStop = true;
            this.rbtGenero.Text = "Género";
            this.rbtGenero.UseVisualStyleBackColor = true;
            // 
            // rbtPais
            // 
            this.rbtPais.AutoSize = true;
            this.rbtPais.Location = new System.Drawing.Point(167, 419);
            this.rbtPais.Name = "rbtPais";
            this.rbtPais.Size = new System.Drawing.Size(47, 17);
            this.rbtPais.TabIndex = 4;
            this.rbtPais.TabStop = true;
            this.rbtPais.Text = "País";
            this.rbtPais.UseVisualStyleBackColor = true;
            // 
            // rbtFecha
            // 
            this.rbtFecha.AutoSize = true;
            this.rbtFecha.Location = new System.Drawing.Point(220, 419);
            this.rbtFecha.Name = "rbtFecha";
            this.rbtFecha.Size = new System.Drawing.Size(93, 17);
            this.rbtFecha.TabIndex = 5;
            this.rbtFecha.TabStop = true;
            this.rbtFecha.Text = "Fecha estreno";
            this.rbtFecha.UseVisualStyleBackColor = true;
            this.rbtFecha.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(418, 421);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(40, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboMayorMenor
            // 
            this.cboMayorMenor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMayorMenor.FormattingEnabled = true;
            this.cboMayorMenor.Location = new System.Drawing.Point(332, 420);
            this.cboMayorMenor.Name = "cboMayorMenor";
            this.cboMayorMenor.Size = new System.Drawing.Size(80, 21);
            this.cboMayorMenor.TabIndex = 7;
            this.cboMayorMenor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vis_reporte_pelisTableAdapter
            // 
            this.vis_reporte_pelisTableAdapter.ClearBeforeFill = true;
            // 
            // dsReportPelis
            // 
            this.dsReportPelis.DataSetName = "dsReportPelis";
            this.dsReportPelis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "minutos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Orden por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmReportePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMayorMenor);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.rbtFecha);
            this.Controls.Add(this.rbtPais);
            this.Controls.Add(this.rbtGenero);
            this.Controls.Add(this.btnMostrarFiltro);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportePeliculas";
            this.Text = "frmReportePeliculas";
            this.Load += new System.EventHandler(this.frmReportePeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vis_reporte_pelisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarFiltro;
        private System.Windows.Forms.RadioButton rbtGenero;
        private System.Windows.Forms.RadioButton rbtPais;
        private System.Windows.Forms.RadioButton rbtFecha;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboMayorMenor;
        private System.Windows.Forms.BindingSource vis_reporte_pelisBindingSource;
        private dsViewReportPelisTableAdapters.vis_reporte_pelisTableAdapter vis_reporte_pelisTableAdapter;
        private dsReportPelis dsReportPelis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}