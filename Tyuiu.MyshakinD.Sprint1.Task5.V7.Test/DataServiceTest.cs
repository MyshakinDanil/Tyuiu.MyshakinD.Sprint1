using Tyuiu.MyshakinD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.MyshakinD.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double f = 60.0;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);

        }
    }
}