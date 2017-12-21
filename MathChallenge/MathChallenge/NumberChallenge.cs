using System;


namespace NumberCheck
{
    // I purposely chose not to have any values in my class to practice with just pure functions in my Class.
    public class NumberChallenge
    {
        // I wanted all of my functions to be Pure for easier unit testing, also I wanted
        // to keep the methods as lean as possible
        // 
        public int[] ConvertToNumArry(string userInput)
        {
            char[] letters = userInput.ToCharArray();
            int[] convertArry = new int[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                // found this method to convert a char which is UTF-16 to 32-bit
                // if not, the number would be larger and thus inacurrate
                convertArry[i] = (int)Char.GetNumericValue(letters[i]);
            }
            return convertArry;
        }

        // I wanted to add all values in the array so I could compare them all later
        public int[] SumNumsArray(int[] num1, int[] num2)
        {
            int[] newNum = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                newNum[i] = num1[i] + num2[i];
            }
            return newNum;
        }

        // since all numbers are supposed to be the same number, I thought it would be easy just to 
        // store one of the elements in a new var and use that as the base comparison.
        public bool AreAllNumsEqual(int[] numArry)
        {
            int compareNum = numArry[0];
            for (int i = 0; i < numArry.Length; i++)
            {
                // if the sampled number, which is the index 0 of the combined array, 
                // does NOT equal any of the other indexes of the combined array, we return
                // a false bool, which I will use to display a false message. 
                if (compareNum != numArry[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
