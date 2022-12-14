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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

/*Caso 5.- 
Programar métodos: 
-->Se ingresa el nombre del usuario, el sexo y el tipo de
usuario. 
-->Validar el tipo de usuario (Rol): Administrador, estándar e
invitados.  
-->Validar su sexo. 
--> Imprimir el
nombre del usuario, el sexo y el tipo de usuario. Por ejemplo “Usuario:
Gabriela – Sexo: Femenino – Rol: Administrador”*/

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string sexo = txtSexo.Text; 
            string rol = txtUsuario.Text;
            validarRol(rol);
            validarSexo(sexo);
            mostrar(nombre, sexo, rol);
        }

        #region MyRegion

        public void validarRol (string rol)
        {
            if (rol != "administrador" && rol != "estandar" && rol != "invitado")
            {
                MessageBox.Show("EL ROL INGRESADO NO ESTA HABILITADO, INGRESE ADMINISTRADOR, ESTANDAR O INVITADO");
            }
        }
        public void validarSexo(string sexo)
        {
            if( sexo != "femenino" && sexo != "masculino")
            {
                MessageBox.Show("EL SEXO INGRESADO ES INCORRECTO, POR FAVOR INGRESAR FEMENINO O MASCULINO");

            }
        }

        public void mostrar (string nombre, string sexo, string rol)
        {
            MessageBox.Show("Usauario: " + nombre + "\nSexo: " + sexo + "\nRol: " + rol);
        }

        #endregion
    }
}
