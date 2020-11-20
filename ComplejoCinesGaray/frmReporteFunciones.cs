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
    public partial class frmReporteFunciones : Form
    {
        Datos facu = new Datos(@"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public frmReporteFunciones()
        {
            InitializeComponent();
        }

        private void frmReporteFunciones_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_funciones ";
            vis_reporte_funcionesBindingSource.DataSource = facu.consultar(strSQL);
            this.rptviewFunciones.RefreshReport();
           
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM vis_reporte_funciones ";
            if (rbtNombre.Checked)
                strSQL += " ORDER BY 2";
            else if (rbtFecha.Checked)
                strSQL += " ORDER BY 4";
            else
                strSQL += "  ORDER BY 1";
            vis_reporte_funcionesBindingSource.DataSource = facu.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtFecha.Checked = false;

            rptviewFunciones.RefreshReport();
        }

        private void btnMostrarSala_Click(object sender, EventArgs e)
        {
            
            string strSQL = "SELECT * FROM vis_reporte_funciones ";
            
                if (chb2D.Checked && chk3D.Checked==false && chk4D.Checked==false)
                {
                    strSQL += " where Sala = '2D' ";
                    if (chk3D.Checked)
                    {
                        strSQL += "  or sala= '3D' ";
                    }
                    if (chk4D.Checked)
                    {
                        strSQL += " or sala='4D' ";
                    }
                    if (rbtNombre.Checked)
                        strSQL += " ORDER BY 2";
                    else if (rbtFecha.Checked)
                        strSQL += " ORDER BY 4";
                    else
                        strSQL += "  ORDER BY 1";
                    vis_reporte_funcionesBindingSource.DataSource = facu.consultar(strSQL);
                    rptviewFunciones.RefreshReport();

                }
                if (chk3D.Checked && chb2D.Checked == false)
                {
                    strSQL += " where Sala = '3D' ";

                    if (chk4D.Checked)
                    {
                        strSQL += " or Sala= '4D' ";

                    }
                    if (rbtNombre.Checked)
                        strSQL += " ORDER BY 2";
                    else if (rbtFecha.Checked)
                        strSQL += " ORDER BY 4";
                    else
                        strSQL += "  ORDER BY 1";
                    vis_reporte_funcionesBindingSource.DataSource = facu.consultar(strSQL);
                    rptviewFunciones.RefreshReport();

                }
                if (chk4D.Checked && chb2D.Checked == false && chk3D.Checked == false)
                {
                    strSQL += " where sala = '4d'";
                    if (rbtNombre.Checked)
                        strSQL += " ORDER BY 2";
                    else if (rbtFecha.Checked)
                        strSQL += " ORDER BY 4";
                    else
                        strSQL += "  ORDER BY 1";
                    vis_reporte_funcionesBindingSource.DataSource = facu.consultar(strSQL);
                    rptviewFunciones.RefreshReport();

                }

                
            

            else if (chk4D.Checked && chb2D.Checked && chk3D.Checked)
            {
                MessageBox.Show("DEBE SELECCIONAR SÓLO 2 SALAS", "CUIDADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            chb2D.Checked = false;
            chk3D.Checked = false;
            chk4D.Checked = false;
            rbtFecha.Checked = false;
            rbtNombre.Checked = false;
        }



        private void chk4D_CheckedChanged(object sender, EventArgs e)
        {
            //rbtFecha.Enabled = false;
            //rbtNombre.Enabled = false;
        }

        private void chb2D_CheckedChanged(object sender, EventArgs e)
        {
            //rbtFecha.Enabled = false;
            //rbtNombre.Enabled = false;
        }

        private void chk3D_CheckedChanged(object sender, EventArgs e)
        {
            //rbtFecha.Enabled = false;
            //rbtNombre.Enabled = false;
        }
    }
}
