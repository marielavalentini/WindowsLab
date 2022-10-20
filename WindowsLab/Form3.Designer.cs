namespace WindowsLab
{
    partial class Form3
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcularTabla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(95, 70);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(158, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese un numero entero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(271, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // btnCalcularTabla
            // 
            this.btnCalcularTabla.Location = new System.Drawing.Point(98, 119);
            this.btnCalcularTabla.Name = "btnCalcularTabla";
            this.btnCalcularTabla.Size = new System.Drawing.Size(273, 23);
            this.btnCalcularTabla.TabIndex = 2;
            this.btnCalcularTabla.Text = "Calcular Tabla de Multiplicar";
            this.btnCalcularTabla.UseVisualStyleBackColor = true;
            this.btnCalcularTabla.Click += new System.EventHandler(this.btnCalcularTabla_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularTabla);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcularTabla;
    }
}