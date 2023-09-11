using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
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

        }

    }
}
