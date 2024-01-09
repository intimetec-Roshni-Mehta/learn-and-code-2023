using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandC_assignment
{
    public class KaprekarRoutine
    {
        public static int KaprekarStep(int number)
        {
            int[] digits = number.ToString().Select(c => c - '0').ToArray();

            int descNumber = Convert.ToInt32(string.Join("", digits.OrderByDescending(desc => desc)));
            int ascNumber = Convert.ToInt32(string.Join("", digits.OrderBy(asc => asc)));

            int result = descNumber - ascNumber;

            return result;
        }

        public static int PerformKaprekarRoutine(int startingNumber)
        {
            int iterations = 0;
            int currentNumber = startingNumber;

            while (currentNumber != 6174)
            {
                currentNumber = KaprekarStep(currentNumber);
                iterations++;

                if (iterations > 7)
                {
                    throw new InvalidOperationException("Kaprekar's Function did not reach to 6174 within 7 iterations.");
                }
            }

            return iterations;
        }
    }
}
