using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoCinesGaray
{
    class Artistas
    {
        int codigo;
        string apellido;
        string nombre;
        int nacionalidad;

        public Artistas()
        {
            codigo = 0;
            apellido = "";
            nombre = "";
            nacionalidad = 0;
        }
        public Artistas(int codigo, string apellido, string nombre, int nacionalidad)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }

        public int pCodigo { get => codigo; set => codigo = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public int pNacionalidad { get => nacionalidad; set => nacionalidad = value; }

        //public int pCodigo { get; set; }
        //public string pApellido { get; set; }
        //public string pNombre { get; set; }
        //public int pNacionalidad { get; set; }

        public string toStringArtistas()
        {
            return apellido + " " + nombre;
        }

    }
}
