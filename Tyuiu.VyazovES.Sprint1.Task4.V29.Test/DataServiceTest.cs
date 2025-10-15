using Tyuiu.VyazovES.Sprint1.Task4.V29.Lib;

namespace Tyuiu.VyazovES.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.57, res);


        }
    }
}
