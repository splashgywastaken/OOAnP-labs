namespace Lab2;

public abstract class Cannibal
{
    protected abstract void Catch();
    protected abstract void Cook();
    protected abstract void Eat();
    protected abstract void Sleep();

    public void GoThroughDay()
    {
        Catch();
        Cook();
        Eat();
        Sleep();
    } 
}