using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainOfResponsability.Base;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Merchants
{
    public class Seller : Merchant  // Vendedor
    {
        public Seller() => Successor = new Retailer();

        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Amount <= 10)
            {
                Console.WriteLine("--------------- Detalle de Venta ----------------");
                Console.WriteLine(string.Format("Cantidad de items: {0}", purchase.Amount.ToString()));
                Console.WriteLine("Realizo la venta directamente.");
            }
            else
            {
                ProcessSuccesor(purchase);
            }
        }
    }
}
