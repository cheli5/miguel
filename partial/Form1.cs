using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            Operaciones op = new Operaciones();
            Verificaciones ver = new Verificaciones();

            // Suma
            int resultadoSuma = op.Suma(num1, num2);
            MessageBox.Show("Suma: " + resultadoSuma);

            // Resta
            int resultadoResta = op.Resta(num1, num2);
            MessageBox.Show("Resta: " + resultadoResta);

            // Multiplicación
            int resultadoMultiplicacion = op.Multiplicacion(num1, num2);
            MessageBox.Show("Multiplicación: " + resultadoMultiplicacion);

            // División
            double resultadoDivision = op.Division(num1, num2);
            MessageBox.Show("División: " + resultadoDivision);

            // Verificaciones
            string verificacion = ver.VerificarNumeros(num1, num2);
            MessageBox.Show(verificacion);
        }
    }

    class Operaciones
    {
        // Método para sumar
        public int Suma(int a, int b)
        {
            return a + b;
        }

        // Método para restar
        public int Resta(int a, int b)
        {
            return a - b;
        }

        // Método para multiplicar
        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        // Método para dividir
        public double Division(int a, int b)
        {
            if (b == 0)
            {
                MessageBox.Show("No se puede dividir por 0");
                return 0;
            }
            return (double)a / b;
        }
    }

    class Verificaciones
    {
        // Método para verificar números usando operadores relacionales y lógicos
        public string VerificarNumeros(int a, int b)
        {
            StringBuilder resultado = new StringBuilder();

            // Verificar si a es mayor que b
            if (a > b)
            {
                resultado.AppendLine("El primer número es mayor que el segundo.");
            }
            else if (a < b)
            {
                resultado.AppendLine("El primer número es menor que el segundo.");
            }
            else
            {
                resultado.AppendLine("Ambos números son iguales.");
            }

            // Verificar si ambos números son positivos
            if (a > 0 && b > 0)
            {
                resultado.AppendLine("Ambos números son positivos.");
            }
            else if (a <= 0 && b <= 0)
            {
                resultado.AppendLine("Ambos números son negativos o cero.");
            }
            else
            {
                resultado.AppendLine("Uno de los números es positivo y el otro no lo es.");
            }

            // Verificar si la suma de a y b es par
            if ((a + b) % 2 == 0)
            {
                resultado.AppendLine("La suma de los dos números es par.");
            }
            else
            {
                resultado.AppendLine("La suma de los dos números es impar.");
            }

            return resultado.ToString();
        }
    }
}
