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
    public partial class frmListarAlumnosMatriculados : Form
    {
        public frmListarAlumnosMatriculados()
        {
            InitializeComponent();
        }

        private void frmListarAlumnosMatriculados_Load(object sender, EventArgs e)
        {
            lbcursos.DisplayMember = "Nombre";//exibidor
            lbcursos.ValueMember = "codigo";//valor de los miembros
            lbcursos.DataSource = cGestionMatricula.Cursos;
        }

        private void lbcursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo SelectedItem, recuperar un elemento seleccionado del 
            // listBox, pero ese elemento tiene que ser de tipo curso, entonces hacemos
            // conversion, de manera que con ese curso seleccionado yo puedo acceder a lista 
            // de alumnos y mostrarlo pues en la lista de alumnos de este formulario
           cCurso curso=(cCurso)lbcursos.SelectedItem;
            lbAlumnos.DisplayMember = "NombreCompleto";
            lbAlumnos.ValueMember = "TIU";
            lbAlumnos.DataSource = curso.Alumnos;



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
