using Tyuiu.MyshakinD.Sprint1.Task6.V16.Lib;

namespace Tyuiu.MyshakinD.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string test = "опла!?";
            DataService ds = new DataService();
            var res = ds.CheckSpecSymbols(test);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}