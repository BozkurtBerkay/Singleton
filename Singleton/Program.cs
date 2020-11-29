using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDeneme singleton = SingletonDeneme.GetSingleton();
            singleton.title = "Canberk";
            Console.WriteLine(singleton.id.ToString()+" "+singleton.title);

        }
    }
} 