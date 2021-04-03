namespace multilistasAlumnosxCurso
{
    partial class frmCursosMatriculadosXAlumn
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
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.lbcursos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTIU = new System.Windows.Forms.TextBox();
            this.btnListarcursosxalum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Location = new System.Drawing.Point(241, 35);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(188, 303);
            this.lbAlumnos.TabIndex = 11;
            // 
            // lbcursos
            // 
            this.lbcursos.FormattingEnabled = true;
            this.lbcursos.Location = new System.Drawing.Point(6, 35);
            this.lbcursos.Name = "lbcursos";
            this.lbcursos.Size = new System.Drawing.Size(188, 303);
            this.lbcursos.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(273, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "alumnos matriculados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "cursos";
            // 
            // txtTIU
            // 
            this.txtTIU.Location = new System.Drawing.Point(94, 9);
            this.txtTIU.Name = "txtTIU";
            this.txtTIU.Size = new System.Drawing.Size(100, 20);
            this.txtTIU.TabIndex = 12;
            // 
            // btnListarcursosxalum
            // 
            this.btnListarcursosxalum.Location = new System.Drawing.Point(94, 344);
            this.btnListarcursosxalum.Name = "btnListarcursosxalum";
            this.btnListarcursosxalum.Size = new System.Drawing.Size(124, 33);
            this.btnListarcursosxalum.TabIndex = 13;
            this.btnListarcursosxalum.Text = "listarcursos de este alumno";
            this.btnListarcursosxalum.UseVisualStyleBackColor = true;
            this.btnListarcursosxalum.Click += new System.EventHandler(this.btnListarcursosxalum_Click);
            // 
            // frmCursosMatriculadosXAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 391);
            this.Controls.Add(this.btnListarcursosxalum);
            this.Controls.Add(this.txtTIU);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.lbcursos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCursosMatriculadosXAlumn";
            this.Text = "frmCursosMatriculadosXAlumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.ListBox lbcursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTIU;
        private System.Windows.Forms.Button btnListarcursosxalum;
    }
}