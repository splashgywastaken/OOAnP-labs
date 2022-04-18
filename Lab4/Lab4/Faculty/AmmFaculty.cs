using System;
using System.Collections.Generic;
using Lab4.Factory;
using Lab4.TeamFaculty;

namespace Lab4.Faculty
{
    public class AmmFaculty : Faculty
    {
        private readonly IFactory _ammFactory;

        public AmmFaculty()
        {
            _ammFactory = new AmmFacultyFactory();
            _facultyName = "AMM";
            _dancers = new List<ICrewman>();
            _singers = new List<ICrewman>();
            _leaders = new List<ICrewman>();
        }

        public override void Prepare()
        {
            _leaders.Add(_ammFactory.CreateLeader(1));
            for (int i = 0; i < 2; i++)
            {
                _singers.Add(_ammFactory.CreateSinger(i + 1));
            }
            for (int i = 0; i < 3; i++)
            {
                _singers.Add(_ammFactory.CreateDancer(i + 1));
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