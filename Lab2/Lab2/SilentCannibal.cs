namespace Lab2;

public class SilentCannibal : Cannibal
{
    protected override void Catch()
    {
        Console.WriteLine("Молчаливый людоед поймал добычу");
    }

    protected override void Cook()
    {
        Console.WriteLine("Молчаливый людоед разговаривает с добычей\nМолчаливый людоед варит добычу");
    }

    protected override void Eat()
    {
        Console.WriteLine("Молчаливый людоед съел добычу");
    }

    protected override void Sleep()
    {
        Console.WriteLine("Молчаливый людоед уснул");
    }
}