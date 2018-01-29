using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab6PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Input
                Console.WriteLine("Enter a word that you'd like me to translat into pig latin.");
                string word = Console.ReadLine();
                //string sub = word.Substring(0, 1);
                char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                System.Threading.Thread.Sleep(500);
                //var regex =  ^[a-zA-Z0-9]$;
                
                //if ()

                    

                //Console.WriteLine(sub);

                //Processing


                if (word.IndexOfAny(Vowels) == 0)
                {
                    Console.WriteLine(word + "way");
                }
                else
                {

                    int last = word.Length;
                    int x = word.IndexOfAny(Vowels);
                    string Begining = word.Substring(0, x);
                    string middle = word.Substring(x, word.Length - x);
                    Console.Clear();

                    //output
                    Console.WriteLine(middle + Begining + "ay");
                }

                Console.WriteLine("Do you need help translating another word to pig latin? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;

            }

        }

        //public static string
    }
}
