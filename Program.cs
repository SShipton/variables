using System;

namespace variables
{
  class Program
  {
    static void Main(string[] args)
    {
      //Cups of coffee I drink daily
      var numberOfCupsOfCoffee = 1;
      //My full name
      var fullName = "Skylar Shipton";
      //Date today
      var today = new DateTime(2020, 05, 12, 14, 47, 56);

      //Printing the above variables on one line
      Console.Write("My name is ");
      Console.Write(fullName);
      Console.Write(", the date today is ");
      Console.Write(today);
      Console.Write(", and I have had ");
      Console.Write(numberOfCupsOfCoffee);
      Console.WriteLine(" cup of coffee");
    
      //Asking the user for their name
      Console.Write("What is your name? ");
      var userName = Console.ReadLine();

      //System output if the user's name is Alice
      if (userName == "Alice") {
      var greetingAlice = $"Hello, {userName}! I hope you are having a wonderful day so far.";
      Console.WriteLine(greetingAlice);
      }
      else {

      //Outputting a greeting
      var greeting = $"It is a pleasure to meet you, {userName}!";
      Console.WriteLine(greeting); }

      //Asking the user for two numbers. I wasn't sure how to ask for
      //two separate numbers in two separate steps without sounding robotic,
      //so I improved and asked for their favorite even and odd numbers
      //to make the text slightly more flavorful.
      Console.Write("Could you please input your favorite even number? ");
      string firstNumberAsString = Console.ReadLine();
      Console.Write("Could you please input your favorite odd number? ");
      string secondNumberAsString = Console.ReadLine();

      double firstOperand = double.Parse(firstNumberAsString);

      double secondOperand = double.Parse(secondNumberAsString);

      //Adding the user-inputted numbers
      double sum = (firstOperand + secondOperand);
      Console.WriteLine($"If you add {firstOperand} and {secondOperand}, you get {sum}");

      //Subtracting the second user-inputted number from the first
      double difference = (firstOperand - secondOperand);
      Console.WriteLine($"If you subtract {secondOperand} from {firstOperand}, you get {difference}");  

      //Multiplying the user-inputted numbers
      double product = (firstOperand * secondOperand);
      Console.WriteLine($"If you multiply {firstOperand} and {secondOperand}, you get {product}");

      //Dividing the first user-inputted number by the second
      double quotient = (firstOperand/secondOperand);
      Console.WriteLine($"If you divide {firstOperand} by {secondOperand}, you get {quotient}");
      
      //Finding the remainder
      double remainder = (firstOperand % secondOperand);
      Console.WriteLine($"If you find the remainder when you divide {firstOperand} by {secondOperand}, you get {remainder}");
      




      
    
    }
  }
}
