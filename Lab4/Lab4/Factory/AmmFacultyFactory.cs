using Lab4.Faculty;
using Lab4.TeamFaculty;

namespace Lab4.Factory
{
    public class AmmFacultyFactory : IFactory
    {
        public ICrewman CreateSinger(int crewmanNumber)
        {
            return
                new Singer(crewmanNumber);
        }

        public ICrewman CreateDancer(int crewmanNumber)
        {
            return
                new Dancer(crewmanNumber);
        }

        public ICrewman CreateLeader(int crewmanNumber)
        {
            return
                new TeamLeader(crewmanNumber);
        }
    }
}