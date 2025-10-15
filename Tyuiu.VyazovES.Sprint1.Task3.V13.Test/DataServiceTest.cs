using Tyuiu.VyazovES.Sprint1.Task3.V13.Lib;
namespace Tyuiu.VyazovES.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 123;

            double res = ds.MultiplyOfDigits(x);

            Assert.AreEqual(6, res);

        }
    }
}
