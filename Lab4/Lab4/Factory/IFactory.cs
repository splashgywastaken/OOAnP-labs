using Lab4.Faculty;
using Lab4.TeamFaculty;

namespace Lab4.Factory
{
    public interface IFactory
    {
        public ICrewman CreateSinger(int crewmanNumber);
        public ICrewman CreateDancer(int crewmanNumber);
        public ICrewman CreateLeader(int crewmanNumber);
    }
}