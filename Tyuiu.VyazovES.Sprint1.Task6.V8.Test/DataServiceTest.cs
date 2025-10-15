using Tyuiu.VyazovES.Sprint1.Task6.V8.Lib;
namespace Tyuiu.VyazovES.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string x = "привет пока" ;
            string y = ds.MoveLetterToEnd(x);
            Assert.AreEqual("риветп окап", y);


        }
    }
}
