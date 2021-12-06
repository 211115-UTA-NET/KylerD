namespace SampleNamespace
{
    public class Manager : Employee
    {
        public string managersOath {get; set;} = "Lead by example";

        public Manager(string managersOath)
        {
            this.managersOath = managersOath;
        }
        public Manager(string managersOath, int HoursWorked, double PayRate, string firstName, string lastName) : base(HoursWorked, PayRate, firstName, lastName)
        {
            this.managersOath = managersOath;
        }
    }
}