using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fizzBuzz = new FizzBuzz();
                Console.WriteLine("Podaj liczbę : ");


                while (true)
                {
                    int userNumber = GetNumber();

                    string result = fizzBuzz.GetInfo(userNumber);

                    Console.WriteLine(result);

                    Console.WriteLine("Aby wyjść z gry naciśnij przycisk 'N'");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();

            }
        }

        private static int GetNumber()
        {
            while (true)
            {
                var userDecision = Console.ReadLine();

                if (userDecision.ToUpper() == "N")
                    Environment.Exit(0);

                if (!int.TryParse(userDecision, out int input))
                {
                    Console.WriteLine("Podana wartość nie jest prawidłowa");
                    continue;
                }

                return input;

            }
        }
    }
}
