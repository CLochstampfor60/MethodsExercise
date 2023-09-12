using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        //Exercise 1 STARTS here
        private static void Main(string[] args)
        {
          
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
              
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            
            Console.WriteLine("What is your favoite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite vacation destination?");
            string favVacation = Console.ReadLine();
            
            Console.WriteLine("What is your favorite type of music?");
            string favMusic = Console.ReadLine();
            
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"{yourName} visited {favVacation} earlier this year. The spot had some of the best {favMusic} in the city. In fact, {favBand} was scheduled to play too. Unfortunately, the {favVacation} was terrorized by a giant {favAnimal}. {favBand} was trampled and eaten alive by the giant {favAnimal}. It was a sad day: after the horrendous event, it began to rain {favColor}. It was as if the heavens were mourning over the tragic loss.");
            //Exercise 1 ENDS here

            // *******

            // Exercise 2 STARTS here
            Console.WriteLine("Please provide a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide a number to add to the prior number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);  
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Please provide a number to subtract");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide a number to subtract");
            int y = int.Parse(Console.ReadLine());
        }
        public static int Sum (int num1, int num2) { 
          return num1 + num2; }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int a, int b)
        {
            return (a * b);
        }

        public static int Divide(int c, int d)
        {
            return (c / d);
        }

        public static int Modulus(int e, int f)
        {
            return e % f;
        }
        // Exercise 2 ENDS here
    }
}
