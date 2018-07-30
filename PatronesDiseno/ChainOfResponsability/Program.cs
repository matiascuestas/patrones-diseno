using ChainOfResponsability.Entities;
using ChainOfResponsability.Merchants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Un vendedor hace una venta y decide si lo puede sacar de su stock, 
            // lo pide al minorista por demanda o al mayorista segun la cantidad pedida
            // stock actual (hasta 10 productos), minorista(hasta 99 productos) o mayorista (100 a 1000 productos), 
            // si tiene mas de 1000 productos se rechaza la venta.       

            // Solo tenemos un objeto Purchase solo con la cantidad y hacemos de cuenta que importa
            // la cantidad y no el producto. Se podria reautilizar la solucion aplicando mas informacion a Purchase.

            Seller seller = new Seller();

            seller.ProcessRequest(new Purchase(10));
            seller.ProcessRequest(new Purchase(90));
            seller.ProcessRequest(new Purchase(131));
            seller.ProcessRequest(new Purchase(1300));
            Console.ReadKey();
        }

    }
}