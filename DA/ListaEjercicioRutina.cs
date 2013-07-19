using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class ListaEjercicioRutina
    {
        NodoEjercicioRutina cabeza { set; get; }
        NodoEjercicioRutina ultimo { set; get; }
        int largo { set; get; }

        public ListaEjercicioRutina() {
            this.cabeza = null;
            this.ultimo = null;
            this.largo = 0;
        }
    }
}
