using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentteacherclassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReferenceCountry.countrySoapClient client = new ServiceReferenceCountry.countrySoapClient("countrySoap"))
            {
                string c = client.GetCountries();
                // Console.WriteLine(c);
                string result = client.GetCountryByCountryCode("DK");
                //Console.WriteLine(result);
                string result1 = client.GetCountryByCurrencyCode("DKK");
                //Console.WriteLine(result1);
                string result2 = client.GetCountryByCurrencyCode("BDT");
                //Console.WriteLine(result2);
                string result3 = client.GetCurrencyCodeByCurrencyName("Taka");
                //Console.WriteLine(result3);
                string result4 = client.GetISOCountryCodeByCountyName("Bangladesh");
                Console.WriteLine(result4);
                Console.ReadKey();
            }
        }
    }
}
