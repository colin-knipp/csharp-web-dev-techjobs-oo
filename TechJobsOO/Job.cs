using System;
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
        public int setId()
        {
            int Id = 22334455;
            
            Id++;

            return Id;
        }

       

        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency)
        {
            setId();
            Name = name;
            EmployerName.Value = employerName;
            EmployerLocation.Value = employerLocation;
            JobType.Value = jobType;
            JobCoreCompetency.Value = jobCoreCompetency;

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

    }
}
