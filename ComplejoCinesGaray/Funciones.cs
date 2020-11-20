using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejoCinesGaray
{
    class Funciones
    {


        string codFuncion;
        bool subtitulado;
        int codPeli;
        DateTime horaInicio;
        DateTime fechaInicio;
        int idSala;
        int idIdioma;
        bool diaPromo;
        bool feriado;
        
        public string CodFuncion { get => codFuncion; set => codFuncion = value; }
        public bool Subtitulado { get => subtitulado; set => subtitulado = value; }
        public int CodPeli { get => codPeli; set => codPeli = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int IdSala { get => idSala; set => idSala = value; }
        public int IdIdioma { get => idIdioma; set => idIdioma = value; }
        public bool DiaPromo { get => diaPromo; set => diaPromo = value; }
        public bool Feriado { get => feriado; set => feriado = value; }


        public Funciones(string codFuncion, bool subtitulado, int codPeli, DateTime horaInicio, DateTime fechaInicio, int idSala, int idIdioma, bool diaPromo, bool feriado)
        {
            CodFuncion = codFuncion;
            Subtitulado = subtitulado;
            CodPeli = codPeli;
            HoraInicio = horaInicio;
            FechaInicio = fechaInicio;
            IdSala = idSala;
            IdIdioma = idIdioma;
            DiaPromo = diaPromo;
            Feriado = feriado;
        }


        public Funciones()
        {
            CodFuncion = "";
            Subtitulado = DiaPromo = Feriado = false;
            IdIdioma = IdSala = CodPeli = 0;
            FechaInicio = DateTime.Today;
            HoraInicio = DateTime.Today;
        }

        public string MostrarFunciones()
        {
            return codFuncion + " - " + fechaInicio.ToShortDateString() + " - "+ horaInicio.ToShortTimeString();
        }
    }

}
