//Namespace
namespace SampleNamespace
{
    //Another Class!
    // AccessModifier class ClassName
    public class Person
    {
        //Fields
        public string firstName {get; set;} = "";
        public string lastName {get; set;} = "";

        //Constructor(s)
        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }

        public Person(string first, string last )
        {
            firstName = first;
            lastName = last;
        }

        //Methods
        // public void setFirstName(string name)
        // {
        //     firstName = name;
        // }

        // public string getFirstName()
        // {
        //     return firstName;
        // }

        // public void setLastName(string name)
        // {
        //     lastName = name;
        // }

        // public string getLastName()
        // {
        //     return lastName;
        // }
 
        //accessModifier returnType methodName(Parameters)
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }
    }
}