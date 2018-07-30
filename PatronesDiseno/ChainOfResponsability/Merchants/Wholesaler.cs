using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainOfResponsability.Base;
using ChainOfResponsability.Entities;

namespace ChainOfResponsability.Merchants
{
    public class Wholesaler : Merchant // Mayorista
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount >= 100 && purchase.Amount <= 1000)
            {
                Console.WriteLine("--------------- Detalle de Venta ----------------");
                Console.WriteLine(string.Format("Cantidad de items: {0}", purchase.Amount.ToString()));
                Console.WriteLine("Realizo la venta al mayoristas.");
            }
            else
            {
                ProcessSuccesor(purchase);
            }
        }
    }
}
