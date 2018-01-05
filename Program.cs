using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("AAPL", "Apple, Inc.");
                stocks.Add("GOOG", "Google");
                stocks.Add("TSLA", "Tesla");
                stocks.Add("BAMXF", "BMW");

                List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

                purchases.Add((ticker: "GM", shares: 150, price: 23.21));
                purchases.Add((ticker: "GM", shares: 32, price: 17.87));
                purchases.Add((ticker: "GM", shares: 80, price: 19.02));
                purchases.Add((ticker: "CAT", shares: 100, price: 23.21));
                purchases.Add((ticker: "CAT", shares: 38, price: 17.87));
                purchases.Add((ticker: "CAT", shares: 22, price: 19.02));
                purchases.Add((ticker: "AAPL", shares: 120, price: 137.21));
                purchases.Add((ticker: "AAPL", shares: 30, price: 137.87));
                purchases.Add((ticker: "AAPL", shares: 40, price: 137.02));
                purchases.Add((ticker: "GOOG", shares: 45, price: 230.21));
                purchases.Add((ticker: "GOOG", shares: 67, price: 230.87));
                purchases.Add((ticker: "GOOG", shares: 143, price: 230.02));
                purchases.Add((ticker: "TSLA", shares: 55, price: 20.02));
                purchases.Add((ticker: "TSLA", shares: 23, price: 20.02));
                purchases.Add((ticker: "TSLA", shares: 42, price: 20.02));
                purchases.Add((ticker: "BAMXF", shares: 22, price: 19.02));
                purchases.Add((ticker: "BAMXF", shares: 130, price: 19.02));
                purchases.Add((ticker: "BAMXF", shares: 40, price: 19.02));

                    
                // double final = 0;
            
            Dictionary<string, double> co = new Dictionary<string, double>();

                    foreach ((string ticker, int shares, double price) purchase in purchases)
                        {
                        string company = stocks[purchase.ticker];
                        double total = purchase.shares * purchase.price;
                        if (!co.ContainsKey(company)) {
                            co.Add(company, total);
                        } else {
                            co[company] += total;
                        }
                        
                        Console.WriteLine(co);
                        }
                foreach(KeyValuePair<string, double> details in co) {
                    Console.WriteLine("{0}, {1}", details.Key, details.Value);
                }
                
        }
        
    }
}
