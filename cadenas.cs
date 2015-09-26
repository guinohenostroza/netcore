using System;

namespace ConsoleApp1
{
    public class Program
    {
        public void Main(string[] args)
        {
            string message = "Me gusta NET core, quiero probarlo YA!";
            message.Split(' ').ForEach(w => Console.WriteLine(w));
            
        }
    }
}