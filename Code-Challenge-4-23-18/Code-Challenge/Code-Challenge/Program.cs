using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge
{
    class Program
    {
        /*
        Strings to test:
        racecar
        Racecar
        1221
        never Odd, or Even.
        1231      
        aBc 
        */

        //create an array of chars
        char[] charArray;

        public string Reverse(string s)
        {
            //reverse the characters in the array
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            //create method to see if a method is a Palindrome or not

            //add Strings to a string array
            string[] stringArray = new string[6];

            stringArray[0] = "racecar";
            stringArray[1] = "Racecar";
            stringArray[2] = "1221";
            stringArray[3] = "never Odd, or Even.";
            stringArray[4] = "1231";
            stringArray[5] = "aBc";

            //Print the reverse of the string each string.

            //Compare the newly reversed string with the original string.

            //If the strings match, return True.

            //If the strings do NOT match, return False. 

          
            //test print
            Console.WriteLine("racecar");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
