using System;

namespace diverror
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros.Si el segundo no es cero,
             mostrará el resultado de dividir entre el primero y el segundo.Por el contrario,
             si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/
            Console.WriteLine("VERIFICADOR DE DIVISION EN 0");
            double num1, num2;
            Console.Write("Ingrese el primero numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 / num2;

            while (num2==0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
                Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            
            if (num2>0)
            { 
                Console.WriteLine("su resultado es: " + resultado);
            }

            else
            {
                Console.WriteLine("a pasado un error");
            }

            Console.ReadKey();
        }
    }
}