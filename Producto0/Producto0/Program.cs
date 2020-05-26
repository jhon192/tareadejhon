using System;

namespace producto0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que multiplique dos números enteros de la siguiente forma:
             pedirá al usuario un primer número entero.Si el número que se que teclee es 0,
             escribirá en pantalla "El producto de 0 por cualquier número es 0".Si se ha tecleado 
             un número distinto de cero, se pedirá al usuario un segundo número y se mostrará 
             l producto de ambos.*/
            Console.WriteLine("Verificador del Producto 0");
            int num1, num2;
            Console.Write("Ingrese el Primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1>0)
            {
                Console.Write("Ingrese un segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int resultado = num1 * num2;
                Console.WriteLine("su resultado es igual: " + resultado);
            }
            else
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }

            Console.ReadKey();

        }
    }
}