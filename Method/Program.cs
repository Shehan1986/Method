using System.Security;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 50;
            WriteLine($"Before swaping X: {x}  Y: {y}");
            swap(x, y);
            WriteLine($"After swaping X: {x}  Y: {y}");


            int m = 10;
            int v = 50;
            WriteLine($"Before swaping X: {m}  Y: {v}");
            swapByRef(ref m,ref v);
            WriteLine($"After swaping X: {m}  Y: {v}");


            // this method is used to greet good morning!
            //no param and return type

            greet();

            //this methode isused to geet Welcome to Lexicon!
            //no retun type, pass first name and last name as param

            string fristName = "Shehan";
            string lastName = "Perera";
            greet(fristName, lastName);

            //this method is used to greet a given message
            //no return type, pass f name, l name and message as a param
            string fName = "Shehan";
            string lName = "Perera";
            string message = "Welcom to new world";
            greet(fristName, lastName, message);

            // write a method to calculate an area of circle
            //returns area and takes radius as param

            Write("Enter the value of the radius: ");
            double radiusValue = Convert.ToDouble(ReadLine());
            double result3 = areaCalculation(radiusValue);

            WriteLine($"area of a circle is {result3}");

            //read number from user
            //pass  it to methode
            //return if number positive, negative or zero
            Write("Enter the any number: ");
            double number = Convert.ToDouble(ReadLine());
            string result4 = numberChecker(number);
            WriteLine($"The number is {result4}");


            addNumber();

            int result = addNumber(12, 23);
            WriteLine(result);  

            int num1 = 12;
            int num2 = 34; 
            int result2 = addNumber(num1, num2);
            WriteLine(result2);

            Console.WriteLine(addNumber(num1, num2));


            ReadKey();  
        }

        static void swapByRef(ref int x, ref int y)
        {

            

            int temp = x;
            x = y;
            y = temp;

            WriteLine($"During swaping X: {x}  Y: {y}");
        }

        static void swap(int x, int y)
        {
           
            WriteLine($"Before swaping X: {x}  Y: {y}");

            int temp = x;
            x = y;
            y = temp;

            WriteLine($"After swaping X: {x}  Y: {y}");
        }
        static string numberChecker(double number)
        {
            if (number > 0)
            {
                
                return "Positive";


            }
            else if(number < 0)
            {
                return "Negative";
            }
            else
                return "Zero";

        }

        static double areaCalculation(double radiusValue)
        {
            if (radiusValue > 0)
            {
                // Calculate the area of a circle
                double circleArea = Math.PI * Math.Pow(radiusValue, 2);
                return circleArea;


            }
            else
            {
                return 0;
                WriteLine("Please enter a valid positive number for the radius.");
            }
        }

        static void greet()
        {
            WriteLine("Good Morning!");
        }

        static void greet(string fristName, string lastName)
        {
            WriteLine($"Hi {fristName} {lastName}, Welcome to Lexicon!");
        }

        static void greet(string fristName, string lastName, string message)
        {
            WriteLine($"Hi {fristName} {lastName}, {message}!");
        }

        void addNumber(int num1, int num2, int num3)
        { 
        
        }
        static void addNumber()
        { 
            int x = 10;
            int y = 23;
            int sum = x + y;
            WriteLine(sum);
        }
        static int addNumber(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }
    }
}
