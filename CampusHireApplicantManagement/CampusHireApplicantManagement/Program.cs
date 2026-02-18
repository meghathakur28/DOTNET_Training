using System;
namespace CampusHireApplicantManagement
{
    public class Program
    {
        public static bool isValidId(string id)
        {
            if(id.Length==8&& id.StartsWith("CH"))
            {
                return true;
            }
            return false;
        }
        public static bool isValidName(string name)
        {
            if(name.Length>=4&&name.Length<=15)
            {
                return true;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Applicant applicant = new Applicant();
            Console.Write("Enter the applicant Id: ");
            string applicantId = Console.ReadLine();

            if(!isValidId(applicantId))
            {
                Console.WriteLine("Invalid Applicant Id");
                return;
            }

            Console.Write("Enter the Applicant Name: ");
            string applicantName = Console.ReadLine();

            if (!isValidName(applicantName))
            {
                Console.WriteLine("Invalid Applicant Name");
                return;
            }

            Console.Write("Enter the Current Location: ");

            Location currloc = Enum.Parse<Location>(Console.ReadLine());

            Console.Write("Enter the Preferred Job Location: ");

            PreferredLocation preloc = Enum.Parse<PreferredLocation>(Console.ReadLine());

            Console.WriteLine("Enter Core Competency: ");

            Core cor = Enum.Parse<Core>(Console.ReadLine());

            Console.WriteLine("Passing Year: ");
            int year = Int32.Parse(Console.ReadLine());
            
            if(year>(int)DateTime.Now.Year)
            {
                Console.WriteLine("Invalid Year");
                return;
            }

            applicant.ApplicantID = applicantId;
            applicant.ApplicantName = applicantName;
            applicant.CurrentLocation = currloc;
            applicant.PreferredJobLocation = preloc;
            applicant.CoreCompetency = cor;
            applicant.PassingYear = year;







        }
    }
}