namespace MyNamespace
{
    class SecondDerived : BaseClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Now for something different");
        }

        // public override string BaseString
        // {
        //     get
        //     {
        //         return _baseString;
        //     }
        // }
    }
}