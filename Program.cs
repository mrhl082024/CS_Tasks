using System.Collections.ObjectModel;

namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();

        Fundament fundament = new Fundament();

        fundament.CheckOddOrEven(2);
        
        string fact = "tomater er røde";
        Console.WriteLine(fundament.GetAnInterestingFact(fact));
        
        fundament.SumTwoNumbers(3,6);
     
    }
}
