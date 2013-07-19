using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public class Rutina
    {
        int idRutina { set; get; }
        ListaEjercicioRutina ejercicios { set; get; }
        DateTime fechaAsignacion { set; get; }

        public Rutina() { }
    }
}
