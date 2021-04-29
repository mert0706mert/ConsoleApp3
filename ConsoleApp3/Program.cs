using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 10;
            int c = 14;
            int d = 12;
            int v = 10;
            int r = 14;
            int fe;
            int f1 = 10;
            int f2 = 14;
            var ramo = Mart(ref d, v, r);
            var rema = Murt(a,b,c);
            var rust = Kalk(out fe,f1,f2);
            var result = Mert();
            Console.WriteLine(result);
            Console.WriteLine(rema);
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(Alt(20, 10));
            Console.WriteLine(fe);
            Console.WriteLine(Alt(20,10,15));
            Console.WriteLine(Salt(2,123,23,45,45));
        }
        static void Mirt() 
        {
            Console.WriteLine("tab!!!");
        }
        static int Mert(int a = 12, int b = 23, int c = 43)
        {
            var result = a + b + c;
            return result;
        }
        static int Murt(int a,int b,int c)
        {
            a = 32;
            return a + b + c;
        }
        static int Mart(ref int d, int v, int r)
        {
            d = 32;
            return d + v + r;
        }
        static int Alt(int s, int e)
        {
            var result = s + e;
            return result;
        }
        static int Kalk(out int fe, int f1, int f2)
        {
            fe = 32;
            return fe + f1 + f2;
        }    
        static int Alt(int s, int e,int er)
        {
            var result = s + e + er;
            return result;
        }
        static int Salt(int num,params int[] numbers)
        {
            return numbers.Sum();
        }
    }

}
