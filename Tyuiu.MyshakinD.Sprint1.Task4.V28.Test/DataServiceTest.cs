using Tyuiu.MyshakinD.Sprint1.Task4.V28.Lib;

namespace Tyuiu.MyshakinD.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.050;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);
        }
    }
}