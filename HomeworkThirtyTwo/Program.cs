using HomeworkThirtyTwo.Library.Models;
using System;

namespace HomeworkThirtyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassModel science = new ClassModel("Science", 3);
            ClassModel math = new ClassModel("Math", 2);

            science.EnrollmentFull += NotifyEnrollmentFull;
            math.EnrollmentFull += NotifyEnrollmentFull;

            science.EnrollStudent("Juan").PrintToConsole();
            science.EnrollStudent("Sanchez").PrintToConsole();
            science.EnrollStudent("Migue").PrintToConsole();
            science.EnrollStudent("Rafael").PrintToConsole();
            science.EnrollStudent("Carlos").PrintToConsole();

            Console.WriteLine("----------------");

            math.EnrollStudent("Sanchez").PrintToConsole();
            math.EnrollStudent("Migue").PrintToConsole();
            math.EnrollStudent("Rafael").PrintToConsole();

            Console.ReadLine();
        }

        private static void NotifyEnrollmentFull(object sender, string e)
        {
            ClassModel subject = (ClassModel)sender;

            Console.WriteLine($">>> {subject.Subject}: {e}");
            Console.WriteLine();
        }
    }
}
