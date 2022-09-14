using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular el descuento por la venta de un artículo.
                Si el producto es importado tendrá un descuento del 10% del precio
                Si el producto es nacional, un 25%
                Mostrar: 
                    Nombre del producto.
                    Precio. 
                    Descuento.
                    Total a pagar*/

            decimal price, dis, total;
            string name, typestr;
            byte type;
            Console.Title = "Calculadora Descuento";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese nombre del producto: ");
            name = Console.ReadLine();
            Console.Write("Ingrese precio del producto: ");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Indique tipo del producto:");
            Console.WriteLine("     1) Nacional");
            Console.WriteLine("     2) Importado");
            Console.Write("              ");
            type = Convert.ToByte(Console.ReadLine());
            if (type == 1)
            {
                dis = (price * 25) / 100;
                typestr = "Nacional";
            }
            else
            {
                dis = (price * 10) / 100;
                typestr = "Importado";
            }
            total = price - dis;
            Console.WriteLine(("").PadRight(Console.WindowWidth,'-'));
            Console.WriteLine("Nombre del producto: {0}", name);
            Console.WriteLine("Precio: {0} Bs.", price);
            Console.WriteLine("Tipo: {0}", typestr);
            Console.WriteLine("Descuento: {0} Bs.", dis);
            Console.WriteLine("Total: {0} Bs.", total);
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
