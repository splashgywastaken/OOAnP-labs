using Lab4.Faculty;

namespace Lab4.Factory;

public class MathFacultyFactory : IFactory
{
    public IFaculty CreateFaculty()
    {
        return new MathFaculty();
    }
}