using Lab4.Faculty;

namespace Lab4.Factory;

public class AmmFacultyFactory : IFactory
{
    public IFaculty CreateFaculty()
    {
        return new AmmFaculty();
    }
}