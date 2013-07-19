using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class NodoBase
    {
        NodoBase sig { set; get; }
        NodoBase ant { set; get; }
        int numeroDia { set; get; }
        ListaEjercicioRutina ejerciciosDiarios { set; get; }

        public NodoBase(int numeroDia) {
            this.numeroDia = numeroDia;
            this.sig = null;
            this.ant = null;
            this.ejerciciosDiarios = new ListaEjercicioRutina();
        }
    }
}
