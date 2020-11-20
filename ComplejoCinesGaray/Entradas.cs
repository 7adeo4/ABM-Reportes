using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoCinesGaray
{
    class Entradas
    {
        string nro_boc;
        double precio;
        int idEspectador;
        int idButaca;
        string codFuncion;
        DateTime horaInicio;
        DateTime fechaInicio;


        public string Nro_boc { get => nro_boc; set => nro_boc = value; }
        public double Precio { get => precio; set => precio = value; }
        public int IdEspectador { get => idEspectador; set => idEspectador = value; }
        public int IdButaca { get => idButaca; set => idButaca = value; }
        public string CodFuncion { get => codFuncion; set => codFuncion = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public Entradas(string nro_boc, double precio, int idEspectador, int idButaca, string codFuncion, DateTime horaInicio, DateTime fechaInicio)
        {
            Nro_boc = nro_boc;
            Precio = precio;
            IdEspectador = idEspectador;
            IdButaca = idButaca;
            CodFuncion = codFuncion;
            HoraInicio = horaInicio;
            FechaInicio = fechaInicio;
        }

        public Entradas()
        {
            Nro_boc = CodFuncion = "";
            Precio = IdEspectador = IdButaca = 0;
            HoraInicio = FechaInicio = DateTime.Today;
        }

        public string MostrarEntradas()
        {
            return nro_boc;
        }
    }
}
