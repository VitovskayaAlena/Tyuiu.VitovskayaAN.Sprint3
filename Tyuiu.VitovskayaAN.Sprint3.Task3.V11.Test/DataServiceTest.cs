using Tyuiu.VitovskayaAN.Sprint3.Task3.V11.Lib;
namespace Tyuiu.VitovskayaAN.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string str = "sqwreq vqwqq q";
            char x = 'q';
            char y = '7';

            string res = ds.ReplaceCharOnNum(str, x, y);
            string wait = "s7wre7 v7w77 7";
            Assert.AreEqual(wait, res);
        }
    }
}
