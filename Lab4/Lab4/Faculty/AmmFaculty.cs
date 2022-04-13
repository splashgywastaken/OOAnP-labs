using Lab4.TeamFaculty;

namespace Lab4.Faculty;

public class AmmFaculty : IFaculty
{
    private readonly Team _ammTeam;
    
    public AmmFaculty()
    {
        this._ammTeam = new Team("AMM");
    }

    public void Perform()
    {
        Console.WriteLine("AMM faculty performs...");
        _ammTeam.PerformTeam();
    }
}