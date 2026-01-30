using System;
using System.Collections.Generic;
using System.Text;

namespace GOAIRSecurity
{
    public class EntityUtility:IUserInterface
    {
        public string employeeID {  get; set; }
        public string entryType { get; set; }
        public int duration {  get; set; }

        public static bool IsValid(string employeeID)
        {
            if (employeeID.Length == 10) { return true; }
            if(employeeID.Contains("GOAIR/"))
            {
                return true;
            }
            return false;
        }
        public bool validateEmployeeID(string employeeID)
        {
            if (IsValid(employeeID)) { return true; }
            throw new InvalidEntryException("The employee ID is not Valid");
        }
        public bool validateDuration(int duration)
        {
            if (duration >= 1 && duration <= 5)
            {
                return true;
            }
            throw new InvalidEntryException("The duration is Invalid. It should be between 1 and 5 (both inclusive) ");
        }
    }
}
