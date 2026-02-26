using Lab2.App.Models;
using Lab2.App.Strategies;

namespace Lab2.App.Services
{
    public interface IStudentService
    {
        void AddGrade(Student student, int grade);
        void PrintStudentReport(Student student, IAverageStrategy strategy);
    }
}