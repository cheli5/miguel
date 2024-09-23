using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    internal class Program
    {


        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("0- Salir");
                Console.WriteLine("1- Validar numeros primos");
                Console.WriteLine("2- numero mayor y menor de 3 numeros");
                Console.WriteLine("3- numero mayor de una lista");
                Console.WriteLine("4- numero menor de una lista");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        NumerosPirmos();
                        break;
                    case 2:
                        NumeroMayorNUmeroMenor();
                        break;
                    case 3:
                        NumeroMayordeunalista();
                        break;
                    case 4:
                        NumeroMenordeunalista();
                        break;
                }
                if (continuar)
                {
                    Console.WriteLine("Desea realizar otra operacion?");
                    Console.WriteLine("S- SI");
                    Console.WriteLine("N- NO");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }

        //Tarea:
        //Resolver el problema de los numero primos
        //El codigo debe de mostrar cuales son los numero primos de 1 hasta el numero indicado
        //ejemplo:
        //dado el numero 7
        //debe de mostrar que el numero 2,3, 5 y 7 son primos
        private static void NumerosPirmos()
        {
            int n = 0;
            Console.WriteLine("Dame un numero mayor a 1");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Numero no valido");
            }
            for (int i = 2; i <= n; i++)
            {
                if (IsPrimo(i))
                {
                    Console.WriteLine($"{i} es primo");
                }
            }
            Console.WriteLine();
        }

        private static bool IsPrimo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void NumeroMayorNUmeroMenor()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Dame el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            NumeroMayor(num1, num2, num3);
            NumeroMenor(num1, num2, num3);
        }
        private static void NumeroMayor(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"el numero {num1} es el mayor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el mayor");
                }

            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el segundo numero es el mayor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el mayor");
                }
            }

        }

        private static void NumeroMenor(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("el perimer numero es el menor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el menor");
                }

            }
            else if (num2 < num1)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("el segundo numero es el menor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el menor");
                }
            }

        }
        static void NumeroMayordeunalista()
        {
            bool continuar = true;
            List<int> lista = new List<int>();
            while (continuar)
            {
                Console.WriteLine("escribe un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("preguntar si quiere agragar otro numero");
                Console.WriteLine("S - si");
                Console.WriteLine("N - no");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }
            int numeroMayor = lista[0]; // Inicializa el mayor con el primer número

            for (int i = 0; i < lista.Count; i++) // for 1
            {
                int N = lista[i];
                bool esMayor = true;

                for (int j = 0; j < lista.Count; j++) // for 2
                {
                    int M = lista[j];
                    if (N < M)
                    {
                        esMayor = false;
                        break; // Salimos del for 2 si encontramos un número mayor
                    }
                }

                if (esMayor) // Si es mayor que todos
                {
                    numeroMayor = N; // Actualizamos el número mayor
                }
            }

            Console.WriteLine($"El número mayor es: {numeroMayor}");
        }
        static void NumeroMenordeunalista()
        {
            bool continuar = true;
            List<int> lista = new List<int>();
            while (continuar)
            {
                Console.WriteLine("Escribe un numero:");
                int numero = Convert.ToInt32(Console.ReadLine());
                lista.Add(numero);
                Console.WriteLine("¿Deseas agregar otro número?");
                Console.WriteLine("S - Si");
                Console.WriteLine("N - No");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }

            int numeroMenor = lista[0]; // Inicializa el menor con el primer número

            for (int i = 0; i < lista.Count; i++) // Recorre la lista
            {
                int N = lista[i];
                bool esMenor = true;

                for (int j = 0; j < lista.Count; j++) // Comparación con otros números
                {
                    int M = lista[j];
                    if (N > M)
                    {
                        esMenor = false;
                        break; // Si encuentra un número menor, sale del bucle
                    }
                }

                if (esMenor) // Si es menor que todos
                {
                    numeroMenor = N; // Actualizamos el número menor
                }
            }

            Console.WriteLine($"El número menor es: {numeroMenor}");
        }
    }
}
