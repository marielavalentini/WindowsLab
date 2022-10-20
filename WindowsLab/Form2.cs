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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
                /* Caso 2- Crea un método que identifique la edad ingresada, si ingresa el valor 0 muestre un
        mensaje de ERROR, seguido distinguir la edad ingresa ,si es menor de 18,
        indicar que es menor de edad, si ingresa edad mayor igual a 18 y menor a 60, indicar que
        es una persona mayor de edad, y por último si es mayor igual de 60 , indicar que es
        una persona adulto mayor.*/

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);
            validarEdad(edad);
            //validarEdadSwitch(edad);//no funciona
        }

        #region metodos

        public void validarEdad (int edad)
        {
            if (edad == 0)
            {
                MessageBox.Show("ERROR!, LA EDAD INGRESADA ES: " + edad);

            }else if (edad<18)
            {
                MessageBox.Show("MENOR DE EDAD");

            }else if(edad>18 && edad<60)
            {
                MessageBox.Show("MAYOR DE EDAD");

            }else
            {
                MessageBox.Show("LA EDAD INGREDA CORRESPONDE A UN ADULTO MAYOR");
            }

        }
        
        public void validarEdadSwitch(int edad)
        { 
                    switch (edad)
                    {
                        case 1 when edad == 0:
                      
                            MessageBox.Show("ERROR!, LA EDAD INGRESADA ES: " + edad);
                            break;

                        case 2 when edad < 18:

                            MessageBox.Show("MENOR DE EDAD");
                            break;

                        case 3 when edad > 18 && edad < 60:

                            MessageBox.Show("MAYOR DE EDAD");
                            break;  

                        case 4 when edad > 60:

                            MessageBox.Show("LA EDAD INGREDA CORRESPONDE A UN ADULTO MAYOR");
                            break;  

                    }
            }
        }

        #endregion
    }

