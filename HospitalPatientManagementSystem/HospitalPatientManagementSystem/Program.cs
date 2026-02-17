using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPatientManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HospitalManager manager = new HospitalManager();
            manager.RegisterPatient(1, "John Doe", 45, "Hypertension");
            manager.RegisterPatient(2, "Jane Smith", 32, "Diabetes");
            manager.ScheduleAppointment(1);
            manager.ScheduleAppointment(2);

            var nextPatient = manager.ProcessNextAppointment();
            Console.WriteLine(nextPatient.Name);

            var diabeticPatients = manager.FindPatientByCondition("Diabetes");
            Console.WriteLine(diabeticPatients.Count);

        }
    }
}
