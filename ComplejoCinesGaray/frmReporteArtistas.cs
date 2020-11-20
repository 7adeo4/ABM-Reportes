using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoCinesGaray
{
    public partial class frmReporteArtistas : Form
    {
        Datos fafu = new Datos(@"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public frmReporteArtistas()
        {
            InitializeComponent();
        }

        private void frmReporteArtistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReportesArtistas.vis_reporte_artistas' Puede moverla o quitarla según sea necesario.
            //this.vis_reporte_artistasTableAdapter.Fill(this.dsReportesArtistas.vis_reporte_artistas);
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.CLIENTES' Puede moverla o quitarla según sea necesario.
            //this.CLIENTESTableAdapter.Fill(this.dsClientes.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'dsViewArtistas.vis_reporte_artistas' Puede moverla o quitarla según sea necesario.
            //this.vis_reporte_artistasTableAdapter.Fill(this.dsViewArtistas.vis_reporte_artistas);

            //this.reportViewer1.RefreshReport();
            string strSQL = "SELECT * FROM vis_reporte_artistas ORDER BY 1";
            vis_reporte_artistasBindingSource.DataSource = fafu.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtPais.Checked = false;

            rptviewerArtistas.RefreshReport();
            cargarCombo(cboPais, "nacionalidades");
            
            
        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = fafu.CargarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_artistas ";
            if (rbtNombre.Checked)
                strSQL += " ORDER BY 2";
           else if (rbtPais.Checked)
                strSQL += " ORDER BY 3";
            else
                strSQL += "  ORDER BY 1";
            vis_reporte_artistasBindingSource.DataSource = fafu.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtPais.Checked = false;
            
            rptviewerArtistas.RefreshReport();
        }

        private void btnMostrarFiltro_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_artistas where ID = " +cboPais.SelectedValue;
            if (rbtNombre.Checked)
                strSQL += " ORDER BY 2";
            else if (rbtPais.Checked)
                strSQL += " ORDER BY 3";
            else
                strSQL += "  ORDER BY 1";
            vis_reporte_artistasBindingSource.DataSource = fafu.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtPais.Checked = false;

            rptviewerArtistas.RefreshReport();
        }
    }
}
