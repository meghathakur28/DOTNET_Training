using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CampusHireApplicantManagement
{
    public class ApplicantHiringBL
    {
        public List<Applicant> hiringList = new List<Applicant>();

        public void Display()
        {
            foreach (var i in hiringList)
            {
                Console.WriteLine($"Applicant ID: {i.ApplicantID}, Applicant Name: {i.ApplicantName}, Current Location: {i.CurrentLocation}, Job Location: {i.PreferredJobLocation}, Core Competency: {i.CoreCompetency}, Passing Year: {i.PassingYear}");
            }
        }

        public Applicant SearchApplicantByID(string Id)
        {
            Applicant applicant = hiringList.Find(x=>x.ApplicantID.Equals(Id));
            return applicant;
        }

        public Applicant UpdateApplicantDetails(Applicant applicant)
        {
            Applicant applicant1 = hiringList.Find(x => x.ApplicantID.Equals(applicant.ApplicantID));
            applicant1 = applicant;
            return applicant1;
        }

        public bool DeleteApplicant(Applicant applicant)
        {
            hiringList.Remove(applicant);
            return true;
        }
    }
}
