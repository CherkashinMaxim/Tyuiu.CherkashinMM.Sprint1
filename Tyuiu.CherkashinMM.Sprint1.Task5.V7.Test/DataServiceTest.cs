using Tyuiu.CherkashinMM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();

            Assert.AreEqual(4, ds.AngleToHoursMinutes(120));
        }
    }
}