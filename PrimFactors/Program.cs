using DataFactory;
using PrimeFactorGenerator;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["FileInput"];
            try
            {
                List<int> factors = DataFactory.DataFactory.ReadFile(filePath);

                foreach (int factor in factors)
                {
                    List<int> primes = PrimeFactorGenerator.PrimeFactorGenerator.GenerateFactors(factor);
                    string cPrimes = string.Empty;

                    if (primes.Count == 0)
                    {
                        cPrimes += "No Primes for this factor";
                    }
                    foreach (int prime in primes)
                    {
                        cPrimes += String.Format(@"{0},", prime);
                    }

                    string final = string.Format(@"Input = {0} : Primes = {1}", factor, cPrimes.TrimEnd(',')); 
                    Console.WriteLine(final);
                }
            }
            catch (Exception ex)
            {
       
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
