﻿namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an Argument and called from a method");
            Console.Read();
        }
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}