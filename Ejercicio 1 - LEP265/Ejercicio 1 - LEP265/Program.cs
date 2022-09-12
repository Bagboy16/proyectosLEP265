using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___LEP265
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el IVA a pagar por la compra de un artículo dónde el IVA es el 16% del precio del artículo. 
            Mostrar nombre del artículo, el precio unitario, el impuesto, y el total a pagar*/
            decimal impuesto, precioUnitario, total;
            string nombreArticulo;
            Console.Write("Ingrese nombre del artículo: ");
            nombreArticulo = Console.ReadLine();
            Console.Write("Ingrese precio del artículo: ");
            precioUnitario = decimal.Parse(Console.ReadLine());
            impuesto = (precioUnitario * 16) / 100;
            total = precioUnitario + impuesto;
            Console.WriteLine("----------");
            Console.WriteLine("Nombre del artículo: {0}", nombreArticulo);
            Console.WriteLine("Precio unitario: {0} Bs.", precioUnitario);
            Console.WriteLine("IVA: {0} Bs.", impuesto);
            Console.WriteLine("Total a pagar: {0} Bs.", total);
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
