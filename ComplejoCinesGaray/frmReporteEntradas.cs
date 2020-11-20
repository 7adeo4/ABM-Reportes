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
    public partial class frmReporteEntradas : Form
    {
        Datos tade = new Datos(@"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public frmReporteEntradas()
        {
            InitializeComponent();
        }

        private void frmReporteEntradas_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_entradas ";
            vis_reporte_entradasBindingSource.DataSource = tade.consultar(strSQL);
            this.rptEntradasview.RefreshReport();
            //cargarCombo(cboTipoEspectador, "TIPOS_ESPECTADOR");
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_entradas ";
            if (rbtFecha.Checked == true)
            {
                strSQL += "ORDER BY 4";
            }
            else strSQL += "ORDER BY 1";
            rbtFecha.Checked = false;
            vis_reporte_entradasBindingSource.DataSource = tade.consultar(strSQL);
            this.rptEntradasview.RefreshReport();
        }

        //public void cargarCombo(ComboBox combo, string nombreTabla)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = tade.CargarTabla(nombreTabla);
        //    combo.DataSource = tabla;
        //    combo.DisplayMember = tabla.Columns[1].ColumnName;
        //    combo.ValueMember = tabla.Columns[0].ColumnName;
        
        //}

        private void btnMostrarFiltro_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_entradas " ;
            if (cboTipoEspectador.SelectedIndex==0)
                strSQL += " WHERE Espectador = 'JUBILADO'";
            if (cboTipoEspectador.SelectedIndex == 1)
                strSQL += " WHERE Espectador = 'ADULTO'";
            if (cboTipoEspectador.SelectedIndex == 2)
                strSQL += " WHERE Espectador= 'INFANTE'";
            if (rbtFecha.Checked == true)
            {
                strSQL += "ORDER BY 4";
            }
            else strSQL += "ORDER BY 1";
            rbtFecha.Checked = false;
            cboTipoEspectador.SelectedIndex = -1;
            vis_reporte_entradasBindingSource.DataSource = tade.consultar(strSQL);
            this.rptEntradasview.RefreshReport();
        }
    }
}
