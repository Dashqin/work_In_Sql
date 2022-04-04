using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            AZN azn = new AZN(100);
            USD usd = new USD(200);
            EUR eur = new EUR(170);
            Console.WriteLine(eur>usd);
            Console.WriteLine(eur<usd);
            Console.WriteLine(eur>azn);
            Console.WriteLine(usd>azn);
            Console.WriteLine(eur>azn);
            Console.WriteLine(usd<azn);
        }
        public class USD
        {
            public double Amount { get; set; }
            public USD(double Amount)
            {
                this.Amount = Amount;
            }
            public static implicit operator USD(EUR eur)
            {
                return new USD(eur.Amount * 1.10);
            }
            public static implicit operator EUR(USD usd)
            {
                return new EUR(usd.Amount / 1.10);
            }
            public static bool operator <(USD usd, EUR eur)
            {
                return usd.Amount < eur.Amount;
            }
            public static bool operator >(USD usd,EUR eur)
            {
                return usd.Amount > eur.Amount;
            }

        } 
        public class AZN
        {
            public double Amount { get; set; }
            public AZN(double Amount)
            {
                this.Amount = Amount;
            }
            public static implicit operator AZN(USD usd)
            {
                return new AZN(usd.Amount*1.7);
            }
            public static implicit operator AZN(EUR eur)
            {
                return new AZN(eur.Amount * 1.87);
            }
            public static implicit operator USD(AZN azn)
            {
                return new USD(azn.Amount / 1.7);
            }
            public static implicit operator EUR(AZN azn)
            {
                return new EUR(azn.Amount / 1.87);
            }
            public static bool operator >(USD usd, AZN azn)
            {
                return usd.Amount > azn.Amount;
            }
            public static bool operator <(USD usd, AZN azn)
            {
                return usd.Amount < azn.Amount;
            }
            public static bool operator >(EUR eur, AZN azn)
            {
                return eur.Amount > azn.Amount;
            }
            public static bool operator <(EUR eur, AZN azn)
            {
                return eur.Amount < azn.Amount;
            }
        }
        public class EUR
        {
            public double Amount { get; set; }
            public EUR(double Amount)
            {
                this.Amount = Amount;
            }
        }
    }
}
