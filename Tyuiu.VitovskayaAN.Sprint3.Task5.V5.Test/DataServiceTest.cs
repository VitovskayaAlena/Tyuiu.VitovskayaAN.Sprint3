using Tyuiu.VitovskayaAN.Sprint3.Task5.V5.Lib;
namespace Tyuiu.VitovskayaAN.Sprint3.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(5, 1, 1, 3, 10);
            Assert.AreEqual(98.286, res);
        }
    }
}
