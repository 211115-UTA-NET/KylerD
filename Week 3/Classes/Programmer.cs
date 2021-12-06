namespace SampleNamespace
{
    public abstract class Programmer : Person
    {
        protected bool cSharp {get; set;}
        protected bool java {get; set;}
        protected bool python {get; set;}
        protected int level = 0;

        public Programmer()
        {
            cSharp = false;
            java = false;
            python = false;
        }
        public Programmer(bool cSharp, bool java, bool python)
        {
            this.cSharp = cSharp;
            this.java = java;
            this.python = python;
        }
        public Programmer(bool cSharp, bool java, bool python, string firstName, string lastName) : base (firstName, lastName)
        {
            this.cSharp = cSharp;
            this.java = java;
            this.python = python;
        }

        public abstract void ProgrammerResults();
        //public abstract int experienceLevel {get; }
        public virtual int experienceLevel
        {
            get
            {
                return level;
            }
        }
    }
}