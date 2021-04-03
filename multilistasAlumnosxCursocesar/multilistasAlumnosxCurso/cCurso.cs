using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilistasAlumnosxCurso
{
    public class cCurso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<cAlumno> Alumnos { get; set; }

        public cCurso()
        {
            Alumnos = new List<cAlumno>();
        }
    }
}
