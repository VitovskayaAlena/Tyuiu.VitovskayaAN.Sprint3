using Tyuiu.VitovskayaAN.Sprint3.Task6.V3.Lib;
namespace Tyuiu.VitovskayaAN.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 121;

            Assert.AreEqual(wait, res);
        }
    }
}
