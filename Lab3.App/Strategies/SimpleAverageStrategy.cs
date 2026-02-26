using System.Linq;
using Lab2.App.Models;

namespace Lab2.App.Strategies
{
    public class SimpleAverageStrategy : IAverageStrategy
    {
        public double Calculate(Student s)
        {
            if (s.Grades.Count == 0) return 0;
            return s.Grades.Average();
        }
    }
}