using Tyuiu.CherkashinMM.Sprint1.Task6.V16.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();

            Assert.AreEqual(true, ds.CheckSpecSymbols("Да?"));
        }
    }
}