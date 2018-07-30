using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainOfResponsability.Entities;


namespace ChainOfResponsability.Base
{
    public abstract class Merchant
    {
        public abstract void ProcessRequest(Purchase purchase);

        protected Merchant Successor { get; set; }

        protected void ProcessSuccesor(Purchase purchase)
        {
            if(Successor == null)
            {
                Console.WriteLine("--------------- Detalle de Venta ----------------");
                Console.WriteLine(string.Format("Cantidad de items: {0}", purchase.Amount.ToString()));
                Console.WriteLine("No se puede realizar el pedido.");
            }
            else
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
