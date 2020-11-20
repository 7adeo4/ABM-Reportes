using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplejoCinesGaray
{
    public partial class UserControlReportes : UserControl
    {
        //Datos dates = new Datos(@"Provider=SQLNCLI11;Data Source=DESKTOP-VVK62F7;Integrated Security=SSPI;Initial Catalog=CineGARAY");
        public UserControlReportes()
        {
            InitializeComponent();
        }

        private void UserControlReporteClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            //string strSQL = "SELECT * FROM Producto";
            //if (rbtNombre.Checked)
            //    strSQL += " ORDER BY 1";
            //else if (rbtDNI.Checked)
            //    strSQL += " ORDER BY 2";
            //else
            //    strSQL += " ORDER BY 3";

            //productoBindingSource.DataSource = dates.consultar(strSQL);
            //rvReporteClientes.RefreshReport();
        }


        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReporteClientes());
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReporteFunciones());
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija( new frmReportePeliculas());
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReporteArtistas());
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmReporteEntradas());
        }
    }
}
