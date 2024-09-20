using Tyuiu.CherkashinMM.Sprint1.Task3.V9.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculationValid()
        {
            DataService ds = new DataService();

            Assert.AreEqual(2, ds.ConvertMinutesToHours(150));
        }
    }
}