"# OOP Lab 3" 
Full Name: Mudar Shawakh
Date: 26.02.2026
Task: 2

Architectural Explanation

In this lab, I used the Strategy Design Pattern to calculate student averages. The main goal was to use Abstraction and Polymorphism to make the code flexible.

Model (Student.cs): This class just holds the student's info. I took out the calculation math to give it just one job to do. The Grades list is left open so the outside strategy classes can read the data.

Interfaces (IAverageStrategy.cs & IStudentService.cs): These basically set the rules. IAverageStrategy makes sure any grading system we create has a Calculate method, meaning the rest of the app doesn't have to depend on specific classes.

The Strategies (SimpleAverageStrategy & DropLowestAverageStrategy): These are two totally different ways to calculate the average. I set them up without changing the main student model or relying on messy if/else blocks.

Service (StudentService.cs): This acts like the middleman. It handles adding the grades and printing out the final report using whichever calculation strategy we pass to it.

Program (Program.cs): The main file is super clean now. There is zero business logic in here—it just uses the interfaces to run the app and show off polymorphism in action.