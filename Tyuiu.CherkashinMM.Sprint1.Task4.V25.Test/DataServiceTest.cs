using Tyuiu.CherkashinMM.Sprint1.Task4.V25.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFormulaValid()
        {
            DataService ds = new DataService();

            Assert.AreEqual(1, ds.Calculate(90));
        }
    }
}