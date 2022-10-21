namespace WindowsLab
{
    partial class Form6
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.btnMostrarNombre = new System.Windows.Forms.Button();
            this.btnTodosLosDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(110, 132);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(121, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Ingrese su apellido";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(84, 192);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(192, 16);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "lngrese su fecha de nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(297, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(297, 132);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(133, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(297, 186);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(133, 22);
            this.txtDOB.TabIndex = 5;
            // 
            // btnMostrarNombre
            // 
            this.btnMostrarNombre.Location = new System.Drawing.Point(87, 251);
            this.btnMostrarNombre.Name = "btnMostrarNombre";
            this.btnMostrarNombre.Size = new System.Drawing.Size(189, 23);
            this.btnMostrarNombre.TabIndex = 6;
            this.btnMostrarNombre.Text = "Mostrar Nombre y apellido";
            this.btnMostrarNombre.UseVisualStyleBackColor = true;
            this.btnMostrarNombre.Click += new System.EventHandler(this.btnMostrarNombre_Click);
            // 
            // btnTodosLosDatos
            // 
            this.btnTodosLosDatos.Location = new System.Drawing.Point(297, 251);
            this.btnTodosLosDatos.Name = "btnTodosLosDatos";
            this.btnTodosLosDatos.Size = new System.Drawing.Size(168, 23);
            this.btnTodosLosDatos.TabIndex = 7;
            this.btnTodosLosDatos.Text = "Mostrar todos los datos";
            this.btnTodosLosDatos.UseVisualStyleBackColor = true;
            this.btnTodosLosDatos.Click += new System.EventHandler(this.btnTodosLosDatos_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodosLosDatos);
            this.Controls.Add(this.btnMostrarNombre);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Button btnMostrarNombre;
        private System.Windows.Forms.Button btnTodosLosDatos;
    }
}