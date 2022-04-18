using System.Collections.Generic;
using Lab4.TeamFaculty;

namespace Lab4.Faculty
{
    public abstract class Faculty
    {
        protected string _facultyName;
        protected List<ICrewman> _leaders;
        protected List<ICrewman> _dancers;
        protected List<ICrewman> _singers;

        public abstract void Prepare();

        public abstract void Perform();
    }
}