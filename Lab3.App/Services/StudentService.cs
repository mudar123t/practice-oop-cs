using System;
using Lab2.App.Models;
using Lab2.App.Strategies;

namespace Lab2.App.Services
{
    public class StudentService : IStudentService
    {
        public void AddGrade(Student student, int grade)
        {
            student.AddGrade(grade);
        }

        public void PrintStudentReport(Student student, IAverageStrategy strategy)
        {
            // The service relies on the interface contract to get the calculation
            double average = strategy.Calculate(student);
            Console.WriteLine($"Student: {student.Name} | Strategy: {strategy.GetType().Name} | Average = {average:F2}");
        }
    }
}