using System;

namespace multiplo_del_segundo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y
             diga si el primero es múltiplo del segundo*/
            
            Console.WriteLine("verificador del segundo");
            int num1, num2;
            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1>=num2 && num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " es multiplo de " + num2);
            }

            else
            {
                Console.WriteLine(num1 + " no es multiplo de " + num2);
            }

            Console.ReadKey();
        }
    }
}