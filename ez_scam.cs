using System;
using System.Threading;
using System.Text;

    class Program {
        public static void Main(string[] args) // public and args[]
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("AMAZON GC GENERATOR + CHECKER");
            int i = 0;
            Console.WriteLine("Checking hwid ");
            Thread.Sleep(2000);
            Console.WriteLine("Checking for updates ");
            Console.WriteLine(". ");
            Console.WriteLine(". ");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            string text = "ABCDEFGHIJKLMNOPQRSTUVZ0123456789123456789";
            Random random = new Random();
            checked
            {
                while (i <= 10)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    int num = 1;
                    do
                    {
                        int startIndex = random.Next(0, 35);
                        stringBuilder.Append(text.Substring(startIndex, 1));
                        num++;
                    }
                    while (num <= 16);
                    Console.WriteLine(stringBuilder.ToString() + " NOT VALID GIFTCARD");
                    Thread.Sleep(700);
                    //MyProject.Computer.Network.Ping("www.asos.com", 1000);
                }
                Console.ReadKey();
            }
        }
    }
