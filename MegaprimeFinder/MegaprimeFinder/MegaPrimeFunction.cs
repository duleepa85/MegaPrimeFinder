using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaprimeFinder
{
    public class MegaPrimeFunction
    {
        /// <summary>
        /// This function will take max as a 32-bit unsigned integer param and return a list of mega prime numbers from 1 to max inclusive
        /// </summary>
        /// <param name="max"></param>
        /// <returns>List<uint></returns>
        public static List<uint> GetMegaPrimeList(uint max)  //32 bit unsigned integer range = 0 to 2^32-1 = 0 to 4294967295
        {
            List<uint> megaPrimeList = new List<uint>();
            try
            {
                if (max == 0 || max == 1) { return megaPrimeList; }
                megaPrimeList.Add(2);
                for (uint i = 3; i <= max; i += 2)
                {
                    if (CheckDigits(i) && IsPrime(i)) //If CheckDigits(i) = true only it will check for IsPrime(i). If both conditions are satisfied only, "i" is a mega prime
                    {
                        megaPrimeList.Add(i);
                    }
                }
            }
            catch(Exception)
            { 
                throw; 
            }
            return megaPrimeList;
        }

        /// <summary>
        /// This function will check whether individual digits are prime in the given integer  
        /// </summary>
        /// <param name="n"></param>
        /// <returns>boolean</returns>
        public static bool CheckDigits(uint n)
        {
            while(n > 0)
            {
                uint digit = n % 10;
                if(digit != 2 && digit != 3 && digit != 5 && digit != 7)
                    return false;

                n /= 10;
            }
            return true;
        }

        /// <summary>
        /// This function will check whether the given integer is prime or not
        /// </summary>
        /// <param name="n"></param>
        /// <returns>boolean</returns>
        public static bool IsPrime(uint n) 
        { 
            if(n == 0) return false;

            double dblSqrt = Math.Sqrt(n); // No point of going beyond square root since there wont be any devisors after that. 
            uint sqrt = (uint)Math.Floor(dblSqrt); 

            for (uint i = 3; i <= sqrt; i += 2)
            {
                if(n % i == 0) return false;
            }
            return true;
        }

    }
}
