using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoCinesGaray
{
    class Clientes
    {
        int codigo;
        string nombre;
        string apellido;
        string mail;
        Int64 telefono;
        int dni;
        DateTime membresia;
        bool socio;


        public Clientes()
        {
            codigo = 0;
            nombre = "";
            apellido = "";
            mail = String.Empty;
            telefono = 0;
            dni = 0;
            membresia = DateTime.Today;
            socio = false;
        }

        public int pCodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string pApellido { get => apellido; set => apellido = value; }
        public string pMail { get => mail; set => mail = value; }
        public long pTelefono { get => telefono; set => telefono = value; }
        public int pDni { get => dni; set => dni = value; }
        public DateTime pMembresia { get => membresia; set => membresia = value; }
        public bool pSocio { get => socio; set => socio = value; }

        public string toStringClientes()
        {
            return nombre + " " + apellido;
        }
    }
}
