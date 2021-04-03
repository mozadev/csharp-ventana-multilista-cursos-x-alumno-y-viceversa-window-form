namespace multilistasAlumnosxCurso
{
    partial class frmIngresoAlumno
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
            this.btnIngresarAlumno = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTIU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcursos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarAlumno
            // 
            this.btnIngresarAlumno.Location = new System.Drawing.Point(73, 208);
            this.btnIngresarAlumno.Name = "btnIngresarAlumno";
            this.btnIngresarAlumno.Size = new System.Drawing.Size(100, 23);
            this.btnIngresarAlumno.TabIndex = 9;
            this.btnIngresarAlumno.Text = "matricula";
            this.btnIngresarAlumno.UseVisualStyleBackColor = true;
            this.btnIngresarAlumno.Click += new System.EventHandler(this.btnIngresarAlumno_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(40, 133);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(163, 20);
            this.txtNombreCompleto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "nombre completo";
            // 
            // txtTIU
            // 
            this.txtTIU.Location = new System.Drawing.Point(31, 40);
            this.txtTIU.Name = "txtTIU";
            this.txtTIU.Size = new System.Drawing.Size(163, 20);
            this.txtTIU.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TIU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "cursos";
            // 
            // lbcursos
            // 
            this.lbcursos.FormattingEnabled = true;
            this.lbcursos.Location = new System.Drawing.Point(313, 58);
            this.lbcursos.Name = "lbcursos";
            this.lbcursos.Size = new System.Drawing.Size(183, 277);
            this.lbcursos.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(119, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIngresoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 430);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbcursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIngresarAlumno);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTIU);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoAlumno";
            this.Text = "frmIngresoAlumno";
            this.Load += new System.EventHandler(this.frmIngresoAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarAlumno;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTIU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbcursos;
        private System.Windows.Forms.Button btnSalir;
    }
}