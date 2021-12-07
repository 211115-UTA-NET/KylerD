
namespace SampleNamespace
{
    class ExperienceLevel : Programmer
    {
        public ExperienceLevel()
        {
            Console.WriteLine("New Object created: No parameters");
        }

        public ExperienceLevel(bool cSharp, bool java, bool python) : base (cSharp, java, python)
        {
            Console.WriteLine("3 bools passed");
        }


        public override void ProgrammerResults()
        {
            if (cSharp == true)
            {
                level = level + 10;
            }
            if (java == true)
            {
                level = level + 10;
            }
            if (python == true)
            {
                level = level + 10;
            }
            
            Console.WriteLine(level);
        }
        public override int experienceLevel
        {
            get
            {
                return level;
            }
        }
    }
}