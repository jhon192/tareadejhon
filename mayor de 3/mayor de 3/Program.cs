using System;

namespace mayor_de_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario tres números reales y
             muestre cuál es el mayor de los tres.*/
            Console.WriteLine("Verficador de mayor");
            int num1, num2, num3;
            Console.Write("Ingrese Su primero numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Su Segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Su Tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("El mayor es: " + num1);
            }
            
            else if (num2>num1 && num2>num3)
            {
                Console.WriteLine("El mayor es: " + num2);
            }
            
            else if (num3>num2 && num3>num1)
            {
                Console.WriteLine("El mayor es: " + num3);
            }

            else
            {
                Console.WriteLine("Dos o Todos son iguales");
            }

            Console.ReadKey();
        }
    }
}