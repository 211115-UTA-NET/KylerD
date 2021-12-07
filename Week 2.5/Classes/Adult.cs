namespace SampleNamespace
{
    public class Adult : Customer
    {
        public bool dineIn {get; set;} = true;

        public Adult()
        {
            dineIn = true;
        }

        public Adult(bool dineIn, double CashOnHand, string firstName, string lastName) : base (CashOnHand, firstName, lastName)
        {
            this.dineIn = dineIn;
        }

        public void DiningOptions()
        {
            if (dineIn == true)
            {
                Console.WriteLine($"I will be dining in with {CashOnHand}");
            }
            else
            {
                Console.WriteLine($"I will be ordering to go with {CashOnHand}");
            }
        }
    }
}