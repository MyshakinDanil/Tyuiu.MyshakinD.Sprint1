using Tyuiu.MyshakinD.Sprint1.Task2.V8.Lib;
namespace Tyuiu.MyshakinD.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4; int y = 5;
            var res = ds.CalculatePerimetr(x, y);
            Assert.AreEqual(18, res);
        }
    }
}