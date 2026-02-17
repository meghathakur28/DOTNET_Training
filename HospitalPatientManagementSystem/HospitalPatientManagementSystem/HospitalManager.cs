using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPatientManagementSystem
{
    public  class HospitalManager
    {
        private Dictionary<int, Patient> _patient = new Dictionary<int, Patient>();
        private Queue<Patient> _appointment = new Queue<Patient>();

        public void RegisterPatient(int id, string name, int age, string condition)
        {
            Patient patient  = new Patient(id, name, age, condition);
            _patient.Add(id, patient);
        }
        public void ScheduleAppointment(int patientId)
        {
            Patient patient = _patient[patientId];
            if (patient != null)
            {
                _appointment.Enqueue(patient);
            }
        }
        public Patient ProcessNextAppointment()
        {
            Patient patient = _appointment.Dequeue();
            return patient;
        }

        public List<Patient> FindPatientByCondition(string condition)
        {
            var list = _patient.Where(x => x.Value.Condition == condition).Select(x => x.Value).ToList();
            return list;
        }
    }
}
