namespace SampleNamespace
{
    public class Employee : Person
    {
        private int HoursWorked;
        private double PayRate;

        //Constructor
        public Employee()
        {
            this.HoursWorked = 20;
            this.PayRate = 10.50;
        }

        public Employee(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;
        }

        public double getPayRate()
        {
            return PayRate;
        }

        public void setPayRate(double PayRate)
        {
            this.PayRate = PayRate;
        }

        public void doWork()
        {
            Console.WriteLine($"I've worked {HoursWorked} hours.");
            Console.WriteLine($"I make ${PayRate} dollars per hour");
            double paycheck = PayRate * HoursWorked;
            Console.WriteLine($"This week I made ${paycheck}");
        }
    }
}