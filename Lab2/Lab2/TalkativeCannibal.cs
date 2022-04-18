using System;

namespace Lab2
{
    public sealed class TalkativeCannibal : Cannibal
    {
        protected override void Cook()
        {
            Console.WriteLine("Каннибал жарит добычу");
        }
    }
}