using System;

namespace Lab4.TeamFaculty
{
    public class Singer : ICrewman
    {
        private readonly int _signerNumber;

        public Singer(int signerNumber)
        {
            this._signerNumber = signerNumber;
        }

        public void Perform()
        {
            Console.WriteLine("I'm singer №{0} and I'm singing...", GetNumber());
        }

        public int GetNumber()
        {
            return _signerNumber;
        }
    }
}