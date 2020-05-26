using System;

namespace multiplo_de_4_o_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un número enteros y
             diga si es múltiplo de 4 o de 5.*/
            Console.WriteLine("Verificador del multiplo de 4 o 5");
            int numero, mult4, mult5;
            Console.Write("Ingrese un numero que sea multiplo de 4 o 5: ");
            numero = Convert.ToInt32(Console.ReadLine());
            mult4 = 4;
            mult5 = 5;

            if (numero>=mult4 && numero % mult4 == 0)
            {
                Console.WriteLine(numero +  " es multiplo de " + mult4);
            }
            
            else if (numero>=mult5 && numero % mult5 == 0)
            {
                Console.WriteLine(numero + " es multiplo de " + mult5);
            }

            else
            {
                Console.WriteLine(numero + " no es multiplo de " + mult4 + " ni de " + mult5);
            }

            Console.ReadKey();
        }
    }
}