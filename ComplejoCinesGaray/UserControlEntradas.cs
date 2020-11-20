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
    public partial class UserControlEntradas : UserControl
    {
        Datos d = new Datos();
        const int tam = 900;
        Entradas[] aEntradas = new Entradas[tam];
        int c;
        bool nuevo;
        string consultaSQL;
        string hora;
        string date;
        public UserControlEntradas()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                aEntradas[i] = null;
            }
            nuevo = false;
        }
        private void cargarCombo(ComboBox combo, string nombreTabla, string pk, string nombreColumna)
        {
            DataTable tabla = new DataTable();
            tabla = d.CargarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = nombreColumna;
            combo.ValueMember = pk;
        }
        private void UserControlEntradas_Load(object sender, EventArgs e)
        {
            cargarCombo(cboTipo, "TIPOS_ESPECTADOR", "id_tipo_espectador", "tipo_espectador");
            cargarCombo(cboNroButaca, "BUTACAS", "id_butaca", "id_butaca");
            mostrarLista();
            habilitarCampos(false);
            cargarCombo2(cboFuncion, cboHora, cboFecha, "funciones_hora_fecha");
        }

        private void mostrarLista()
        {
            lstEntradas.Items.Clear();
            d.LeerTabla("entradas");

            c = 0;

            while (d.pLector.Read())
            {
                Entradas e = new Entradas();

                if (!d.pLector.IsDBNull(0))
                    e.Nro_boc = (string)d.pLector["nro_boc"];
                if (!d.pLector.IsDBNull(1))
                    e.Precio = Convert.ToDouble(d.pLector.GetDecimal(1));
                if (!d.pLector.IsDBNull(2))
                    e.IdEspectador = d.pLector.GetInt32(2);
                if (!d.pLector.IsDBNull(3))
                    e.IdButaca = d.pLector.GetInt32(3);
                if (!d.pLector.IsDBNull(4))
                    e.CodFuncion = d.pLector.GetString(4);
                if (!d.pLector.IsDBNull(5))
                    e.HoraInicio = Convert.ToDateTime(d.pLector.GetString(5));
                if (!d.pLector.IsDBNull(6))
                    e.FechaInicio = d.pLector.GetDateTime(6);

                aEntradas[c] = e;

                c++;
            }

            d.pLector.Close();
            d.Desconectar();

            lstEntradas.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                lstEntradas.Items.Add(aEntradas[i].MostrarEntradas());
            }
        }
        private void limpiarCampos()
        {
            cboFuncion.SelectedIndex = -1;
            cboNroButaca.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            cboFecha.SelectedIndex = -1;
            cboHora.SelectedIndex = -1;
            txtCodigoBoleto.Clear();
            txtPrecio.Clear();
        }
        private void habilitarCampos(bool h)
        {
            cboNroButaca.Enabled = h;
            cboTipo.Enabled = h;
            cboHora.Enabled = h;
            cboFuncion.Enabled = h;
            cboFecha.Enabled = h;
            txtPrecio.Enabled = h;
            txtCodigoBoleto.Enabled = h;
            btnBorrar.Enabled = !h;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = h;
            btnNuevo.Enabled = !h;
            btnGrabar.Enabled = h;
            lstEntradas.Enabled = !h;
        }
        public void cargarCampos(int c)
        {
            txtCodigoBoleto.Text = aEntradas[c].Nro_boc;
            cboTipo.SelectedValue = Convert.ToInt32(aEntradas[c].IdEspectador);
            //dtpHoraFuncion.Value = aEntradas[c].HoraInicio;
            cboNroButaca.SelectedValue = Convert.ToInt32(aEntradas[c].IdButaca);
            //dtpFechaFuncion.Value = aEntradas[c].FechaInicio;
            txtPrecio.Text = aEntradas[c].Precio.ToString();
            //txtCodigoBoleto.Text = aEntradas[c].Nro_boc.ToString();
            cboFuncion.Text = aEntradas[c].CodFuncion;
            cboHora.Text = aEntradas[c].HoraInicio.ToString("HH:mm:ss");
            cboFecha.Text = aEntradas[c].FechaInicio.ToString("MM/dd/yyyy");
        }
        private void lstEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstEntradas.SelectedIndex > -1)
            { 
            cargarCampos(lstEntradas.SelectedIndex);
            btnEditar.Enabled = true;
            }
        }
        private void cargarCombo2(ComboBox combo, ComboBox combo2, ComboBox combo3, string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = d.CargarTabla(nombreTabla);

            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[0].ColumnName;

            combo2.DataSource = tabla;

            combo2.DisplayMember = tabla.Columns[1].ColumnName;

            combo3.DataSource = tabla;

            combo3.DisplayMember = tabla.Columns[2].ColumnName;

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            nuevo = true;
            limpiarCampos();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere eliminar ese registro?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string consultaSQL = $"delete entradas where nro_boc = '{aEntradas[lstEntradas.SelectedIndex].Nro_boc}'";
                d.Actualizar(consultaSQL);
                mostrarLista();
                limpiarCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            txtCodigoBoleto.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (validarCampos())
            {
                if (nuevo)
                {
                    Entradas en = new Entradas();

                    en.Nro_boc = txtCodigoBoleto.Text;
                    en.CodFuncion = cboFuncion.Text;
                    en.Precio = double.Parse(txtPrecio.Text);
                    en.IdButaca = (int)cboNroButaca.SelectedValue;
                    en.IdEspectador = (int)cboTipo.SelectedValue;
                    en.HoraInicio = Convert.ToDateTime(cboHora.Text);
                    en.FechaInicio = Convert.ToDateTime(cboFecha.Text);
                    hora = en.HoraInicio.ToString("HH:mm:ss");
                    date = en.FechaInicio.ToString("MM/dd/yyyy");
                    consultaSQL = $"insert into ENTRADAS values " +
                                     $"('{en.Nro_boc}', {en.Precio}, {en.IdEspectador}, {en.IdButaca}, '{en.CodFuncion}','{hora}','{date}')";
                    d.Actualizar(consultaSQL);
                    nuevo = false;
                }
                else
                {
                    int i = lstEntradas.SelectedIndex;
                    aEntradas[i].Nro_boc = txtCodigoBoleto.Text;
                    aEntradas[i].Precio = double.Parse(txtPrecio.Text);
                    aEntradas[i].CodFuncion = cboFuncion.Text;
                    aEntradas[i].IdEspectador = Convert.ToInt32(cboTipo.SelectedValue);
                    aEntradas[i].IdButaca = Convert.ToInt32(cboNroButaca.SelectedValue);
                    aEntradas[i].HoraInicio = Convert.ToDateTime(cboHora.Text);
                    aEntradas[i].FechaInicio = Convert.ToDateTime(cboFecha.Text);


                    hora = aEntradas[i].HoraInicio.ToString("HH:mm:ss");
                    date = aEntradas[i].FechaInicio.ToString("MM/dd/yyyy");

                    consultaSQL = "update entradas set " +
                           $"precio_actual = {aEntradas[i].Precio}, id_tipo_espectador = {aEntradas[i].IdEspectador}," +
                           $" id_butaca={aEntradas[i].IdButaca}, cod_funcion='{aEntradas[i].CodFuncion}' ,hora_inicio='{hora}', fecha_funcion='{date}'" +
                           $" where nro_boc = '{aEntradas[lstEntradas.SelectedIndex].Nro_boc}'";

                    d.Actualizar(consultaSQL);
                }
                limpiarCampos();
                mostrarLista();
                habilitarCampos(false);

            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex > 2) txtDiscapacitados.Text = "Con Discapacidad";
            else txtDiscapacitados.Text = "Sin Discapacidad";
        }

        //Simbolos de Warning
        private bool validarCampos()
        {
            bool ok = true;

            if (txtCodigoBoleto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodigoBoleto, "Ingrese un Codigo");
            }

            if (txtPrecio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrecio, "Ingrese un Precio");
            }
            if (cboTipo.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboTipo, "Elija un tipo de espectador");
            }

            if (cboNroButaca.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboNroButaca, "Elija una Butaca");

            }

            if (cboFuncion.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboFuncion, "Elija un codigo de funcion");
            }

            if (cboHora.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboHora, "Elija una hora de funcion");

            }

            if (cboFecha.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(cboFecha, "Elija una fecha de funcion");

            }

            return ok;
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtCodigoBoleto, "");
            errorProvider1.SetError(txtPrecio, "");
            errorProvider1.SetError(cboTipo, null);
            errorProvider1.SetError(cboNroButaca, null);
            errorProvider1.SetError(cboFuncion, null);
            errorProvider1.SetError(cboHora, null);
            errorProvider1.SetError(cboFecha, null);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosEnteros(e);
        }

    }
}
