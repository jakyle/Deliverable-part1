using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberCheck;

namespace MathChallengeTests
{
    [TestClass]
    public class NumberChallengeTests
    {
        

        [TestMethod]
        public void Converts_To_Number_Array()
        {
            NumberChallenge challenge = new NumberChallenge();

            string test1 = "4568462125";
            string test2 = "5568789921";

            int[] intRes1 = challenge.ConvertToNumArry(test1);
            int[] intRes2 = challenge.ConvertToNumArry(test2);

            CollectionAssert.AreEqual(intRes1, new int[] { 4, 5, 6, 8, 4, 6, 2, 1, 2, 5 });
        }

        [TestMethod]
        public void Sums_Numbers_In_Array()
        {
            NumberChallenge challenge = new NumberChallenge();

            int[] num1 = new int[] { 1, 2, 3, 4, 5 };
            int[] num2 = new int[] { 5, 4, 3, 2, 1 };
            int[] newIntArry = challenge.SumNumsArray(num1, num2);

            CollectionAssert.AreEqual(newIntArry, new int[] { 6, 6, 6, 6, 6 });
        }

        [TestMethod]
        public void Are_All_Numbers_Equal()
        {
            NumberChallenge challenge = new NumberChallenge();

            bool isEqual = challenge.AreAllNumsEqual(new int[] { 5, 5, 5, 5, 5, 5 });
            bool isNotEqual = challenge.AreAllNumsEqual(new int[] { 10, 21, 11, 5, 6 });

            Assert.IsFalse(isNotEqual);
            Assert.IsTrue(isEqual);
        }
    }
}
