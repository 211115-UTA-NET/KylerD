using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            //BaseClass obj;
            //obj = new BaseClass;
            DerivedClass obj;
            obj = new DerivedClass();

            Console.WriteLine(obj.BaseString);
            obj.AbstractMethod();
            Console.WriteLine(obj.BaseString);

            SecondDerived anotherObject;
            anotherObject = new SecondDerived();

            Console.WriteLine(anotherObject.BaseString);
            anotherObject.AbstractMethod();
        }
    }
}
