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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
 /*Caso 3- Crear un método “multiplicar”, que reciba como parámetro un número entero, y escriba
la tabla de multiplicar de ese número (por ejemplo, para el 7 deberá llegar
desde “7 x 1 = 7” hasta  “7 x 12 =84” */

        private void btnCalcularTabla_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            tablaDeMultiplicar(numero);

        }

        #region

        public void tablaDeMultiplicar ( int numero)
        {
            for (int i = 0; i < 12; i++)
            {
                int resultado = numero * i;
                MessageBox.Show(" " + numero + " x " + i + " = " +resultado.ToString());
            }
        }

        #endregion
    }
}
