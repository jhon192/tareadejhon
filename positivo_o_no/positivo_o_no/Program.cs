using System;


namespace positivo_o_no
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es
             positivo", "Los dos números son positivos" o bien "Ninguno de los números es positivo",
              según corresponda*/
            
            Console.WriteLine("Verificador de positivos");
            int num1, num2;
            Console.Write("Ingrese Un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1>0 && num2<0 || num1<0 && num2>0)
            {
                Console.WriteLine("Uno de los numeros es positivos");
            }
            
            else if (num1>0 && num2>0)
            {
                Console.WriteLine("Los dos numeros son positivos");
            }

            else
            {
                Console.WriteLine("Ningunos de los numeros son positivos");
            }

            Console.ReadKey();
        }
    }
}