using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple dictionary with ticker symbols and company names in the Main method.
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AA", "American Airlines");
            stocks.Add("MSFT", "Microsoft Corporation");
            stocks.Add("GE", "General Electrics");

            //Create list of ValueTuples that represents stock purchases. Properties will be ticker, shares, price.
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 90, price: 25.25));
            purchases.Add((ticker: "CAT", shares: 95, price: 30.25));
            purchases.Add((ticker: "CAT", shares: 99, price: 35.25));

            purchases.Add((ticker: "AA", shares: 100, price: 26.26));
            purchases.Add((ticker: "AA", shares: 105, price: 31.26));
            purchases.Add((ticker: "AA", shares: 110, price: 36.26));

            purchases.Add((ticker: "MSFT", shares: 125, price: 27.27));
            purchases.Add((ticker: "MSFT", shares: 130, price: 37.27));
            purchases.Add((ticker: "MSFT", shares: 135, price: 35.27));
            /* 
            Define a new Dictionary to hold the aggregated purchase information.
     -      The key should be a string that is the full company name.
    -       The value will be the valuation of each stock (price*amount)

            {
             "General Electric": 35900,
            "AAPL": 8445,
             ...
                }
            */
            Dictionary<string, double> aggrePurchase = new Dictionary<string, double>();
            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value
                if (stocks.ContainsKey(purchase.ticker))
                {
                    if (aggrePurchase.ContainsKey(stocks[purchase.ticker]))
                    {
                        aggrePurchase[stocks[purchase.ticker]] = aggrePurchase[stocks[purchase.ticker]] + purchase.price * purchase.shares;

                    }
                    else
                    {
                        aggrePurchase.Add(stocks[purchase.ticker], purchase.shares * purchase.price);

                    }
                }

              
                

                
            }

            foreach (KeyValuePair<string, double> apurchase in aggrePurchase)
            {
                Console.WriteLine(apurchase);

            }


            Console.ReadLine();

        }
    }
}
