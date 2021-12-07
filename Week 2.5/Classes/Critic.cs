namespace SampleNamespace
{
    public class Critic : Person
    {
        public int score {get; set;} = 0;

        public Critic(int score)
        {
            score = 0;
        }

        public Critic(string firstName, string lastName) : base (firstName, lastName)
        {
            this.score = score;
        }

        public Critic(int score, string firstName, string lastName) : base (firstName, lastName)
        {
            this.score = score;
        }

        public void myScore()
        {
            Console.WriteLine($"You scored {score}");
            if (score >= 80)
            {
                Console.WriteLine("You have passed");
            }
            else
            {
                Console.WriteLine("You have failed");
            }
        }
    }
}