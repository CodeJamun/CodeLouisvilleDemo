using System;
namespace AlphabetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Welcome to the Alphabet Project!");

                //Type your name and press enter//

                Console.WriteLine("What is your name?");

                //Create variable and get user input//

                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}");


            }

            //static string CreateAlphabet()
            {
                string alphabet = "";
                for (char alpha = 'A'; alpha <= 'Z'; alpha++)
                {
                    alphabet += alpha;
                }
                Console.Write("Here is the alphabet:");
                Console.WriteLine(alphabet);

                //Pick a Letter//

                Console.WriteLine("What is the first letter in the alphabet?");
                var Letter = Console.ReadLine();


                //Choose how many letters to skip//

                Console.WriteLine("How many letters do you want to skip?");


                var skip = Console.ReadLine();

                //Print the value of the variable//

                Console.WriteLine("You want to start with the letter A ");
                Console.Write($"and choose to skip over every {skip} letter(s)");




                Console.WriteLine("Please verify the number of letters to skip: ");
                string userInput = Console.ReadLine();
                int numberToSkip = int.Parse(userInput);
                string skipOver = AlphabetSkipped(numberToSkip);
                Console.WriteLine("Here is your skipped alphabet:" + skipOver);
                

                {


                }

            }
        }

        private static string AlphabetSkipped(int skip)
        {
            string alphabetSkipped = "";
            for (char alpha = 'A'; alpha <= 'Z';)
            {
                alphabetSkipped += alpha;
                for (int i = 1; i <= skip; i++)
                {
                    alpha++;
                }
            }
            return alphabetSkipped;

        }

        private static string alphabetReversed()
        {
            string alphabetReversed = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabetReversed += alpha;
            }
            return alphabetReversed;

        }
    }
}
