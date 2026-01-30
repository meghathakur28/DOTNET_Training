using System;
namespace InterfaceM2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Exam Details:");
            Console.Write("Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Questing Type (MCQ/Coding):");
            string questionType = Console.ReadLine();
            Console.Write("Total Questions:");
            int totalQuestion = Int32.Parse(Console.ReadLine());
            Console.Write("Correct Answer:");
            int correctAnswers = Int32.Parse(Console.ReadLine());
            Console.Write("Wrong Answer:");
            int wrongAnswers = Int32.Parse(Console.ReadLine());

            OnlineTest test = new OnlineTest(name,totalQuestion,correctAnswers,wrongAnswers,questionType);

            Console.WriteLine("Exam Summary: ");
            Console.WriteLine($"{test.questionType} Test: {test.studentName},Total Score: {test.calculateScore()}, Result: {test.evaluateResult(test.calculateScore())}");
        }
    }
}
