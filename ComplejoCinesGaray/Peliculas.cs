using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoCinesGaray
{
    class Peliculas
    {
        int codigo;
        string nombre;
        int duracion;
        bool atp;
        int genero;
        int nacionalidad;
        DateTime fechaEstreno;

        public int pCodigo { get => codigo; set => codigo = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public int pDuracion { get => duracion; set => duracion = value; }
        public bool pAtp { get => atp; set => atp = value; }
        public int pGenero { get => genero; set => genero = value; }
        public int pNacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public DateTime pFechaEstreno { get => fechaEstreno; set => fechaEstreno = value; }

        public Peliculas()
        {
            codigo = 0;
            nombre = "";
            duracion = 0;
            atp = false;
            genero = 0;
            nacionalidad = 0;
            fechaEstreno = DateTime.Today;
        }


        public string mostrarNombre()
        {
            return nombre;
        }
    }
}
