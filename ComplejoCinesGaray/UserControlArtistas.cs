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
    public partial class UserControlArtistas : UserControl
    {
        Datos dato = new Datos();
        const int tam = 100;
        int c;
        Artistas[] aArtistas = new Artistas[tam];
        bool nuevo;
        string consultaSQL;
        public UserControlArtistas()
        {
            InitializeComponent();
            nuevo = false;
            consultaSQL = "";
            for (int i = 0; i < tam; i++)
            {
                aArtistas[i] = null;
            }
        }

        private void UserControlArtistas_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            mostrarLista();
            cargarCombo(cboNacionalidad, "nacionalidades");
        }

        private void habilitarCampos(bool h)
        {
            txtApellido.Enabled = h;
            txtNombre.Enabled = h;
            cboNacionalidad.Enabled = h;
            btnNuevo.Enabled = !h;
            btnEditar.Enabled = !h;
            btnGuardar.Enabled = h;
            btnBorrar.Enabled = !h;
            lstArtistas.Enabled = !h;
            btnCancelar.Enabled = h;
        }

        private void limpiarCampos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            cboNacionalidad.SelectedIndex = -1;
        }

        private void mostrarLista()
        {
            c = 0;
            dato.LeerTabla("Artistas");
            while (dato.pLector.Read())
            {
                //creo una artista
                Artistas a = new Artistas();
                if (!dato.pLector.IsDBNull(0))
                    a.pCodigo = dato.pLector.GetInt32(0);
                if (!dato.pLector.IsDBNull(1))
                {
                    a.pApellido = dato.pLector.GetString(1);
                }
                if (!dato.pLector.IsDBNull(2))
                {
                    a.pNombre = dato.pLector.GetString(2);
                }
                if (!dato.pLector.IsDBNull(3))
                {
                    a.pNacionalidad = dato.pLector.GetInt32(3);
                }
                aArtistas[c] = a;
                c++;

            }

            dato.pLector.Close();
            dato.Desconectar();
            lstArtistas.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstArtistas.Items.Add(aArtistas[i].toStringArtistas());
            }
        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable t = new DataTable();
            t = dato.CargarTabla(nombreTabla);
            combo.DataSource = t;
            combo.DisplayMember = t.Columns[1].ColumnName;
            combo.ValueMember = t.Columns[0].ColumnName;
        }

        private void lstArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstArtistas.SelectedIndex);
        }

        private void cargarCampos(int c)
        {
            txtApellido.Text = aArtistas[c].pApellido.ToString();
            txtNombre.Text = aArtistas[c].pNombre.ToString();
            cboNacionalidad.SelectedValue = Convert.ToInt32(aArtistas[c].pNacionalidad);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            btnBorrar.Enabled = false;
            btnNuevo.Enabled = false;
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            btnEditar.Enabled = false;
            limpiarCampos();
            lstArtistas.Enabled = false;
            nuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (validarCampos())
            {
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                if (nuevo)
                {
                    Artistas a = new Artistas();
                    a.pApellido = txtApellido.Text;
                    a.pNombre = txtNombre.Text;
                    a.pNacionalidad = (int)cboNacionalidad.SelectedValue;
                    consultaSQL = $"insert into artistas values " +
                                  $"('{a.pApellido}', '{a.pNombre}', {a.pNacionalidad})";
                    dato.Actualizar(consultaSQL);
                    nuevo = false;
                }
                else
                {
                    int i = lstArtistas.SelectedIndex;
                    aArtistas[i].pApellido = txtApellido.Text;
                    aArtistas[i].pNombre = txtNombre.Text;
                    aArtistas[i].pNacionalidad = Convert.ToInt32(cboNacionalidad.SelectedValue);

                    consultaSQL = "update artistas set " +
                           $"apellido='{aArtistas[i].pApellido}', nombre= '{aArtistas[i].pNombre}', id_nacionalidad={aArtistas[i].pNacionalidad}" +
                           $" where cod_artista = {aArtistas[i].pCodigo}";

                    dato.Actualizar(consultaSQL);
                }
                limpiarCampos();
                mostrarLista();
                habilitarCampos(false);
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                lstArtistas.Enabled = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstArtistas.Enabled = true;
            habilitarCampos(false);
            mostrarLista();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere eliminar ese registro?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                string consultaSQL = "delete artistas where cod_artista=" + aArtistas[lstArtistas.SelectedIndex].pCodigo;
                dato.Actualizar(consultaSQL);
                mostrarLista();
                limpiarCampos();
            }
        }
        //Simbolos de Warning
        private bool validarCampos()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese un nombre");
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Ingrese un apellido");
            }

            if (cboNacionalidad.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboNacionalidad, "Elija una nacionalidad");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(cboNacionalidad, null);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }
    }

}

