using Lab4.Factory;
using Lab4.Faculty;

namespace Lab4;

public static class Program
{
    public static void Main(string[] args)
    {
        IFactory facultyFactory = CreateFaculty("math");
        IFaculty faculty = facultyFactory.CreateFaculty();
        
        faculty.Perform();
    }
    
    private static IFactory CreateFaculty(string faculty)
    {
        return faculty.ToLower() switch
        {
            "amm" => new AmmFacultyFactory(),
            "math" => new MathFacultyFactory(),
            _ => throw new Exception("Triggered exception: " + faculty + " is unknown faculty")
        };
    }
}