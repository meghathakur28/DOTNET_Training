using System;
namespace FitnessTrackerAnalysis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Heart Rate Score:");
            double heartRateScore = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Movement Score:");
            double movementScore = Double.Parse(Console.ReadLine());

            double overallIntensity = (heartRateScore * heartRateScore) + (movementScore * movementScore);
            if(overallIntensity>100)
            {
                Console.WriteLine($"Heart Rate Score: {heartRateScore}, Movement Score: {movementScore}");
                return;
            }
            else
            {
                Console.WriteLine($"Overall Intensity: {overallIntensity}");
                return;
            }
        }
    }
}
