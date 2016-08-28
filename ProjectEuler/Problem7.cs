using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem7
    {
        public double PrimeFinder(int nthToFind)
        {
            List<double> primesSoFar = new List<double>();
            //2 is special case? Either way, seed is useful
            primesSoFar.Add(2);

            //only check those not divisible by 2
            //stop when have found enough
            for (double i = 3; primesSoFar.Count < nthToFind; i = i+2)
            {
                //check through each prime so far
                //if any of the primes is less than the square root of the number being checked
                //and divides the checked number exactly, checked number is not prime
                //if no number fulfils this, checked number is prime - add to list
                var divisible = primesSoFar.Where(p => p <= Math.Sqrt(i)).Where(p => i % p == 0).ToList();
                if(divisible.Count > 0)
                {
                    continue;
                }
                else
                {
                    primesSoFar.Add(i);
                    continue;
                }
            }    

            return primesSoFar.Last();
        }
    }
}
