using System.Collections;

namespace Lab4.TeamFaculty;

public class Team
{
    private readonly string _teamTag;
    private const int ValueLeader = 1;
    private List<TeamLeader> _leaders;

    private const int ValueSinger = 2;
    private List<Singer> _singers;

    private const int ValueDancer = 3;
    private List<Dancer> _dancers;
    
    public Team(string teamTag)
    {
        _teamTag = teamTag;

        _leaders = new List<TeamLeader>();
        for (var i = 0; i < ValueLeader; i++)
        {
            _leaders.Add(new TeamLeader(i + 1));
        }

        _singers = new List<Singer>();
        for (var i = 0; i < ValueSinger; i++)
        {
            _singers.Add(new Singer(i + 1));
        }

        _dancers = new List<Dancer>();
        for (var i = 0; i < ValueDancer; i++)
        {
            _dancers.Add(new Dancer(i + 1));
        }
    }

    public void PerformTeam()
    {
        Console.WriteLine("Leader " + _teamTag);
        _leaders.ForEach(p => p.Perform());
        
        Console.WriteLine("Singer " + _teamTag);
        _singers.ForEach(p => p.Perform());
        
        Console.WriteLine("Dancer " + _teamTag);
        _dancers.ForEach(p => p.Perform());
    }
}