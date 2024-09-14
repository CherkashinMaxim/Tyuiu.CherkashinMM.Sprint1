using Tyuiu.CherkashinMM.Sprint1.Task2.V24.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSqareSubsValid()
        {
            DataService ds = new DataService();

            int num1 = 9; int num2 = 5;
            Assert.AreEqual(16, ds.Calculate(num1, num2));
        }
    }
}