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
    public partial class UserControlPeliculas : UserControl
    {
        Datos dato = new Datos();
        const int tam = 100;
        int c;
        Peliculas[] aPeliculas = new Peliculas[tam];
        bool nuevo;
        string consultaSQL;
        int index;
        int startIndex;
        string searchString;
        public UserControlPeliculas()
        {
            InitializeComponent();
            //INCIALIZO MI ARRAY
            nuevo = false;
            consultaSQL = "";
            for (int i = 0; i < tam; i++)
            {
                aPeliculas[i] = null;
            }
        }

        private void UserControlPeliculas_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            mostrarLista();
            cargarCombo(cboGenero, "generos");
            cargarCombo(cboNacionalidad, "nacionalidades");
        }
        private void habilitarCampos(bool h)
        {
            txtCodigo.Enabled = h;
            txtDuracion.Enabled = h;
            txtNombre.Enabled = h;
            rbtATPNo.Enabled = h;
            rbtATPSi.Enabled = h;
            cboGenero.Enabled = h;
            cboNacionalidad.Enabled = h;
            dtpFechaEstreno.Enabled = h;
            btnNuevo.Enabled = !h;
            btnEditar.Enabled = !h;
            btnGrabar.Enabled = h;
            btnBorrar.Enabled = !h;
            lstPeliculas.Enabled = !h;
            btnCancelar.Enabled = h;
            btnIr.Enabled = !h;
            txtIr.Enabled = !h;
            btnNext.Enabled = !h;

        }

        private void limpiarCampos()
        {
            txtCodigo.Clear();
            txtDuracion.Clear();
            txtNombre.Clear();
            rbtATPNo.Checked = false;
            rbtATPSi.Checked = false;
            cboGenero.SelectedIndex = -1;
            cboNacionalidad.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Today;

        }

        private void mostrarLista()
        {
            
            c = 0;
            dato.LeerTabla("Peliculas");
            while (dato.pLector.Read())
            {
                //creo una película
                Peliculas p = new Peliculas();
                if (!dato.pLector.IsDBNull(0))
                {
                    p.pCodigo = dato.pLector.GetInt32(0);
                }
                if (!dato.pLector.IsDBNull(1))
                {
                    p.pNombre = dato.pLector.GetString(1);
                }
                if (!dato.pLector.IsDBNull(2))
                {
                    p.pDuracion = (int)dato.pLector["duracion"];
                }
                if (!dato.pLector.IsDBNull(3))
                {
                    p.pAtp = dato.pLector.GetBoolean(3);
                }
                if (!dato.pLector.IsDBNull(4))
                {
                    p.pGenero = dato.pLector.GetInt32(4);
                }
                if (!dato.pLector.IsDBNull(5))
                {
                    p.pNacionalidad = dato.pLector.GetInt32(5);
                }
                if (!dato.pLector.IsDBNull(6))
                {
                    p.pFechaEstreno = dato.pLector.GetDateTime(6);
                }

                aPeliculas[c] = p;
                c++;

            }

            dato.pLector.Close();
            dato.Desconectar();
            lstPeliculas.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstPeliculas.Items.Add(aPeliculas[i].mostrarNombre());
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

        private void lstPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCampos(lstPeliculas.SelectedIndex);
        }

        private void cargarCampos(int c)
        {
            txtCodigo.Text = aPeliculas[c].pCodigo.ToString();
            txtDuracion.Text = aPeliculas[c].pDuracion.ToString();
            txtNombre.Text = aPeliculas[c].pNombre;
            cboGenero.SelectedValue = Convert.ToInt32(aPeliculas[c].pGenero);
            if (aPeliculas[c].pAtp)
                rbtATPSi.Checked = true;
            else
                rbtATPNo.Checked = true;
            cboNacionalidad.SelectedValue = Convert.ToInt32(aPeliculas[c].pNacionalidad);
            dtpFechaEstreno.Value = aPeliculas[c].pFechaEstreno;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtCodigo.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtCodigo.Enabled = false;
            btnEditar.Enabled = false;
            limpiarCampos();
            lstPeliculas.Enabled = false;
            nuevo = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validaciones en mi form
            BorrarMensajeError();
            if (validarCampos())
            {
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                int atp;
                string date;
                if (nuevo)
                {
                    if (rbtATPSi.Checked)
                        atp = 1;
                    else
                        atp = 0;
                    date = dtpFechaEstreno.Value.ToString("MM/dd/yyyy HH:MM");
                    Peliculas p = new Peliculas();
                    p.pNombre = txtNombre.Text;
                    p.pDuracion = Convert.ToInt32(txtDuracion.Text);
                    p.pGenero = (int)cboGenero.SelectedValue;
                    p.pNacionalidad = (int)cboNacionalidad.SelectedValue;
                    date = dtpFechaEstreno.Value.ToString("MM/dd/yyyy HH:MM");
                    consultaSQL = $"insert into peliculas values " +
                                  $"('{p.pNombre}', {p.pDuracion}, {atp}, {p.pGenero}, {p.pNacionalidad}, '{date}')";
                    dato.Actualizar(consultaSQL);
                    nuevo = false;
                }
                else
                {
                    int i = lstPeliculas.SelectedIndex;
                    aPeliculas[i].pDuracion = Convert.ToInt32(txtDuracion.Text);
                    aPeliculas[i].pNombre = txtNombre.Text;
                    aPeliculas[i].pGenero = Convert.ToInt32(cboGenero.SelectedValue);
                    if (rbtATPSi.Checked)
                        atp = 1;
                    else
                        atp = 0;
                    aPeliculas[i].pNacionalidad = Convert.ToInt32(cboNacionalidad.SelectedValue);
                    aPeliculas[i].pFechaEstreno = dtpFechaEstreno.Value;
                    date = aPeliculas[i].pFechaEstreno.ToString("MM/dd/yyyy HH:MM");

                    consultaSQL = "update peliculas set " +
                           $"nom_pelicula='{aPeliculas[i].pNombre}', duracion={aPeliculas[i].pDuracion}, atp = {atp}, id_genero={aPeliculas[i].pGenero}, id_nacionalidad={aPeliculas[i].pNacionalidad}, fecha_estreno='{date}'" +
                           $" where cod_pelicula = {aPeliculas[i].pCodigo}";

                    dato.Actualizar(consultaSQL);
                }

                limpiarCampos();
                mostrarLista();
                habilitarCampos(false);
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
            } lstPeliculas.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstPeliculas.Enabled = true;
            habilitarCampos(false);
            mostrarLista();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            index = -1;
            startIndex = -1;
            searchString = txtIr.Text;
            if (!string.IsNullOrEmpty(searchString))
            {
                index = lstPeliculas.FindString(searchString);
                if (index != -1)
                {
                    lstPeliculas.SetSelected(index, true);
                    startIndex = index;
                }
                else
                    MessageBox.Show("La búsqueda no arrojó resultados");
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            searchString = txtIr.Text;
            if (index != -1)
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    index = lstPeliculas.FindString(searchString, startIndex);
                    lstPeliculas.SetSelected(index, true);
                    startIndex = index;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere eliminar ese registro?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                string consultaSQL = "delete peliculas where cod_pelicula=" + aPeliculas[lstPeliculas.SelectedIndex].pCodigo;
                dato.Actualizar(consultaSQL);
                mostrarLista();
                limpiarCampos();
            }
        }

        //Simbolos de Warning
        private bool validarCampos()
        {
            bool ok = true;

            //if (txtCodigo.Text == "")
            //{
            //    ok = false;
            //    errorProvider1.SetError(txtCodigo, "Ingrese un Codigo");
            //}

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingrese un nombre de pelicula");
            }
            if (txtDuracion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDuracion, "Ingrese la duracion");
            }

            if (cboGenero.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboGenero, "Elija un Género");

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
            //errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(cboGenero, null);
            errorProvider1.SetError(txtDuracion, null);
            errorProvider1.SetError(cboNacionalidad, null);
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosEnteros(e);
        }
    }
}
