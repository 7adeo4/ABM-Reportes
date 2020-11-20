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
    public partial class UserControlFunciones : UserControl
    {
        Datos d = new Datos();
        const int tam = 900;
        Funciones[] aFunciones = new Funciones[tam];
        int c;
        bool nuevo;
        string consultaSQL;
        string hora;
        string date;
        public UserControlFunciones()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                aFunciones[i] = null;
            }
            nuevo = false;
        }
        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable t = new DataTable();
            t = d.CargarTabla(nombreTabla);
            combo.DataSource = t;
            combo.DisplayMember = t.Columns[1].ColumnName;
            combo.ValueMember = t.Columns[0].ColumnName;
        }
        private void UserControlFunciones_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            mostrarLista();
            cargarCombo(cboPeliculas, "Peliculas");
            cargarCombo(cboIdioma, "Idiomas");
            cargarCombo(cboSala, "Salas");
            dtpHoraFuncion.CustomFormat = "hh:mm";
        }
        public void cargarCampos(int c)
        {
            txtCodFuncion.Text = aFunciones[c].CodFuncion.ToString();
            if (aFunciones[c].Subtitulado) chbSubtitulado.Checked = true;
            else chbSubtitulado.Checked = false;
            cboPeliculas.SelectedValue = Convert.ToInt32(aFunciones[c].CodPeli);
            dtpHoraFuncion.Value = aFunciones[c].HoraInicio;
            dtpFechaFuncion.Value = aFunciones[c].FechaInicio;
            cboSala.SelectedValue = Convert.ToInt32(aFunciones[c].IdSala);
            cboIdioma.SelectedValue = Convert.ToInt32(aFunciones[c].IdIdioma);
            if (aFunciones[c].DiaPromo) chbDiaPromo.Checked = true;
            else chbDiaPromo.Checked = false;
            if (aFunciones[c].Feriado) chbFeriado.Checked = true;
            else chbFeriado.Checked = false;
        }
        private void lstFunciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstFunciones.SelectedIndex > -1) 
            { 
                btnEditar.Enabled = true;
                cargarCampos(lstFunciones.SelectedIndex);
            }
        }

        private void mostrarLista()
        {
            lstFunciones.Items.Clear();
            d.LeerTabla("funciones");

            c = 0;

            while (d.pLector.Read())
            {
                Funciones funciones = new Funciones();

                if (!d.pLector.IsDBNull(0))
                    funciones.CodFuncion = (string)d.pLector["cod_funcion"];
                if (!d.pLector.IsDBNull(1))
                    funciones.Subtitulado = d.pLector.GetBoolean(1);
                if (!d.pLector.IsDBNull(2))
                    funciones.CodPeli = d.pLector.GetInt32(2);
                if (!d.pLector.IsDBNull(3))
                    funciones.HoraInicio = Convert.ToDateTime(d.pLector.GetString(3));
                if (!d.pLector.IsDBNull(4))
                    funciones.FechaInicio = d.pLector.GetDateTime(4);
                if (!d.pLector.IsDBNull(5))
                    funciones.IdSala = d.pLector.GetInt32(5);
                if (!d.pLector.IsDBNull(6))
                    funciones.IdIdioma = d.pLector.GetInt32(6);
                if (!d.pLector.IsDBNull(7))
                    funciones.DiaPromo = d.pLector.GetBoolean(7);
                if (!d.pLector.IsDBNull(8))
                    funciones.Feriado = d.pLector.GetBoolean(8);

                aFunciones[c] = funciones;

                c++;
            }

            d.pLector.Close();
            d.Desconectar();
           
            lstFunciones.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstFunciones.Items.Add(aFunciones[i].MostrarFunciones());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            nuevo = true;
            limpiarCampos();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (validarCampos())
            {
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
                int subtitulo;
                int feriado;
                int diaPromo;

                if (nuevo)
                {
                    Funciones f = new Funciones();
                    if (chbSubtitulado.Checked) subtitulo = 1;
                    else subtitulo = 0;
                    if (chbDiaPromo.Checked) diaPromo = 1;
                    else diaPromo = 0;
                    if (chbFeriado.Checked) feriado = 1;
                    else feriado = 0;
                    f.CodFuncion = txtCodFuncion.Text;
                    f.CodPeli = (int)cboPeliculas.SelectedValue;
                    f.HoraInicio = dtpHoraFuncion.Value;
                    f.FechaInicio = dtpFechaFuncion.Value;
                    f.IdSala = (int)cboSala.SelectedValue;
                    f.IdIdioma = (int)cboIdioma.SelectedValue;
                    hora = f.HoraInicio.ToString("HH:MM");
                    date = f.FechaInicio.ToString("MM/dd/yyyy");

                    if (!existe(f.CodFuncion, f.HoraInicio, f.FechaInicio))
                    {
                        consultaSQL = $"insert into funciones values " +
                                     $"('{f.CodFuncion}', {subtitulo}, {f.CodPeli}, '{hora}', '{date}',{f.IdSala},{f.IdIdioma},{diaPromo},{feriado})";
                        d.Actualizar(consultaSQL);
                    }
                    else MessageBox.Show("No wacho no se puede");
                    nuevo = false;
                }

                else
                {
                    int i = lstFunciones.SelectedIndex;
                    aFunciones[i].CodFuncion = txtCodFuncion.Text;
                    if (chbSubtitulado.Checked) subtitulo = 1;
                    else subtitulo = 0;
                    aFunciones[i].CodPeli = Convert.ToInt32(cboPeliculas.SelectedValue);
                    aFunciones[i].HoraInicio = dtpHoraFuncion.Value;
                    aFunciones[i].FechaInicio = dtpFechaFuncion.Value;
                    aFunciones[i].IdSala = Convert.ToInt32(cboSala.SelectedValue);
                    aFunciones[i].IdIdioma = Convert.ToInt32(cboIdioma.SelectedValue);
                    if (chbDiaPromo.Checked) diaPromo = 1;
                    else diaPromo = 0;
                    if (chbFeriado.Checked) feriado = 1;
                    else feriado = 0;

                    hora = aFunciones[i].HoraInicio.ToString("HH:mm:ss");
                    date = aFunciones[i].FechaInicio.ToString("yyyy/MM/dd");

                    consultaSQL = "update funciones set " +
                           $" Subtitulado={subtitulo}, cod_pelicula = {aFunciones[i].CodPeli}," +
                           $" id_sala={aFunciones[i].IdSala}, id_idioma={aFunciones[i].IdIdioma}, dia_promo = {diaPromo}, feriado = {feriado}" +
                           $" where cod_funcion=  '{aFunciones[lstFunciones.SelectedIndex].CodFuncion}' and " +
                           $"hora_inicio = '{aFunciones[lstFunciones.SelectedIndex].HoraInicio.ToString("HH:mm:ss")}' " +
                           $"and fecha_funcion = '{aFunciones[lstFunciones.SelectedIndex].FechaInicio.ToString("yyyy/MM/dd")}'";

                    d.Actualizar(consultaSQL);
                }
                limpiarCampos();
                mostrarLista();
                habilitarCampos(false);
            }
        }
            private bool existe(string codigo, DateTime hora, DateTime fecha)
            {
                bool x = false;
                for (int i = 0; i < c; i++)
                {
                    if (aFunciones[i].CodFuncion == codigo && aFunciones[i].HoraInicio == hora && aFunciones[i].FechaInicio == fecha)
                    {
                        x = true;
                    }
                }
                return x;
            }
            private void limpiarCampos()
            {
                txtCodFuncion.Clear();
                chbSubtitulado.Checked = false;
                cboPeliculas.SelectedIndex = -1;
                dtpHoraFuncion.Value = DateTime.Today;
                dtpFechaFuncion.Value = DateTime.Today;
                cboSala.SelectedIndex = -1;
                cboIdioma.SelectedIndex = -1;
                chbDiaPromo.Checked = false;
                chbFeriado.Checked = false;
                lblLaTetera.Text = "";

            }
            private void habilitarCampos(bool h)
            {
                txtCodFuncion.Enabled = h;
                chbSubtitulado.Enabled = h;
                cboPeliculas.Enabled = h;
                dtpHoraFuncion.Enabled = h;
                dtpFechaFuncion.Enabled = h;
                cboSala.Enabled = h;
                cboIdioma.Enabled = h;
                chbFeriado.Enabled = h;
                chbDiaPromo.Enabled = h;
                btnBorrar.Enabled = !h;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = h;
                btnNuevo.Enabled = !h;
                btnGrabar.Enabled = h;
                lstFunciones.Enabled = !h;

            }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtCodFuncion.Enabled = false;
            dtpFechaFuncion.Enabled = false;
            dtpHoraFuncion.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere eliminar ese registro?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                hora = aFunciones[lstFunciones.SelectedIndex].HoraInicio.ToString("HH:MM");
                date = aFunciones[lstFunciones.SelectedIndex].FechaInicio.ToString("MM/dd/yyyy");
                string consultaSQL = $"delete funciones where cod_funcion=  '{aFunciones[lstFunciones.SelectedIndex].CodFuncion}' and " +
                    $"hora_inicio = '{hora}' and fecha_funcion = '{date}'";
                d.Actualizar(consultaSQL);
                mostrarLista();
                limpiarCampos();
            }
        }

        //Simbolos de Warning
        private bool validarCampos()
        {
            bool ok = true;

            if (txtCodFuncion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodFuncion, "Ingrese un Codigo");
            }

            if (cboPeliculas.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboPeliculas, "Elija Una Pelicula");
            }

            if (cboSala.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboSala, "Elija una sala");
            }

            if (cboIdioma.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboIdioma, "Elija un idioma");
            }
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtCodFuncion, "");
            errorProvider1.SetError(cboPeliculas, null);
            errorProvider1.SetError(cboSala, null);
            errorProvider1.SetError(cboIdioma, null);
        }

        private void cboSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSala.SelectedIndex == 0 || cboSala.SelectedIndex == 3 || cboSala.SelectedIndex == 6) lblLaTetera.Text = "Cines Garay Centro";
            if (cboSala.SelectedIndex == 1 || cboSala.SelectedIndex == 4 || cboSala.SelectedIndex == 7) lblLaTetera.Text = "Cines Garay Nuevo Urca";
            if (cboSala.SelectedIndex == 2 || cboSala.SelectedIndex == 5 || cboSala.SelectedIndex == 8) lblLaTetera.Text = "Cines Garay Ruta 20";
        }

        private void txtCodFuncion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }
    }
}
