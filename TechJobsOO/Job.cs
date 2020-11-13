using System;
using System.ComponentModel;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
       

       

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            

        }

        public Job()
        {
            Id = nextId;
            nextId++;
        }


        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

             string printName; string printEmployer; string printLocation;  string printJobType; string printJobCoreCompetency;


            if (this.Name == null || this.Name == "")
            {
                printName = "Data not available.";
            } 
            
            else
            {
                printName = this.Name;
            }

            if (this.EmployerName.Value == null || this.EmployerName.Value == "")
            {
                printEmployer = "Data not available.";
            }

            else
            {
                printEmployer = this.EmployerName.Value;
            }

            if (this.EmployerLocation.Value == null || this.EmployerLocation.Value == "")
            {
                printLocation = "Data not available.";
            }

            else
            {
                printLocation = this.EmployerLocation.Value;
            }

            if (this.JobType.Value == null || this.JobType.Value == "")
            {
                printJobType = "Data not available.";
            }

            else
            {
                printJobType = this.JobType.Value;
            }

            if (this.JobCoreCompetency.Value == null || this.JobCoreCompetency.Value == "")
            {
                printJobCoreCompetency = "Data not available.";
            }

            else
            {
                printJobCoreCompetency = this.JobCoreCompetency.Value;
            }




            return ("\n" +
                "ID: " + this.Id + "\n" +
                "Name: " + printName + "\n" +
                "Employer: " + printEmployer + "\n" +
                "Location: " + printLocation + "\n" +
                "Position Type: " + printJobType + "\n" +
                "Core Competency: " + printJobCoreCompetency + "\n");


            
        }
    }
}
