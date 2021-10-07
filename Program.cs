using System;

namespace Grabber
{
    class Program
    {
        private static Config c;
        private static ConfigLoader loader;
        static void Main(string[] args)
        {
            Console.WriteLine("--- Grabber ---");
            Console.WriteLine("Loading Config.");
            loader = new ConfigLoader();
            c = loader.loadConfig("config.grab");
        }

    }
}
