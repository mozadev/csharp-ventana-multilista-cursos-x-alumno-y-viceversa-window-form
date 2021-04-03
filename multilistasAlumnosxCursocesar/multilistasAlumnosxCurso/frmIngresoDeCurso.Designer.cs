namespace multilistasAlumnosxCurso
{
    partial class frmIngresoDeCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreCurso = new System.Windows.Forms.TextBox();
            this.btningresarcurso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(32, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre del curso";
            // 
            // txtnombreCurso
            // 
            this.txtnombreCurso.Location = new System.Drawing.Point(41, 128);
            this.txtnombreCurso.Name = "txtnombreCurso";
            this.txtnombreCurso.Size = new System.Drawing.Size(189, 20);
            this.txtnombreCurso.TabIndex = 3;
            // 
            // btningresarcurso
            // 
            this.btningresarcurso.Location = new System.Drawing.Point(83, 247);
            this.btningresarcurso.Name = "btningresarcurso";
            this.btningresarcurso.Size = new System.Drawing.Size(162, 23);
            this.btningresarcurso.TabIndex = 4;
            this.btningresarcurso.Text = "ingresar curso";
            this.btningresarcurso.UseVisualStyleBackColor = true;
            this.btningresarcurso.Click += new System.EventHandler(this.btningresarcurso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(161, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIngresoDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 371);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btningresarcurso);
            this.Controls.Add(this.txtnombreCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoDeCurso";
            this.Text = "frmIngresoDeCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreCurso;
        private System.Windows.Forms.Button btningresarcurso;
        private System.Windows.Forms.Button btnSalir;
    }
}