using System;
using System.Text.RegularExpressions;

namespace Regularexp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Task 2a Find all of the occurrences of the letter 'd' or 'e'
            Console.WriteLine("\n************* Task 2a d or e ************************");
            string pattern = @"[d-e]";
            string input = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }
            // ****************************************************************
            // 2b Find all of the occurrences of the letter ‘d’ or’ e’, followed by another ‘d’

            Console.WriteLine("\n************* Task 2b d or e followed by d again ************************");
            string pattern2b = @"[d-e][d]";
            string input2b = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            RegexOptions options2b = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input2b, pattern2b, options2b))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // ****************************************************************
            // 2c  Find all of the occurrences of the letter ‘a’, followed by any letter, then the letter ‘a’ again

            Console.WriteLine("\n************* Task 2c a followed by a letter then a again ************************");
            string pattern2c = @"[a][a-z][a]";
            //string input2c = @"Episode IV, A NEW HOPE It is a period of civil war. Rebel spaceships, striking from a hidden base, have won their first victory against the evil Galactic Empire. During the battle, Rebel spies managed to steal secret plans to the Empire’s ultimate weapon, the DEATH STAR, an armored space station with enough power to destroy an entire planet. Pursued by the Empire’s sinister agents, Princess Leia races home aboard her starship, custodian of the stolen plans that can save her people and restore freedom to the galaxy….";
            //RegexOptions options2c = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern2c, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // ****************************************************************
            // 2d  Find all of the words that start with the letter “p”

            Console.WriteLine("\n************* Task 2d  starts with p ************************");
            string pattern2d = @"[ ][p][a-z]";
            foreach (Match m in Regex.Matches(input, pattern2d, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            // ****************************************************************
            // 2e  Find all of the words that end with the letter e

            Console.WriteLine("\n************* Task 2e  Ends with e ************************");
            string pattern2e = @"[a-z][e][ ]";
            foreach (Match m in Regex.Matches(input, pattern2e, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }



            // ****************************************************************
            // 2f  Find all of the capital letters

            Console.WriteLine("\n************* Task 2f Capital letters ************************");
            string pattern2f = @"[A-Z]";
            foreach (Match m in Regex.Matches(input, pattern2f, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }


        }
    }
}
