using Tyuiu.CherkashinMM.Sprint1.Task7.V7.Lib;

namespace Tyuiu.CherkashinMM.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService ds = new DataService();

            double x = 5.0;
            double y = 3.0;
            double wait = -62.776;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}