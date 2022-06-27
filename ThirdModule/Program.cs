using System;

namespace ThirdModule
{
    internal class Program
    {
        enum Semaphore
        {

            Red = 100,
            Yellow = 200,
            Green = 300,
        }
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HavePet = true;
            double FootSize = 37.5;

            Console.WriteLine($"Мое имя {MyName}");
            Console.WriteLine("Мне {0} лет", MyAge);
            Console.WriteLine("Есть ли у меня животное? " + HavePet);
            Console.WriteLine("Мой размер ноги " + FootSize);

           Semaphore ColorSemaphore = Semaphore.Yellow;
            Console.WriteLine(ColorSemaphore);

            Console.ReadKey();

     
        }
    }
        
}

