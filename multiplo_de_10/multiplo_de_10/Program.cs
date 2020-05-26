using System;

namespace multiplo_de_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un número entero.
             Si es múltiplo de 10, se lo avisará al usuario y pedirá un segundo número,
             para decir a continuación si este segundo número también es múltiplo de 10.*/
            
            Console.WriteLine("Verificador del multiplo de 10");
            int num1, num2, mult10;
            Console.Write("Introduzca un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            mult10 = 10;
            if (num1>=mult10 && num1 % mult10 == 0) // formula usada para encontrar el multiplo de x numero
            {
                Console.WriteLine(num1 + " es multiplo de " + mult10);
                Console.WriteLine(); // salto de linea
                Console.Write("Introduzca otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2>=mult10 && num2 % mult10 == 0)
                { 
                    Console.WriteLine(num2 + " tambien es multiplo de " + mult10 + " Igual que " + num1);
                }

                else
                {
                    Console.WriteLine(num2 + " no es un multiplo de " + mult10);
                }
            }

            else
            {
                Console.WriteLine(num1 + " no es multiplo de " + mult10);
            }

            Console.ReadKey();
        }
    }
}