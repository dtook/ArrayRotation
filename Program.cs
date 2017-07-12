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
            //move each element of array to the right as per rotations
            int n = 0;
            int mv = 0;
            int length = sequenceArr.Length;

            for (n = 0; n < length; n++)
            {
                Console.WriteLine("Echo Sequence now as String Array " + sequenceArr[n]);
            }

            //rotate by moving the last element value of the array to the first point in the temp array
            //keep doing that for the number of rotations

            //char[] tempCharArr = sequenceArr.ToString().ToCharArray();

            //length = tempCharArr.Length;

            //for (n = 0; n < length; n++)
            //{
            //    Console.WriteLine("Echo Sequence now as Char Array " + tempCharArr[n]);
            //}

            //merge the string array
            string merged = "";
            
            foreach (string str in sequenceArr)
            {
                merged += str;
            }

            //convert the merged array to char array
            merged.ToCharArray();

            //debug char array
            //for (n = 0; n < length; n++){Console.WriteLine("Echo Sequence now as Char Array " + merged[n]);}

            //store first char in array
            int length2 = sequenceArr.Length;
            char tempArrEl1 = merged[1];
            char tempArrElx = merged[length2];

            //move each element forward one in the array
            //..then restart
            char[] charArrayTemp = merged;



            int n2;

            for (n2 = 1; n < rotations; n++)
            {
                tempArrEl1 = merged[1];
                tempArrElx = merged[2];

                sequenceArr[tempArrEl1] = sequenceArr[tempArrElx];

            }



            //string[] tempArray = sequenceArr;

            //for(n=0; n < rotations; n++)
            //{
            //    tempArray[n] = sequenceArr.ElementAt(mv++);
                
            //}

            for (n = 0; n < length; n++)
            {
                Console.WriteLine("Echo Sequence rotated " + sequenceArr[n]);
            }

        }

        public void DisplayRotatedArray()
        {

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

            //reference physicsforums.com
            //int[] sequence = Convert.ToInt32(Console.ReadLine()).ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            string sequence = Console.ReadLine();
            Console.WriteLine("Echo Sequence " + sequence);
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
            int rotations = Convert.ToInt32(Console.ReadLine());

            //intialise constructor for class
            ArrayOperations ops = new ArrayOperations();
            //perform rotations
            ops.RotateArray(rotations, sequenceArr);

            //output state of array after rotations
        }
    }
}
