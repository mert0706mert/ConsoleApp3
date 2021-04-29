using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] instanbul = new string[3, 3] { { "A*******************", "Antalya","Ankara" },{ "İ*******************", "İstanbul","İzmir" },{"K*******************","Kırıkkale","Kırklareli"}};
            foreach (var time in instanbul)
            {
                Console.WriteLine(time);
            }
            for (int i = 0; i <= instanbul.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= instanbul.GetUpperBound(1); j++)
                {
                    Console.WriteLine(instanbul[i, j]);
                }
            }
        }
    }
}
