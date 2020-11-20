using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ComplejoCinesGaray
{
    public partial class frmReporteClientes : Form
    {
        Datos dates = new Datos(@"Provider=SQLNCLI11;Data Source=FACU-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM Clientes ";
            if (rbtNombre.Checked)
                strSQL += " ORDER BY 2";
            else if (rbtDNI.Checked)
                strSQL += " WHERE dni is not null ORDER BY 7";
            else if (rbtInicioMembresia.Checked)
                strSQL += " WHERE inicio_membresia is not null ORDER BY 6";
            else
                strSQL += "  ORDER BY 1";
            CLIENTESBindingSource.DataSource = dates.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtDNI.Checked = false;
            rbtInicioMembresia.Checked = false;
            txtFiltro.Clear();
            rvReporteClientes.RefreshReport();
            
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.CLIENTES' Puede moverla o quitarla según sea necesario.
            //this.CLIENTESTableAdapter.Fill(this.dsClientes.CLIENTES);
            string strSQL = "SELECT * FROM Clientes ORDER BY 1";
            
            CLIENTESBindingSource.DataSource = dates.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtDNI.Checked = false;
            rbtInicioMembresia.Checked = false;
            txtFiltro.Clear();
            rvReporteClientes.RefreshReport();

        }

        private void btnMostrarCondicion_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM Clientes WHERE nom_cliente LIKE '" + txtFiltro.Text + "%'";
            if (rbtNombre.Checked)
                strSQL += " ORDER BY 2";
            else if (rbtDNI.Checked)
                strSQL += " AND dni is not null ORDER BY 7";
            else if (rbtInicioMembresia.Checked)
                strSQL += " AND inicio_membresia is not null ORDER BY 6";
            else
                strSQL += "  ORDER BY 1";
            CLIENTESBindingSource.DataSource = dates.consultar(strSQL);
            rbtNombre.Checked = false;
            rbtDNI.Checked = false;
            rbtInicioMembresia.Checked = false;
            txtFiltro.Clear();
            
            rvReporteClientes.RefreshReport();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void rvReporteClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
