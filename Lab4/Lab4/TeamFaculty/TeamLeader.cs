using System;

namespace Lab4.TeamFaculty
{
    public class TeamLeader : ICrewman
    {
        private readonly int _numberLeader;

        public TeamLeader(int numberLeader)
        {
            this._numberLeader = numberLeader;
        }

        public void Perform()
        {
            Console.WriteLine("I'm the leader №{0} of the event and I'm speaking...", GetNumber());
        }

        public int GetNumber()
        {
            return _numberLeader;
        }
    }
}