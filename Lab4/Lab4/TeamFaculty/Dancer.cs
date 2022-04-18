using System;

namespace Lab4.TeamFaculty
{

    public class Dancer : ICrewman
    {
        private readonly int _dancerNumber;

        public Dancer(int dancerNumber)
        {
            this._dancerNumber = dancerNumber;
        }

        public void Perform()
        {
            Console.WriteLine("I'm dancer №{0} and I'm dancing...", GetNumber());
        }

        public int GetNumber()
        {
            return _dancerNumber;
        }

    }
}