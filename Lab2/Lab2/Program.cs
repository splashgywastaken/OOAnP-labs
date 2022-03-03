// Два вида людоедов
// Один болтливый, другой молчаливый
// Режим дня:
// Поймали жертву, приготовили, съели, легли спать
// Отличия:
// Первый жарит
// Второй варит, а перед тем разговаривает

using System;

namespace Lab2
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Cannibal talkative = new TalkativeCannibal();
            Cannibal silent = new SilentCannibal();
        
            Console.WriteLine("День разговорчивого каннибала:");
            talkative.GoThroughDay();
            Console.WriteLine();
        
            Console.WriteLine("День молчаливого каннибала:");
            silent.GoThroughDay();
        }
    }
}