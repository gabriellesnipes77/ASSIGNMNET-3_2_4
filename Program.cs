using System.Security.Principal;

namespace ASSIGNMNET_3_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            double num4 = double.Parse(Console.ReadLine());

            double total = num1 + num2 + num3 + num4;
            double average = total / 4;

            Console.WriteLine($"the average of {num1} {num2} {num3} {num4} is: {average}");
            Console.WriteLine($"The total is: {total}");
        }
    }
}













            ///////////////////////////////////////////////////
      //  {
            // Test Data 
        //    double num1 = 10;
        //    double num2 = 15;
          //  double num3 = 20;
        //    double num4 = 30;

            //Call the Function
        //    (double total, double average) = CalculateTotalAndAverage (num1 + num2 + num3 + num4);

            //Display the Results
        //    Console.WriteLine($"First Number: {num1}");
        //    Console.WriteLine($"Second Number: {num2}");
        //    Console.WriteLine($"Third Number: {num3}");
        //    Console.WriteLine($"Fourth Number: {num4}");
        //    Console.WriteLine($"Total: {total}");
        //    Console.WriteLine($"Average: {average}");

  //      }

      //  static (double total, double average) CalculateTotalAndAverage( double n1, double n2, double n3, double n4)
      //  {
      //      double total = n1 + n2 + n3 + n4;
      //      double average = total / 4;
      //      return (total, average);
    //    }
 //    }
//}
