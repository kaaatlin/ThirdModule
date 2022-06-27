using System;

namespace ThirdModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HavePet = true;
            double FootSize = 37.5;

            Console.WriteLine(MyName);
            Console.WriteLine("Мне {0} лет", MyAge);
            Console.WriteLine("Есть ли у меня животное? " + HavePet);
            Console.WriteLine("Мой размер ноги " + FootSize);


            Console.ReadKey();
        }
    }
}
