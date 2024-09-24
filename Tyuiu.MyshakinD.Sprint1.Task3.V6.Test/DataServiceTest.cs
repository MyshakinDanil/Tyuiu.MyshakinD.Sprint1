using Tyuiu.MyshakinD.Sprint1.Task3.V6.Lib;
namespace Tyuiu.MyshakinD.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 50;
            double b = 5.5;
            double c = 10;
            var res = ds.TravelCost(a, b, c);
            Assert.AreEqual(55, res);
        }
    }
}