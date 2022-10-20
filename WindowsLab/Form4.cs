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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            decimal base1 = Convert.ToDecimal(txtBase1.Text);
            decimal base2 = Convert.ToDecimal(txtBase2.Text);
            decimal altura = Convert.ToDecimal(txtAltura.Text);

            decimal areaTrapecio = calcularAreaTrapecio(base1, base2, altura);

            MessageBox.Show("El area del trapecio es: " + areaTrapecio);

        }

        #region MyRegion
        public decimal calcularAreaTrapecio(decimal base1, decimal base2, decimal altura)
        {
            decimal areaTrapecio = ((base1 + base2) * altura) / 2;
            return areaTrapecio;
        }

        #endregion
    }
}
