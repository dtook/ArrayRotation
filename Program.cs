using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class ArrayOperations
    {
        public void RotateArray(int rotations, string[] sequenceArr)
        {
            int n = 0;
            int m = 0;

            //Create a string to merge the string of arrays
            string merged = "";

            foreach (string str in sequenceArr)
            {
                merged += str;
            }

            //create the char arrays to work with
            char[] charArrTemp = merged.ToCharArray();
            char[] charArr = merged.ToCharArray();

            //initialise the first value so we don't loose it
            int temp = charArrTemp[0];

            for (m = 0; m < rotations; m++)
            {

                for (n = 0; n < charArr.Length - 1; n++)
                {
                    //move each element forward one place
                    charArrTemp[n] = charArr[n + 1];
                }
                //then repeat again to complete teh rotations

                //replace last with first
                charArrTemp[charArr.Length - 1] = charArr[0];

                //make sure temporary array has the new elements
                Array.Copy(charArrTemp, charArr, charArr.Length);
            }

            int length = charArr.Length;

            //display the rotated array
            DisplayRotatedArray(charArrTemp, length);
            

        }

        private void DisplayRotatedArray(char[] charArrTemp, int length)
        {
            int n = 0;

            //Output the rotated sequence
            for (n = 0; n < length; n++)
            {
                Console.WriteLine("Echo Sequence rotated " + charArrTemp[n]);
            }
        }

    }

    class Program
    {
        //static can be called without creating an object for it, void because it will not return a value with no string arguments as parameters
        static void Main()
        {
            //Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.
            //###
            //get string from user and convert to string array

            DebugMon debug = new DebugMon();

            ValVer validate = new ValVer();

            validate.Sequence = "4 3 2 1";

            //reference physicsforums.com
            //int[] sequence = Convert.ToInt32(Console.ReadLine()).ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            Console.WriteLine("Please enter a line of integers seperated by spaces");
            //string sequence = Console.ReadLine();
            //This is a pointless line it is just for testing purposes to understand get/set within a field property.
            string sequence = validate.Sequence;


            //Console.WriteLine("Echo Sequence " + sequence);
            debug.DebugVariable(sequence);
            var sequenceArr = sequence.Split(' ');

            int length = sequenceArr.Length;
            Console.WriteLine("Echo Array Length " + length);
            int n = 0;

            for(n = 0; n < length; n++)
            {
                Console.WriteLine("Echo Sequence now as String Array " + sequenceArr[n]);
            }

            
            //request number of rotations
            Console.WriteLine("How many times would you like to rotate the array to the right?");
            int rotations = 0;
            rotations = Convert.ToInt32(Console.ReadLine());

            if(rotations != 0)
            {
                //intialise constructor for class
                ArrayOperations ops = new ArrayOperations();
                //perform rotations
                ops.RotateArray(rotations, sequenceArr);

                //output state of array after rotations
            }
            else
            {
                Console.WriteLine("You did not enter any rotations.");
            }            
        }
    }
}
