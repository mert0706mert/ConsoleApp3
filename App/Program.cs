using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Mert mert = new Mert();
            mert.FirstName = "Mert";
            string a = "Sokaktan eve gelirken, sokağın ortasında sıkıştım.";
            var result =a.Length;
            var se = a.Clone();
            bool ram = a.EndsWith("ortasında sıkıştım.");
            bool ram2 = a.StartsWith("Sokaktan eve");
            var r1 = a.IndexOf("eve");
            var r2 = a.IndexOf("evi");
            var r3 = a.IndexOf(" ");
            var r4 = a.IndexOf("e");
            var r5 = a.LastIndexOf("e");
            var ere = a.Insert(50," Merhaba!");
            var e2 = a.ToLower();
            var e3 = a.ToUpper();
            var e4 = a.Replace("ı","i");
            var e1 = e4.Substring(41,8);
            var e5 = e4.Remove(0,41);
            
            Console.WriteLine(mert.FirstName);
            Console.WriteLine(a);
            Console.WriteLine(result);
            Console.WriteLine(se);
            Console.WriteLine(ram);
            Console.WriteLine(ram2);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
            Console.WriteLine(ere);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
        }
        class Mert
        {
            public string FirstName;
        }
    }
}
