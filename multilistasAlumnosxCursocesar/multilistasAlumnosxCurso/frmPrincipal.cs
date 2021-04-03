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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ingresoPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoDeCurso frm = new frmIngresoDeCurso();
            frm.ShowDialog();
        }

        private void ingresoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoAlumno frm = new frmIngresoAlumno();
            frm.ShowDialog();
        }

        private void listarAlumnosMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarAlumnosMatriculados frm = new frmListarAlumnosMatriculados();
            frm.ShowDialog();
        }

        private void cursoConMasAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             no he creado ningun formulario y lo que voy a hacer en todo caso es crear un objeto
             de gestion matricual para poder llamar a mi metodo dameCursoConMasAlumnos, esto segun lo que se 
             implemento debe devolver un objeto de tipo curso
           */
            cGestionMatricula objMatricula = new cGestionMatricula();
            cCurso curso = objMatricula.dameCursoConMasAlumnos();
            MessageBox.Show(curso.Nombre);
        }

        private void cursosMatriculadosPorAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursosMatriculadosXAlumn frm = new frmCursosMatriculadosXAlumn();
            frm.ShowDialog();
        }
    }
}
