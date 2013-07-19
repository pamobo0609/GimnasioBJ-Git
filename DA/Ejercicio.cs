using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class Ejercicio
    {
        int idEjercicio { set; get; }
        String descripcion { set; get; }

        public Ejercicio() { }

        public Ejercicio(int id, String descripcion) {
            this.idEjercicio = id;
            this.descripcion = descripcion;
        }
    }
}
