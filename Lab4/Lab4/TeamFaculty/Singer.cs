namespace Lab4.TeamFaculty;

public class Singer
{
    private readonly int _signerNumber;

    public Singer(int signerNumber)
    {
        this._signerNumber = signerNumber;
    }

    public void Perform()
    {
        Console.WriteLine("I'm singer №{0} and I'm singing...", GetNumberSigner());
    }

    public int GetNumberSigner()
    {
        return _signerNumber;
    }
}