using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multilistasAlumnosxCurso//proyecto de la solucion
{
    public partial class frmIngresoDeCurso : Form
    {//en pirmer lugar es invocar a gestion matricula
        cGestionMatricula objMatricula = new cGestionMatricula();
        public frmIngresoDeCurso()
        {
            InitializeComponent();
        }

        private void btningresarcurso_Click(object sender, EventArgs e)
        {
            /*crear un objeto curso y  asignarle a sus propiedades, los datos q
             * voy a ingresar en las cajas de texto y simplemente registrarlo
          registrar el alumno y el señuelo de que se registro es ok
        */
            cCurso curso = new cCurso();
            curso.Codigo = txtCodigo.Text;
            curso.Nombre = txtnombreCurso.Text;
            objMatricula.insertarCurso(curso);

            MessageBox.Show ("ok");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
