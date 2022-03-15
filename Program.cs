using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededi daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i != 1)
                {
                    m++;
                }
                if (m > 2)
                {
                    Console.WriteLine("murekkebdir");
                }
                else if (m == 1)
                {
                    Console.WriteLine("ne sade ne murekkebdir");
                }
                else
                {
                    Console.WriteLine("sade");
                }
            }
            #region
            //Console.WriteLine("ededi daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int say = 1;
            //while(n>9)
            //{
            //    n /= 10;
            //    say++;
            //}
            //Console.WriteLine(say);
            #endregion

            #region
            //Console.WriteLine("ededi daxil edin:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //if (n > 9)
            //{
            //        rev = rev * 10 + n % 10;

            //        if (rev == n)
            //        {
            //            Console.WriteLine("polindromdur");
            //        }
            //        else
            //        {
            //            Console.WriteLine("polindrom deyil");
            //        }


            //}
            //else
            //{
            //    Console.WriteLine("polindromdur");
            //}
            #endregion
        }
    }
}