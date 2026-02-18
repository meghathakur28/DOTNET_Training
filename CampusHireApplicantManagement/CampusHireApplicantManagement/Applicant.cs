using System;
using System.Collections.Generic;
using System.Text;

namespace CampusHireApplicantManagement
{
    public enum Location { Mumbai, Pune, Chennai}
    public enum PreferredLocation { Mumbai, Pune, Chennai, Delhi, Kolkata, Bangalore}

    public enum Core { NET, JAVA, ORACLE, TESTING}
    public class Applicant
    {
        public string ApplicantID { get; set; }
        public string ApplicantName { get; set; }
        public Location CurrentLocation { get; set; }
        public PreferredLocation PreferredJobLocation {  get; set; }

        public Core CoreCompetency {  get; set; }

        public int PassingYear {  get; set; }

    }
}
