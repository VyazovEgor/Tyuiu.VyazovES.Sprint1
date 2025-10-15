using Tyuiu.VyazovES.Sprint1.Task2.V14.Lib;

namespace Tyuiu.VyazovES.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]

        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 1;

            int res = ds.ConvertKelvinToCelsius(x);

            Assert.AreEqual(274, res);

        }

    }
}
