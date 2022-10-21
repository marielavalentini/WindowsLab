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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        /*Caso 6-
        Programar métodos: 

        a.             
        Guardar el nombre, apellido y fecha
        nacimiento

        b.              
        Imprimir el nombre completo. Por ejemplo
        “Juan, Perez” 

        c.              
        Usar sobrecargar en el método Imprimir y
        agregar el parámetro edad, entonces solo vamos a retornar  “Juan, Perez
        tiene 28 años”. 
        d. Para calcular la edad. */

        private void btnMostrarNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime dob = Convert.ToDateTime(txtDOB.Text);

            imprimir(nombre, apellido);
        }

        private void btnTodosLosDatos_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime dob = Convert.ToDateTime(txtDOB.Text);
            imprimir(nombre, apellido, dob);
        }

        #region Metodos

        public int calcularEdad(DateTime dob)
        {
            int fechaActual = DateTime.Today.Year;
            int yob = dob.Year;
            int edad = fechaActual - yob;

            return edad;
        }

        public void imprimir(string nombre, string apellido)
        {
            MessageBox.Show("Nombre: " + nombre +"\nApellido: " + apellido);
        }

        //sobrecarga del metodo imprimir

        public void imprimir(string nombre, string apellido, DateTime dob)
        {
            int edad = calcularEdad(dob);

            MessageBox.Show("Nombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad);


        }

        #endregion

       
    }
}
