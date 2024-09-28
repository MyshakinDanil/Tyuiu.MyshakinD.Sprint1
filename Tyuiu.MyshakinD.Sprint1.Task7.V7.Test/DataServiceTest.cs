using Tyuiu.MyshakinD.Sprint1.Task7.V7.Lib;

namespace Tyuiu.MyshakinD.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4.5;
            double y = 3.2;
            var res = Math.Round(ds.Calculate(x, y), 3);
            double wait = -20.706;
            Assert.AreEqual(wait, res);
        }
    }
}