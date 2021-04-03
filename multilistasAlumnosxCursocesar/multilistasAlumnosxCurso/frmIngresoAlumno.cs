using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multilistasAlumnosxCurso
{
    public partial class frmIngresoAlumno : Form
    {
        //en primer lugar hacemos referencia a :
        cGestionMatricula objMatricula = new cGestionMatricula();
        public frmIngresoAlumno()
        {
            InitializeComponent();
        }

        private void frmIngresoAlumno_Load(object sender, EventArgs e)
        {
            lbcursos.DisplayMember = "Nombre";//exibidor
            lbcursos.ValueMember = "codigo";//valor de los miembros
            lbcursos.DataSource = cGestionMatricula.Cursos;
            
            //fuente de datos
            //no tengo un archivo txt y todo se esta trabajando en memoria 
            // tengo dos formularios q son objetos quiero q compartan una misma
            //copia de la lista de cursos, esa es la raxon por la cual la defino 
            // como estatico en la clase "cGestionMatricula" y si lo defino como 
            //statico segnifica que no necesito crear un objeto pra acceder a esa lista,
            //directamente con la clase.
        }

        private void btnIngresarAlumno_Click(object sender, EventArgs e)
        {
            cAlumno alumno = new cAlumno();
            alumno.TIU = int.Parse(txtTIU.Text);
            alumno.NombreCompleto = txtNombreCompleto.Text;
            //asignar el curso que selecciona del listbox(lbCurso) al alumnos
            //del listbox quiero que seleciones un elemento de esa lista
            //ese elemento selec
            foreach (cCurso  curso in lbcursos .SelectedItems)
            {
                objMatricula.insertarAlumnoEnCurso(curso.Codigo, alumno);
            }

            MessageBox.Show("ok");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
