using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal animal = new Duck();

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
