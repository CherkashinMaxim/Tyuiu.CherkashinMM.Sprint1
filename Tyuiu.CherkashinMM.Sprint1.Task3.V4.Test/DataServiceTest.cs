using Tyuiu.CherkashinMM.Sprint1.Task3.V4.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();
            Assert.AreEqual(22.75, ds.Calculate());
        }
    }
}