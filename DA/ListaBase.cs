using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class ListaBase
    {
        NodoBase cabeza { set; get; }
        NodoBase ultimo { set; get; }
        int largo { set; get; }

        public ListaBase() {
            this.cabeza = null;
            this.ultimo = null;
            this.largo = 0;
        }
    }
}
