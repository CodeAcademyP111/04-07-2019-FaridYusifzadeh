using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork07._07._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result=  LastIndex("Abdurahman");
            // Console.WriteLine(result);

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeNumbers(number));


        }

        public static int LastIndex(string str)
        {
            int result = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {

                    result = i;
                }
            }
            return result;
        }



        public static bool PrimeNumbers(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }

            return true;
        }

    }
}
