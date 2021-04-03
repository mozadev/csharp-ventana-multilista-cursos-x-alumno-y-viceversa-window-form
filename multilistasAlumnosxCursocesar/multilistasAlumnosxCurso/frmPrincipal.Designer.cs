namespace multilistasAlumnosxCurso
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlumnosMatriculadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoConMasAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoExisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosMatriculadosPorAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoPorCursoToolStripMenuItem,
            this.ingresoDeAlumnoToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresoToolStripMenuItem.Text = "ingresos";
            // 
            // ingresoPorCursoToolStripMenuItem
            // 
            this.ingresoPorCursoToolStripMenuItem.Name = "ingresoPorCursoToolStripMenuItem";
            this.ingresoPorCursoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresoPorCursoToolStripMenuItem.Text = "ingreso por curso";
            this.ingresoPorCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoPorCursoToolStripMenuItem_Click);
            // 
            // ingresoDeAlumnoToolStripMenuItem
            // 
            this.ingresoDeAlumnoToolStripMenuItem.Name = "ingresoDeAlumnoToolStripMenuItem";
            this.ingresoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresoDeAlumnoToolStripMenuItem.Text = "ingreso de alumno";
            this.ingresoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeAlumnoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAlumnosMatriculadosToolStripMenuItem,
            this.cursoConMasAlumnosToolStripMenuItem,
            this.cursoExisteToolStripMenuItem,
            this.cursosMatriculadosPorAlumnoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consultasToolStripMenuItem.Text = "consultas";
            // 
            // listarAlumnosMatriculadosToolStripMenuItem
            // 
            this.listarAlumnosMatriculadosToolStripMenuItem.Name = "listarAlumnosMatriculadosToolStripMenuItem";
            this.listarAlumnosMatriculadosToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.listarAlumnosMatriculadosToolStripMenuItem.Text = "listar alumnos matriculados en un curso";
            this.listarAlumnosMatriculadosToolStripMenuItem.Click += new System.EventHandler(this.listarAlumnosMatriculadosToolStripMenuItem_Click);
            // 
            // cursoConMasAlumnosToolStripMenuItem
            // 
            this.cursoConMasAlumnosToolStripMenuItem.Name = "cursoConMasAlumnosToolStripMenuItem";
            this.cursoConMasAlumnosToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.cursoConMasAlumnosToolStripMenuItem.Text = "curso con mas alumnos";
            this.cursoConMasAlumnosToolStripMenuItem.Click += new System.EventHandler(this.cursoConMasAlumnosToolStripMenuItem_Click);
            // 
            // cursoExisteToolStripMenuItem
            // 
            this.cursoExisteToolStripMenuItem.Name = "cursoExisteToolStripMenuItem";
            this.cursoExisteToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.cursoExisteToolStripMenuItem.Text = "curso existe";
            // 
            // cursosMatriculadosPorAlumnoToolStripMenuItem
            // 
            this.cursosMatriculadosPorAlumnoToolStripMenuItem.Name = "cursosMatriculadosPorAlumnoToolStripMenuItem";
            this.cursosMatriculadosPorAlumnoToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.cursosMatriculadosPorAlumnoToolStripMenuItem.Text = "cursos matriculados por alumno";
            this.cursosMatriculadosPorAlumnoToolStripMenuItem.Click += new System.EventHandler(this.cursosMatriculadosPorAlumnoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 345);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlumnosMatriculadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoConMasAlumnosToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cursoExisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosMatriculadosPorAlumnoToolStripMenuItem;
    }
}