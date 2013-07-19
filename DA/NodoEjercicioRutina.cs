using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class NodoEjercicioRutina
    {
        NodoEjercicioRutina sig { set; get; }
        NodoEjercicioRutina ant { set; get; }
        EjercicioRutina dato { set; get; }

        public NodoEjercicioRutina(EjercicioRutina dato) {
            this.sig = null;
            this.ant = null;
            this.dato = dato;
        }
    }
}
