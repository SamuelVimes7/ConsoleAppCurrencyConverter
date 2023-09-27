using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {                      
            Console.WriteLine("Iveskite valiutos pavadinima");
            string tp, ccy, dtFrom, dtTo;
            tp = "LT";
            dtFrom = DateTime.Now.ToString("yyyy-MM-dd");
            dtTo = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                ccy = Console.ReadLine();                
                FxRatesService.FxRatesSoapClient client = new FxRatesService.FxRatesSoapClient();
                var result = client.getFxRatesForCurrency(tp, ccy, dtFrom, dtTo).InnerText;
                Console.WriteLine(result.Remove(0, 19));
                Console.ReadLine();
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Tokio valiutos kodo nera");
                Console.ReadLine();
            }
        }
    }
}
