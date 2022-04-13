namespace Lab4.TeamFaculty;

public class Dancer
{
    private readonly int _dancerNumber;

    public Dancer(int dancerNumber)
    {
        this._dancerNumber = dancerNumber;
    }

    public void Perform()
    {
        Console.WriteLine("I'm dancer №{0} and I'm dancing...", GetNumberDancer());
    }

    public int GetNumberDancer()
    {
        return _dancerNumber;
    }
    
}