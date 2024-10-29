namespace System;

internal class Program
{ 
   
        public class Student_club
        {

            double budget;


        }

        public class Society
        {

            string name;
            readonly int contract;


            public class FundedSociety
            {
                readonly double fundingAmount;


            }

        }

        public class ClubRole
        {

            string name;
            string role;
            readonly string contract;


        }
    }

    public class Student_club
    {

        double budget;


    }

    public class Society
    {

        string name;
        readonly int contract;


        public class Fund
        {
            readonly double fundingAmount;


        }

    }

public class Club
{

    string name;
    string role;
    readonly string contract;




    private static void Main(string[] args)
    {

        Console.WriteLine("Register a New Society");
        Console.WriteLine("Allocate Funding to Societies");
        Console.WriteLine("Register an Event for a Society");
        Console.WriteLine("Display Society Funding Information");
        Console.WriteLine("Display Events for a Society");
        Console.WriteLine("Exit");
    }
}