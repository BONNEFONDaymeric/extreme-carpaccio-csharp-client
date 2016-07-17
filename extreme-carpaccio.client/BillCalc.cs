using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace xCarpaccio.client
{
    class BillCalc
    {
        public Decimal Result { get; set; }
        public BillCalc(Order order)
        {
            var PricesLenght = order.Prices.Length;
            var QuantitesLenght = order.Quantities.Length;
            var lenghtTotal = 0;
            decimal Total = 0;
            decimal Reduc = 0;
            

            CountryExisting CE = new CountryExisting();

            if (PricesLenght == QuantitesLenght) // si le nombre de quantities = au nombre de prices
            {
                lenghtTotal = PricesLenght;
            }
            else if (PricesLenght > QuantitesLenght)
            {
                lenghtTotal = QuantitesLenght;
            }
            else
            {
                lenghtTotal = PricesLenght;
            }

            for (int i = 0; i < lenghtTotal; i++) // Boucle pour chaque paire (quantities / prices)
            {
                var quantitie = order.Quantities[i];
                var price =  order.Prices[i];
                int price2;

                try
                {
                    Total = Total + (price * quantitie);
                }
                catch (Exception)
                {
                    // il y a une erreur,si le "price" ou le "quantitie" n'est pas décimal
                    throw;
                }
                
            }

            for (int i = 0; i < CE.TabCountry.Length; i++) // Boucle qui rajoute une taxe 
            {
                var CountryInTab = CE.TabCountry[i];
                var TaxInTab = CE.TabTax[i];

                if (CountryInTab == order.Country)
                {
                    Total = Total * (TaxInTab + 1);
                }
            }
            
            if (order.Reduction == "STANDARD") // Permet de rajouter une reduction
            {
                if (Total >= 1000 )
                {
                    Total = Total * 0.97m;
                }
                else if (Total >= 5000)
                {
                    Total = Total * 0.95m;
                }
                else if (Total >= 7000)
                {
                    Total = Total * 0.93m;
                }
                else if (Total >= 10000)
                {
                    Total = Total * 0.90m;
                }
                else if (Total >= 50000)
                {
                    Total = Total * 0.85m;
                }
            }
            else if (order.Reduction == "PAY THE PRICE")
            {
                    
            }
            this.Result = Total;
        }
    }
}
