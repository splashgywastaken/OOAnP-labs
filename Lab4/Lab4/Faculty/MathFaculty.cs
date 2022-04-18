using System;
using System.Collections.Generic;
using Lab4.Factory;
using Lab4.TeamFaculty;

namespace Lab4.Faculty
{
    public class MathFaculty : Faculty
    {
        private readonly IFactory _mathFactory;

        public MathFaculty()
        {
            _mathFactory = new MathFacultyFactory();
            _facultyName = "Math";
            _dancers = new List<ICrewman>();
            _singers = new List<ICrewman>();
            _leaders = new List<ICrewman>();
        }

        public override void Prepare()
        {
            _leaders.Add(_mathFactory.CreateLeader(1));
            for (int i = 0; i < 2; i++)
            {
                _singers.Add(_mathFactory.CreateSinger(i + 1));
            }
            for (int i = 0; i < 3; i++)
            {
                _singers.Add(_mathFactory.CreateDancer(i + 1));
            }
        }

        public override void Perform()
        {
            Console.WriteLine("Math faculty performs...");
            _leaders.ForEach(p => p.Perform());
            _dancers.ForEach(p => p.Perform());
            _singers.ForEach(p => p.Perform());
        }

    }
}