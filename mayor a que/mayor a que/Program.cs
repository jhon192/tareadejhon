using System;

namespace mayor_a_que
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros
             y diga cuál es el mayor de ellos*/
            Console.WriteLine("Verificador de numero mayor");
            int num1, num2;
            Console.Write("Ingrese un primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); // salto de linea
            Console.WriteLine("su resultado es: " + Math.Max(num1, num2)); 
            /*use una funcion de math para ahorrar tiempo*/
            Console.ReadKey();
        }
    }
}