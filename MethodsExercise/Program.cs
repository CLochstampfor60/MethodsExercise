using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

        public static int Divide(int num1, int num2)
        {
            return (num1 / num2);
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

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

            Console.WriteLine("Choose a number:");
            string int1 = Console.ReadLine();

            Console.WriteLine("Choose a another number:");
            string int2 = Console.ReadLine();


        }

    }
}
