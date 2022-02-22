using System;

namespace AbstractExample.Models
{
    internal class Duck : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("quack quack");
        }

        public override void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzz...");
        }
    }
}
