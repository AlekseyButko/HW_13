using System.Reflection;

namespace HW_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = false;
            bool error = false;

            int attemps = 0;
            int maxAttemps = 3;
            do
            {
                Console.WriteLine("Chose operation + | - | * | / |");
                Methods.CalcAction = Console.ReadLine();

                Console.WriteLine("Enter the first value: ");
                string firstValue = Console.ReadLine();

                Console.WriteLine("Enter the second value: ");
                string secondValue = Console.ReadLine();
                try
                {
                    attemps++;
                    Methods.Calc(firstValue, secondValue);
                    success = true;

                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again , please");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Unidentifined error");
                }
            }
            while (!success & !error);
        }


    }
}