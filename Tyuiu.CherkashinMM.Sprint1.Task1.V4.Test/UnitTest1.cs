using Tyuiu.CherkashinMM.Sprint1.Task1.V4.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 10;

            Assert.AreEqual(1.1, ds.Calculate(x, y));
        }
    }
}