//Using statements 

using System;
using System.IO;
using System.Collections.Generic;

//Namespace
namespace SampleNamespace
{
//Class declaration
    class Program
    {
    //function declaration
        public static void Main()
        {
            // Employee Kyler = new Employee(40, 18.50, "Kyler", "Dennis");
            // Kyler.Introduce();
            // Kyler.doWork();

            // Kyler.setPayRate(15.50);
            // Console.WriteLine($"I make {Kyler.getPayRate()} per hour");

            // Trainee Melinda = new Trainee();
            // Melinda.doWork();
            // Melinda.Introduce();
            // Console.WriteLine(Melinda.getInTraining());

            // Customer Howard = new Customer(200, "Howard", "Wen");
            // Howard.Introduce();
            // Console.WriteLine(Howard.CashOnHand);

            // Manager Richard = new Manager("Work together", 40, 25.50, "Richard", "Hawkins");
            // Manager Richard = new Manager("Work together");
            // Richard.Introduce();
            // Richard.doWork();
            // Console.WriteLine(Richard.managersOath);

            // Critic Cooper = new Critic("Cooper", "Dennis");
            // Cooper.Introduce();
            // Cooper.myScore();

            // Adult Daniel = new Adult(true, 20, "Daniel", "Wooten");
            // Daniel.Introduce();
            // Daniel.DiningOptions();

            ExperienceLevel newObject;
            newObject = new ExperienceLevel();
            newObject.ProgrammerResults();

            ExperienceLevel newObject2;
            newObject2 = new ExperienceLevel(true, true, false);
            newObject2.ProgrammerResults();
        }
    }
}