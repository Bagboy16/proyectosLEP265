using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa que lea dos numeros enteros distintos y me diga cuál es el mayor
            int num1, num2, mayor;
            bool igual = false;
            Console.Write("Ingrese primer número: ");
            //num1 = int.Parse(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            //if (num1 > num2)
            //{
            //    mayor = num1;
            //}
            //else
            //{
            //    mayor = num2;
            //}
            if (num1 == num2)
            {
                igual = true;
            } 
            else if (num1>num2) 
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }
            if (igual ==)
            Console.WriteLine("Pulse una tecla para salir...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
