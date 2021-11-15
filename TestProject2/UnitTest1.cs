using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(int.MinValue, int.MaxValue, int.MinValue + int.MaxValue)]
        [DataRow(5, -1, 3)]
        public void Add_TwoIntegers_ReturnSum(int number1, int number2, int expected)
        {
            //Act
            int result = Add(number1, number2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
    }
}
