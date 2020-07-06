using System;

namespace EulerPrimeNumber
{
    class Checker
    {
        private const string EulerNumber = "2.718281828458563411277850606202642376785584483618617451918618203";
        private const int NumberOfDigits = 10;

        public static void FindPrimeNumber()
        {
            string eulerConst = EulerNumber.Replace(".", "");
            string buff;
            long number;
            int pointer = 0;
            do
            {
                buff = eulerConst.Substring(pointer++, NumberOfDigits);

                if (buff[0] == '0')
                    continue;

                number = Convert.ToInt64(buff);

                if (IsPrimeNumber(number))
                {
                    Console.WriteLine("Znaleziona liczba pierwsza:" + number);
                    return;
                }

            } while ((pointer + 10) < eulerConst.Length);

            Console.WriteLine("Nie znaleziono w podanym ciągu liczb pierwszych");
        }

        private static bool IsPrimeNumber(long number)
        {
            if (number == 1) return false;
            double sqrt = Math.Sqrt(number);

            for (int i = 2; i < sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
