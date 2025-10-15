using Tyuiu.VyazovES.Sprint1.Task5.V6.Lib;

namespace Tyuiu.VyazovES.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);


        }
    }
}
