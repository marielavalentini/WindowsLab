namespace WindowsLab
{
    partial class Form4
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
            this.lblBase1 = new System.Windows.Forms.Label();
            this.lblBase2 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnAreaTrapecio = new System.Windows.Forms.Button();
            this.txtBase1 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBase1
            // 
            this.lblBase1.AutoSize = true;
            this.lblBase1.Location = new System.Drawing.Point(66, 57);
            this.lblBase1.Name = "lblBase1";
            this.lblBase1.Size = new System.Drawing.Size(192, 16);
            this.lblBase1.TabIndex = 0;
            this.lblBase1.Text = "Ingrese la medida de la base 1";
            // 
            // lblBase2
            // 
            this.lblBase2.AutoSize = true;
            this.lblBase2.Location = new System.Drawing.Point(66, 92);
            this.lblBase2.Name = "lblBase2";
            this.lblBase2.Size = new System.Drawing.Size(192, 16);
            this.lblBase2.TabIndex = 1;
            this.lblBase2.Text = "Ingrese la medida de la base 2";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(66, 122);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(102, 16);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Ingrese la altura";
            // 
            // btnAreaTrapecio
            // 
            this.btnAreaTrapecio.Location = new System.Drawing.Point(69, 152);
            this.btnAreaTrapecio.Name = "btnAreaTrapecio";
            this.btnAreaTrapecio.Size = new System.Drawing.Size(296, 23);
            this.btnAreaTrapecio.TabIndex = 3;
            this.btnAreaTrapecio.Text = "Calcular el area del trapecio";
            this.btnAreaTrapecio.UseVisualStyleBackColor = true;
            this.btnAreaTrapecio.Click += new System.EventHandler(this.btnAreaTrapecio_Click);
            // 
            // txtBase1
            // 
            this.txtBase1.Location = new System.Drawing.Point(265, 57);
            this.txtBase1.Name = "txtBase1";
            this.txtBase1.Size = new System.Drawing.Size(100, 22);
            this.txtBase1.TabIndex = 4;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(265, 92);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 22);
            this.txtBase2.TabIndex = 5;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(265, 122);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.txtBase1);
            this.Controls.Add(this.btnAreaTrapecio);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase2);
            this.Controls.Add(this.lblBase1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase1;
        private System.Windows.Forms.Label lblBase2;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnAreaTrapecio;
        private System.Windows.Forms.TextBox txtBase1;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.TextBox txtAltura;
    }
}