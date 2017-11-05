using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we are going to remove all vowels from our string.
            //Then we are to keep only the first, third, fifth, seventh etc... odd letters from the word.
            //We will then print the remaining letters.

            string myString = "LaunchCode";

            //Create new string to manipulate so as to not damage original string.
            string manipulatedString = myString;

            //Convert string to all lower case so as to not have to look for upper and lower case vowels.
            manipulatedString.ToLower();

            //Replace all vowels with empty characters, removing the vowels.
            string noVowelString = manipulatedString.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("y", "");

            //An empty string that will be filled with the first, third, fifth, etc... letters.
            string finalString = "";

            //Looping through the string to find the first, third, fifth, etc... letters.
            for (int i = 0; i < noVowelString.Length; i += 2)

                //Adding the selected letters to the final string.
                finalString = finalString += noVowelString[i];

            //Print the final string.
            Console.WriteLine(finalString);

            Console.ReadLine();
        }
    }
}
