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
    public partial class frmCursosMatriculadosXAlumn : Form
    {
        public frmCursosMatriculadosXAlumn()
        {
            InitializeComponent();
        }

       

       

        private void btnListarcursosxalum_Click(object sender, EventArgs e)
        {
            cGestionMatricula objMatricula = new cGestionMatricula();
            List<cCurso> aux = new List<cCurso>();
            int TIU = Convert.ToInt32(txtTIU.Text);
            aux = objMatricula.ListarCursoMatriculadosPorAlumno(TIU);
            lbcursos.DataSource = aux;
        }
    }
}
