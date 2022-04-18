using System;

namespace Lab2
{
    public sealed class SilentCannibal : Cannibal
    {
        protected override void Cook()
        {
            Console.WriteLine("Каннибал варит добычу");
        }

        protected override void Talk()
        {
            Console.WriteLine("Каннибал разговаривает с добычей");
        }
    }
}