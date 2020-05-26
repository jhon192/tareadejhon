using System;

namespace par_o_impar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un número entero y diga si es par.
            Console.WriteLine("verificador de numero par o no par");
            int numero;
            Console.Write("Ingrese un primer numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es par");
            }

            else
            {
                Console.WriteLine(numero + " es impar");
            }
        }
    }
}