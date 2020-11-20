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
    public partial class frmPrincipal : Form
    {
        Button btnActuar;
        public frmPrincipal()
        {
            InitializeComponent();
   
          
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            EsconderUserControl(userControlClientes1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlReportes1);
            
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlFunciones1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlArtistas1);
            EsconderUserControl(userControlClientes1);
            EsconderUserControl(userControlReportes1);

            ActivarBotoncito(sender, RGBColors.Colorcito);
        }
        private void btnEntradas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlClientes1);
            EsconderUserControl(userControlArtistas1);
            EsconderUserControl(userControlFunciones1);
            
            EsconderUserControl(userControlReportes1);
            ActivarBotoncito(sender, RGBColors.Colorcito);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlClientes1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlArtistas1);
            EsconderUserControl(userControlFunciones1);
            EsconderUserControl(userControlReportes1);
            ActivarBotoncito(sender, RGBColors.Colorcito);
        }
        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlPeliculas1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlArtistas1);
            EsconderUserControl(userControlFunciones1);
            EsconderUserControl(userControlClientes1);
            EsconderUserControl(userControlReportes1);
            ActivarBotoncito(sender, RGBColors.Colorcito);
        }
        private void btnArtistas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlArtistas1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlFunciones1);
            EsconderUserControl(userControlClientes1);
            EsconderUserControl(userControlReportes1);
            ActivarBotoncito(sender, RGBColors.Colorcito);
        }
        private void MostrarUserControl(UserControl uc)
        {
            uc.Enabled = true;
            uc.Show();
            uc.BringToFront();
            picLogo.Visible = false;
            uc.Location = new Point(220, 38);
            
        }
        private void EsconderUserControl (UserControl uc)
        {
            uc.Enabled = false;
            uc.Hide();
        }

        //Metodos para mover el form
        private Point Posicion = Point.Empty;
        private bool move = false;
        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            Posicion = new Point(e.X, e.Y);
            move = true;
        }
        private void Titulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - Posicion.X), (this.Top + e.Y - Posicion.Y));
        }
        //Metodos para cambiar el color de los botones en mi form
        private void ActivarBotoncito(object Botoncito, Color Colorcito)
        {
            if (Botoncito != null)
            {
                DesahibilitarBotncito();
                btnActuar = (Button)Botoncito;
                btnActuar.BackColor = Color.DarkBlue;
                btnActuar.ForeColor = Colorcito;
                btnActuar.TextAlign = ContentAlignment.MiddleCenter;
                btnActuar.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
                btnActuar.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActuar.ImageAlign = ContentAlignment.MiddleRight;

            }
        }
        private void DesahibilitarBotncito()
        {
            if (btnActuar != null)
            {
                btnActuar.BackColor = Color.FromArgb(26, 32, 40);
                btnActuar.ForeColor = Color.White;
                btnActuar.TextAlign = ContentAlignment.MiddleCenter;
                btnActuar.FlatAppearance.MouseOverBackColor = Color.White;
                btnActuar.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActuar.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private struct RGBColors
        {
            public static Color Colorcito = Color.White;
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            formSalida mensaje = new formSalida("¿Esta seguro de que desea salir?", "Saliendo...");
            DialogResult result = mensaje.ShowDialog();
            if (result == DialogResult.OK)
                e.Cancel = false;
            else if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void userControlReporteClientes2_Load(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(userControlReportes1);
            EsconderUserControl(userControlEntradas1);
            EsconderUserControl(userControlPeliculas1);
            EsconderUserControl(userControlFunciones1);
            EsconderUserControl(userControlClientes1);
            
           ActivarBotoncito(sender, RGBColors.Colorcito);
        }
    }
}
