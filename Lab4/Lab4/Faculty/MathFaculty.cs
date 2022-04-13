using Lab4.TeamFaculty;

namespace Lab4.Faculty;

public class MathFaculty : IFaculty
{
    private readonly Team _mathTeam;
    
    public MathFaculty()
    {
        _mathTeam = new Team("math");
    }

    public void Perform()
    {
        Console.WriteLine("Math faculty performs...");
        _mathTeam.PerformTeam();
    }
    
}