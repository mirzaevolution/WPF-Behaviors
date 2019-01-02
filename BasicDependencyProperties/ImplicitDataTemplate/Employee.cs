using System;

namespace ImplicitDataTemplate
{
    public class Employee
    {
        public Employee() { }
        public Employee(string id, string firstName, string lastName, string job, DateTime dateAccepted)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Job = job;
            this.DateAccepted = dateAccepted;
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public DateTime DateAccepted { get; set; }
    }
}
