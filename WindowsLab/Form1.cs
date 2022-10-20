using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Caso 1- Crear un método que permita calcular el área
        de un rectángulo*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal altura = Convert.ToDecimal(txtAltura.Text);
            decimal b = Convert.ToDecimal(txtBase.Text);

            decimal area = areaRectangulo(b, altura);

            MessageBox.Show("El area del rectangulo es: " + area);

        }

        #region metodos

        private decimal areaRectangulo( decimal b, decimal altura)
        {
            decimal area = b * altura;

            return area;
        }

        #endregion

    }
}
