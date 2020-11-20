using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Regex

namespace ComplejoCinesGaray
{
    public partial class UserControlClientes : UserControl
    {
        Datos d = new Datos();
        const int tam = 900;
        Clientes[] aClientes = new Clientes[tam];
        int c;
        string searchString;
        int index;
        int startIndex;
        int miC;
        bool nuevo;
        string patternMail;
        public UserControlClientes()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                aClientes[i] = null;
            }
            nuevo = false;
            //IR PROBANDO MI PATTERN en https://regex101.com/)
            patternMail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        }

        private void UserControlClientes_Load(object sender, EventArgs e)
        {
            cargarLista();
            btnIr.Enabled = true;
            btnNext.Enabled = false;
            

        }
        private void cargarLista()
        {
            lstClientes.Items.Clear();
            d.LeerTabla("clientes");

            miC = 0;
            //hacer el caminito
            while (d.pLector.Read())
            {
                Clientes c = new Clientes();

                if (!d.pLector.IsDBNull(0))
                    c.pCodigo = (int)d.pLector["cod_cliente"];
                if (!d.pLector.IsDBNull(1))
                    c.pNombre = d.pLector["nom_cliente"].ToString();
                if (!d.pLector.IsDBNull(2))
                    c.pApellido = d.pLector["ape_cliente"].ToString();
                if (!d.pLector.IsDBNull(3))
                    c.pMail = d.pLector["mail"].ToString();
                if (!d.pLector.IsDBNull(4))
                    c.pTelefono = (long)d.pLector["telefono"];
                if (!d.pLector.IsDBNull(5))
                    c.pMembresia = d.pLector.GetDateTime(5);
                if (!d.pLector.IsDBNull(6))
                    c.pDni = (int)d.pLector["dni"];
                if (!d.pLector.IsDBNull(7))
                    c.pSocio = d.pLector.GetBoolean(7);

                aClientes[miC] = c;

                miC++;
            }

            d.Desconectar();
            d.pLector.Close();

            for (int i = 0; i < miC; i++)
            {
                lstClientes.Items.Add(aClientes[i].toStringClientes());
            }


            HabilitarCampos(false);
        }
        private void CargarTxt(int p)
        {
            txtNombre.Text = aClientes[p].pNombre;
            txtApellido.Text = aClientes[p].pApellido;
            txtMail.Text = aClientes[p].pMail;
            txtTel.Text = aClientes[p].pTelefono.ToString();
            txtDNI.Text = aClientes[p].pDni.ToString();
            dtpMembresia.Value = aClientes[p].pMembresia;
            if (aClientes[p].pSocio)
                cbSocio.Checked = true;
            else
                cbSocio.Checked = false;
            HabilitarCampos(false);
            picMail.Visible = false;
        }

        private void HabilitarCampos(bool h)
        {
            txtApellido.Enabled = h;
            txtNombre.Enabled = h;
            txtMail.Enabled = h;
            txtTel.Enabled = h;
            txtDNI.Enabled = h;
            dtpMembresia.Enabled = h;
            cbSocio.Enabled = h;
            btnNuevo.Enabled = !h;
            btnEditar.Enabled = !h;
            btnRegistrar.Enabled = h;
            btnBorrar.Enabled = !h;
            lstClientes.Enabled = !h;
            btnCancelar.Enabled = h;
            btnIr.Enabled = !h;
            txtIr.Enabled = !h;
            btnNext.Enabled = !h;
        }
        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtDNI.Text = String.Empty;
            txtMail.Text = "";
            txtNombre.Text = String.Empty;
            txtTel.Text = "";
            dtpMembresia.Value = DateTime.Today;
            cbSocio.Checked = false;
            txtIr.Text = "";
            picMail.Visible = false;
        }
        private bool Existe(int dni)
        {
            for (int i = 0; i < miC; i++)
            {
                if (aClientes[i].pDni == dni)
                {
                    return true;
                }

            }
            return false;
        }

        private void lstClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CargarTxt(lstClientes.SelectedIndex);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            HabilitarCampos(true);
            lstClientes.Enabled = false;
            dtpMembresia.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstClientes.Enabled = true;
            HabilitarCampos(false);
            picMail.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Simbolo de warning en mi form
            BorrarMensajeError();
            if(validarCampos())
            { 
            int s;
            string date;
            string consultaSQL = "";
                if (nuevo)
                {
                    Clientes c = new Clientes();
                    c.pNombre = txtNombre.Text;
                    c.pApellido = txtApellido.Text;
                    c.pMail = txtMail.Text;
                    c.pTelefono = Convert.ToInt64(txtTel.Text);
                    c.pDni = Convert.ToInt32(txtDNI.Text);
                    c.pMembresia = dtpMembresia.Value;
                    date = dtpMembresia.Value.ToString("MM/dd/yyyy HH:MM");
                    if (cbSocio.Checked)
                    {
                        s = 1;
                    }

                    else
                    {
                        s = 0;
                    }


                    if (!Existe(c.pDni))
                    {
                        if (Regex.IsMatch(txtMail.Text, patternMail) == false)
                        {
                            MessageBox.Show("El mail ingresado no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (s == 1)
                            {
                                consultaSQL = "Insert into clientes values " +
                                           $"('{c.pNombre}','{c.pApellido}','{c.pMail}',{c.pTelefono},'{date}',{c.pDni},{s})";
                            }
                            else
                            {
                                consultaSQL = "Insert into clientes values " +
                                           $"('{c.pNombre}','{c.pApellido}','{c.pMail}',{c.pTelefono}, null ,{c.pDni},{s})";
                            }

                            d.Actualizar(consultaSQL);
                            nuevo = false;
                            LimpiarCampos();
                            cargarLista();
                            HabilitarCampos(false);
                            lstClientes.Enabled = true;
                        }
                    }
                }
                else
                {
                    int i = lstClientes.SelectedIndex;
                    aClientes[i].pNombre = txtNombre.Text;
                    aClientes[i].pApellido = txtApellido.Text;
                    aClientes[i].pMail = txtMail.Text;
                    aClientes[i].pTelefono = Convert.ToInt64(txtTel.Text);
                    aClientes[i].pDni = Convert.ToInt32(txtDNI.Text);
                    aClientes[i].pMembresia = dtpMembresia.Value;
                    if (cbSocio.Checked)
                        s = 1;
                    else
                        s = 0;
                    date = aClientes[i].pMembresia.ToString("MM/dd/yyyy HH:MM");

                    if (Regex.IsMatch(txtMail.Text, patternMail) == false)
                    {
                        MessageBox.Show("El mail ingresado no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (s == 1)
                        {
                            consultaSQL = "update clientes " +
                                       $"set nom_cliente= '{aClientes[i].pNombre}', ape_cliente='{aClientes[i].pApellido}', mail='{aClientes[i].pMail}',telefono= {aClientes[i].pTelefono},inicio_membresia= '{date}', dni={aClientes[i].pDni },socio={s} where cod_cliente={aClientes[i].pCodigo}";
                        }
                        else
                        {
                            consultaSQL = "update clientes " +
                                       $"set nom_cliente= '{aClientes[i].pNombre}', ape_cliente='{aClientes[i].pApellido}', mail='{aClientes[i].pMail}',telefono= {aClientes[i].pTelefono},inicio_membresia= null, dni={aClientes[i].pDni },socio={s} where cod_cliente={aClientes[i].pCodigo}";
                        }
                        d.Actualizar(consultaSQL);
                        cargarLista();
                        HabilitarCampos(false);
                        lstClientes.Enabled = true;
                        picMail.Visible = false;
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere eliminar ese registro?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                string consultaSQL = "delete clientes where cod_cliente=" + aClientes[lstClientes.SelectedIndex].pCodigo;
                d.Actualizar(consultaSQL);
                cargarLista();
                LimpiarCampos();
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            index = -1;
            startIndex = -1;
            searchString = txtIr.Text;
            if (!string.IsNullOrEmpty(searchString))
            {
                index = lstClientes.FindString(searchString);
                if (index != -1)
                {
                    lstClientes.SetSelected(index, true);
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
                    index = lstClientes.FindString(searchString, startIndex);
                    lstClientes.SetSelected(index, true);
                    startIndex = index;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            if (lstClientes.SelectedIndex != -1)
            {
                if (aClientes[lstClientes.SelectedIndex].pSocio == false)
                    dtpMembresia.Enabled = false;
            }

        }

        private void cbSocio_Click(object sender, EventArgs e)
        {
            dtpMembresia.Enabled = true;
        }

        //Validaciones
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(txtMail.Text, patternMail))
            {
                picMail.Visible = true;
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    picMail.Visible = false;
                }
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosEnteros(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosEnteros(e);
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

            
            if (txtMail.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMail, "Ingrese un Mail");
            }
            if (txtTel.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTel, "Ingrese un Telefono");
            }
                
            if (txtDNI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDNI, "Ingrese un DNI");
            }
  
            return ok;
        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtMail, "");
            errorProvider1.SetError(txtTel, "");
            errorProvider1.SetError(txtDNI, "");
        }

    }
}

