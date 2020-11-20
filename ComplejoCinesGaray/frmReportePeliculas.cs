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
    public partial class frmReportePeliculas : Form
    {
        Datos agus = new Datos(@"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public frmReportePeliculas()
        {
            InitializeComponent();
        }

        private void frmReportePeliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReportPelis.vis_reporte_pelis' Puede moverla o quitarla según sea necesario.
            //this.vis_reporte_pelisTableAdapter.Fill(this.dsReportPelis.vis_reporte_pelis);
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.CLIENTES' Puede moverla o quitarla según sea necesario.
            //this.CLIENTESTableAdapter.Fill(this.dsClientes.CLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'dsViewReportPelis.vis_reporte_pelis' Puede moverla o quitarla según sea necesario.
            //this.vis_reporte_pelisTableAdapter.Fill(this.dsViewReportPelis.vis_reporte_pelis);
            //// TODO: esta línea de código carga datos en la tabla 'dsClientes.CLIENTES' Puede moverla o quitarla según sea necesario.
            //this.CLIENTESTableAdapter.Fill(this.dsClientes.CLIENTES);
            //// TODO: esta línea de código carga datos en la tabla 'dsPeliculas.PELICULAS' Puede moverla o quitarla según sea necesario.
            //this.PELICULASTableAdapter.Fill(this.dsPeliculas.PELICULAS);
            //// TODO: esta línea de código carga datos en la tabla 'dsPeliculas.GENEROS' Puede moverla o quitarla según sea necesario.
            //this.GENEROSTableAdapter.Fill(this.dsPeliculas.GENEROS);
            //// TODO: esta línea de código carga datos en la tabla 'dsPeliculas.NACIONALIDADES' Puede moverla o quitarla según sea necesario.
            //this.NACIONALIDADESTableAdapter.Fill(this.dsPeliculas.NACIONALIDADES);

            //this.reportViewer1.RefreshReport();
            string strSQL = "SELECT * FROM vis_reporte_pelis  ORDER BY 1";
            
            vis_reporte_pelisBindingSource.DataSource = agus.consultar(strSQL);
            rbtGenero.Checked = false;
            rbtPais.Checked = false;
            rbtFecha.Checked = false;
            reportViewer1.RefreshReport();
            cboMayorMenor.Items.Add("Mayor a");
            cboMayorMenor.Items.Add("Menor a");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            

            string strSQL = "SELECT * FROM vis_reporte_pelis ";
            if (rbtGenero.Checked)
                strSQL += " ORDER BY 5";
            else if (rbtPais.Checked)
                strSQL += " ORDER BY 6";
            else if (rbtFecha.Checked)
                strSQL += " ORDER BY 7";
            else
                strSQL += "  ORDER BY 1";
            vis_reporte_pelisBindingSource.DataSource = agus.consultar(strSQL);
            rbtGenero.Checked = false;
            rbtPais.Checked = false;
            rbtFecha.Checked = false;
            reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarFiltro_Click(object sender, EventArgs e)
        {
            if (cboMayorMenor.SelectedIndex == -1)
                MessageBox.Show("Ingrese mayor o menor...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (txtFiltro.Text == "")
                MessageBox.Show("Por favor ingrese una duración para comparar...", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            else
            {
                string boquita;
                if (cboMayorMenor.SelectedIndex == 0)
                    boquita = ">";
                else boquita = "<";

                string strSQL = "SELECT * FROM vis_reporte_pelis WHERE [Duración] " + boquita + txtFiltro.Text.ToString();
                if (rbtGenero.Checked)
                    strSQL += " ORDER BY 5";
                else if (rbtPais.Checked)
                    strSQL += " ORDER BY 6";
                else if (rbtFecha.Checked)
                    strSQL += " ORDER BY 7";
                else
                    strSQL += "  ORDER BY 1";
                vis_reporte_pelisBindingSource.DataSource = agus.consultar(strSQL);
                rbtGenero.Checked = false;
                rbtPais.Checked = false;
                rbtFecha.Checked = false;
                reportViewer1.RefreshReport();
            }
            
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosEnteros(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
