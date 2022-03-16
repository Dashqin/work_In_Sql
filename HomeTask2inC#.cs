using System;

namespace ConsoleApp4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(10)); 
            Console.WriteLine(CalculateArea(5,3));
            Console.WriteLine(CalculateArea(2, 7,8));
        }
        static int CalculateArea(int r)
        {
            //int p=3-ü metodun parametrlərində də verə bilərdik
            //amma 2ci metodun parametrlərinin sayıyla eyni olacağına görə 2ci işləməz
            //onda metodun adın dəyişmək lazım gəlir ki,məsələnin şərtində eyni metod adından istifadə edin deyilib
            int p = 3;
            int S = p * r * r;
            return S;
        }
        
        static int CalculateArea(int a,int b)
        {
            int S = a * b;
            return S;
        }
   
        static int CalculateArea(int a,int b,int c)
        {
            int S = 2 * (a * b + a * c + b * c);
            return S;
        }
    }
}
