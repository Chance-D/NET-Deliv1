using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello,{userName} welcome to our new world \n");
            string secondOption = "";
            do
            {

            Console.WriteLine("Please input a measurement type select\n" +
            "I: for inches \n" +
            "F: for foot \n"+
            "FS: for fidget spinners \n" +
            "M: for memes");

            Console.WriteLine("Enter measurement type: ");
            string userMeasurement = Console.ReadLine();
            //var numOne = (Double.Parse(userMeasurement));

            Console.WriteLine("Input a value");
            string userValue = Console.ReadLine();
            var numTwo = (Double.Parse(userValue));
            var result = 0.0;
            

            if (userMeasurement == "I")
            {
                // Convert value from inches to fidget spinners
                result = numTwo * 3.5;
                Console.WriteLine($"Input value: {numTwo} inches \n" +
                    $"Result: {result} fidget spinners \n");
            }
            else if (userMeasurement == "F")
            {
                // Convert from feet to memes
                result = numTwo * 5;
                Console.WriteLine($"Input value: {numTwo} feet \n" +
                    $"Result: {result} memes \n");
            }
            else if (userMeasurement == "FS")
            {
                // Convert to fidget spinners
                result = numTwo / 3.5;
                Console.WriteLine($"Input value: {numTwo} fidget spinners \n" +
                     $"Result: {result} inches \n");
            }
            else if (userMeasurement == "M")
            {
                // Convert from memes to feet
                result = numTwo /5.0;
                Console.WriteLine($"Input value: {numTwo} memes \n" +
                     $"Result: {result} feet \n");
            }
            else
            {
                // Print an error message if needed 
                Console.WriteLine("ERROR! Please enter valid measurement type");

            };

            // Ask if you wnat second conversion 
            Console.WriteLine("Would you like continue One more time? \n" +
                "Select Y : For Yes \n" +
                "select N : For No");
                secondOption = Console.ReadLine();
            } while (secondOption == "Y");

            Console.WriteLine($" Thanks {userName} for playing today!");










            // Request user measurement type
            //Console.WriteLine("Enter measurement type");

            // Read user input
            //string measurementType = Console.ReadLine();

            // Request value
            //Console.WriteLine("Enter Amount");

            // Read value to be converted
            //string amount = Console.ReadLine();
            // Convert to integer
            //int value = Convert.ToInt32(amount);


        }
    }
}
