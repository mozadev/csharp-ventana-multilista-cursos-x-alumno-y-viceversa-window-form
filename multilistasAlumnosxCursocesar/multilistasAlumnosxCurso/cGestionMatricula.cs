using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilistasAlumnosxCurso
{
    public class cGestionMatricula
    {
        //lista de cursos donde un alumno se puede matricular: lista general de cursos
        // Necesito que esta lista sea utilizada por todos los metodos ,y ademas, que los datos se compartan de manera global
        //indistantamente por los objetos que yo cree lo que hare es declararlo como STATIC.
        /*static: nos sirve para compartir una misma copia de un atributo, en este caso lo que hare  es compartir esta lista
        entre n objetos que pueda crear y lo otro es que si lo declaro estatico, los elementos que voy a guardar aqui lo voy a 
        poder utilizar de manera global entre un formulario y otro.
        Anteriormente yo estaba usando un solo formulario, si yo guardo desde un solo formulario una lista  no hay problema, pero que
        pasa si guardo en un formulario y desde otro formulario quiero saber que cosa es lo que guarde en la lista, sino lo nombro
        estatico pasará que cuando cargo el otro formulario la data que pude almacenar en el primer formulario se va a borrar. Entonces, 
        lo que yo quiero es que se mantenga los datos, que se conserven Y LO declaro  STATIC
            */
        public static List<cCurso> Cursos { get; set; }
        public static List<cAlumno> Alumnos { get; set; }
        public cGestionMatricula()
        {
            if (Cursos == null)
            {
                Cursos = new List<cCurso>();
                Alumnos = new List<cAlumno>();
            }
        }
        public void insertarCurso(cCurso curso)
        {
            Cursos.Add(curso);
        }
        public void insertarAlumno(cCurso alumno)
        {
            Cursos.Add(alumno);
        }

        /*Metodo insertarAlumnoEnCurso para lo cual necesito pasarle el codigo curso y los datos 
          del alumno. porque necesito el codigo del curso ? porque para
          asignar un alum a un curs, 1°:busc si existe el curso o buscar el curso
           donde lo voy a asignar.En la list curs mediant el met find asigno un delegate y decirl
           al deleg. que busq un valor tipo cCurso.Es deciR lo que digo es que busques un valor 
           de est tip en esta lista y si encuentra algo lo que vas a recuperar es un objeto
           tipo cursoEncontrado.
           La comparacion lo voy a hacer por codigo porq es lo q estoy entrando
           . Si existe algun objeto cCurso q tenga un codigo igual al codigo que esta ingresando 
           (codigoCurso) esto obviamente va a devolver un verdadero, caso contrario devolvera un 
           falso
          */
        /*
        si curso encontrado es diferente de null, eso va a indicar que la parte de arriba 
        retorna verdadero, significa que si existe un curso con ese codigo,y po lo tanto,
        cursoEncontrado-punto-accedo a la lista que esta dentro del curso y en esa lista 
        agrego al alumno. Recuerden esta lista es la que esta definido como un atributo 
        de la clase cCurso: 

        public List<cAlumno> Alumnos { get; set; }

        Entonces con esto 
        ya tengo mi metod insertar alumno en curso
        */
        public void insertarAlumnoEnCurso(string codigoCurso, cAlumno alumno)
        {
            cCurso cursoEncontrado = Cursos.Find(delegate (cCurso value) { return (value.Codigo == codigoCurso); });//devuelve v o f


            if (cursoEncontrado != null)
            {
                cursoEncontrado.Alumnos.Add(alumno);
                Alumnos.Add(alumno);
            }
        }

        /*
        metodo ListarAlumnoDeCurso, en este caso tendre que pasarle el codigo del curso
        y que muestre quienes son los alumnso que  estan en ese curso, igual que arriba 
        voy a necesitar buscar nuevamente el curso por el codigo, voy a necesitar preguntar
        pero a diferencia de los que esta arriba, si es que lo encuentra simplemente voy a
        retornar la lista de alumnos que estan dentro de ese curso, caso contrario voy a retornar
        null.
         */
        public List<cAlumno> ListarAlumnoDeCurso(string codigoCurso)
        {
            cCurso cursoEncontrado = Cursos.Find(delegate (cCurso value) { return value.Codigo == codigoCurso; });
            //v o f.
            if (cursoEncontrado != null)
            {
                return cursoEncontrado.Alumnos;
            }
            else
            {
                return null;
            }
        }
        /*Metodo cual es el curso que tiene mas alumnos, metodo que me devuelva el curso que tiene mas  alumnos
         como quiero saber el curso con ms alumnos lo que va a suceder es que tengo q recorrer la lista de cursos 
         y comenzar a hacer comparaciones, voy a tener que recorrer esta lista y comenzar a comparar que este respecto al
         anterior tiene mas alumnos o si este con respecto al anterior mientras voy recorriendo la lista de cursos, entonces
       para guardar simpre el anterior es tener un objeto curso de manera temporal  con el cual voy a necesitar hacer comparaciones
       luego voy a recorrer la lista de cursos y de esa lista de curso voy a sacar un objeto curso, mientras recorro esa lista voy 
       a preguntar si de este curso, su lista de alumnos, la cantidad es mayor a la cantidad del temporal ( objero curso temporal)
       si es mayor, el nuevo temporal seria el curso q cumple, eso es para ir guardando porque sino guardo el anterior no voy a saber
       con quien compararlo y no voy a poder obtener el resultado. Entonces creo mi temporal, recorro , mientras recorro voy sacando
       los objetos curso, comparo si este curso con respecto al anterior, obviamente en la primera iteracion la primera linea :
       
              cCurso temp = new cCurso();
           
       va a ser cero porque recien lo estoy creando y esta en blanco y por lo tanto ( temp = curso ); curso va a pasar ocupar la posicion temp.
       o va a refere  el objeto temp. y de ahi es como un punto de inicio
        */
        public cCurso dameCursoConMasAlumnos()
        {
            cCurso temp = new cCurso();
            foreach (cCurso curso in Cursos)
            {
                if (curso.Alumnos.Count > temp.Alumnos.Count)
                {
                    temp = curso;
                }
            }
            return temp;
        }
        /*
         el siguiente metodo es saber si un metodo existe o no mediante un criterio por ejemplo el codigo de curso
         tenemos el metodo exists pero a este le tenemos que pasar  un predicado y le digo que quiero si existen cursos o objetos 
         de este tipo cCurso (cCurso value) o quiero saber si existe un curso que tenga este codigo "codigoCurso"
         entonces al delegate ( delegado) le digo: quiero q averigues si existe algun valor de este tipo "cCurso" que coincida con el
         codigo del curso "codigoCurso", esto me va a retornar v o f 
          */

        public bool CursoExiste(string codigoCurso)
        {
            return Cursos.Exists(delegate (cCurso value) { return value.Codigo == codigoCurso; });

        }
        /*
         
         metodo que me devuelva toda la lista de cursos que lleva un alumno.
         le voy a ingresar el TIU del alumno,el objetivo es devolver esta lista, ver en que cursos esta 
         matriculado, creo esta lista de cursos matricualados, voy a recorrer esa lista de cursos general
         mientras recorro, lo que tengo que hacer es que si dentro de este curso, la lista de alumnos, cuantos 
         alumnos existen, quiero saber si en este "curso" existe un alumno q coincide con este codigo.
         Entonces, voy a lista general de cursos "Cursos"  y obtengo el "curso" ( objeto) , con el curso accedo a la lista de alumnos 
         ( atributo de la clase del objeto" curso" y en esa lista
         averiguo si existe un objeto alumno que cumpla la siguiente condicion: que " value.TIU = TIU que 
         va a ingresar por parametro" , si es q existiera voy a pasar este curso  esta lista:
         
           List<cCurso> cursosMatriculadosDeAlumno

         si es que existe le digo: adiciona el curso donde él el esta matriculado.
         osea si : return value.TIU == TIU;  me devuelve verdadero eso va a indicar que si
         existe este alumno dentro de este curso. Por lo tanto lo que hare es que ese curso
         que coincide lo voy a agregar a esta lista: " cursosMatriculadosDeAlumno.Add(curso);"

           Entonces recorro la lista general de cursos, verifico si en este curso-> en esta lista de alumnos existe el
           alumno con este TIU. Si existe, este curso lo agrego a la nueva lista "cursosMatriculadosDeAlumno". luego de eso
           tendremos que retornar la lista de los cursos matriculados del alumno
         */
        public List<cCurso> ListarCursoMatriculadosPorAlumno(int TIU)
        {
            //lista de cursos donde se encuentra matriculado el alumno.
            //Cursos: Lista general de cursos.
            List<cCurso> cursosMatriculadosDeAlumno = new List<cCurso>();
            foreach (cCurso curso in Cursos)
            {
                if (curso.Alumnos.Exists(delegate (cAlumno value)
               {
                   return value.TIU == TIU;

               }))
                    cursosMatriculadosDeAlumno.Add(curso);
            }
            return cursosMatriculadosDeAlumno;

        }

        // despues se tiene que implementar los formularios
    }
}
