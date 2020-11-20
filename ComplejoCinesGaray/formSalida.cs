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
    public partial class formSalida : Form
    {
        public formSalida(string Titulo, string Mensaje)
        {
            
            InitializeComponent();
            lblTitulo.Text = Titulo;
            lblMensaje.Text = Mensaje;
        }

        private void formSalida_Load(object sender, EventArgs e)
        {
            //136; 212 Boton Cancelar
            //253; 286
            if (lblMensaje.Width + 30 >= this.Width)
            {
                this.Width = lblMensaje.Width + 30;
            }
            btnCancelar.Location = new Point(this.Width - 97, 212);
            btnAceptar.DialogResult = DialogResult.OK;
            btnCancelar.DialogResult = DialogResult.Cancel;
        }


    }
}
