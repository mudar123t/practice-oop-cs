using Lab2.App.Models;

namespace Lab2.App.Strategies
{
    public interface IAverageStrategy
    {
        double Calculate(Student s);
    }
}