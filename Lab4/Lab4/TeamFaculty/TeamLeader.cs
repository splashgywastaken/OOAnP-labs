namespace Lab4.TeamFaculty;

public class TeamLeader
{
    private readonly int _numberLeader;

    public TeamLeader(int numberLeader) {
        this._numberLeader = numberLeader;
    }

    public void Perform() {
        Console.WriteLine("I'm the leader №{0} of the event and I'm speaking...", GetNumberLeader());
    }

    public int GetNumberLeader() {
        return _numberLeader;
    }
}