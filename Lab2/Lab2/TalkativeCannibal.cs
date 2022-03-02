namespace Lab2;

public class TalkativeCannibal : Cannibal
{
    protected override void Catch()
    {
        Console.WriteLine("Разговорчивый людоед поймал добычу");
    }

    protected override void Cook()
    {
        Console.WriteLine("Разговорчивый людоед жарит добычу");
    }

    protected override void Eat()
    {
        Console.WriteLine("Разговорчивый людоед съел добычу");
    }

    protected override void Sleep()
    {
        Console.WriteLine("Разговорчивый людоед уснул");
    }

}