namespace Escritorio
{
    partial class AltaInscripcion
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
            this.seleccionarCurso = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnSeleccionarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seleccionarCurso
            // 
            this.seleccionarCurso.Location = new System.Drawing.Point(51, 77);
            this.seleccionarCurso.Name = "seleccionarCurso";
            this.seleccionarCurso.Size = new System.Drawing.Size(217, 23);
            this.seleccionarCurso.TabIndex = 45;
            this.seleccionarCurso.Text = "Seleccionar Curso";
            this.seleccionarCurso.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(95, 142);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(127, 23);
            this.btnAgregarUsuario.TabIndex = 39;
            this.btnAgregarUsuario.Text = "Confirmar Inscripción";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarAlumno
            // 
            this.btnSeleccionarAlumno.Location = new System.Drawing.Point(51, 48);
            this.btnSeleccionarAlumno.Name = "btnSeleccionarAlumno";
            this.btnSeleccionarAlumno.Size = new System.Drawing.Size(217, 23);
            this.btnSeleccionarAlumno.TabIndex = 46;
            this.btnSeleccionarAlumno.Text = "Seleccionar Alumno";
            this.btnSeleccionarAlumno.UseVisualStyleBackColor = true;
            // 
            // AltaInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 196);
            this.Controls.Add(this.btnSeleccionarAlumno);
            this.Controls.Add(this.seleccionarCurso);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Name = "AltaInscripcion";
            this.Text = "Nueva Inscripcion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seleccionarCurso;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnSeleccionarAlumno;
    }
}