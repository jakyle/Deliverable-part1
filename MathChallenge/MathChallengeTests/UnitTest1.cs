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

            int[] intRes1 = challenge.ConvertToNumArry("4568462125");

            CollectionAssert.AreEqual(intRes1, new int[] { 4, 5, 6, 8, 4, 6, 2, 1, 2, 5 });
        }

        [TestMethod]
        public void Sums_Numbers_In_Array()
        {
            NumberChallenge challenge = new NumberChallenge();

            int[] newIntArry = challenge.SumNumsArray(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 });

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
