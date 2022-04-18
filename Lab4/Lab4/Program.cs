using System;
using Lab4.Factory;
using Lab4.Faculty;

namespace Lab4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Faculty.Faculty faculty = CreateFaculty("amm");

            faculty.Prepare();
            faculty.Perform();
        }

        private static Faculty.Faculty CreateFaculty(string faculty)
        {
            return faculty.ToLower() switch
            {
                "amm" => new AmmFaculty(),
                "math" => new AmmFaculty(),
                _ => throw new Exception("Triggered exception: " + faculty + " is unknown faculty")
            };
        }
    }
}