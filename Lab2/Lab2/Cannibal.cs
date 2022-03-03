using System;

namespace Lab2
{
    public abstract class Cannibal
    {
        private static void Catch()
        {
            
            Console.WriteLine("Каннибал ловит добычу");
            
        }
        protected abstract void Cook();

        protected virtual void Talk()
        { }

        private static void Eat()
        {
            
            Console.WriteLine("Каннибал ест");
            
        }

        private static void Sleep()
        {
            
            Console.WriteLine("Каннибал спит");
            
        }

        public void GoThroughDay()
        {
            Catch();
            Talk();
            Cook();
            Eat();
            Sleep();
        } 
    }
}