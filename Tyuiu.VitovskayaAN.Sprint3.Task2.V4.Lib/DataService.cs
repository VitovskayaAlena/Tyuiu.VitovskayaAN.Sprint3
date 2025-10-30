using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VitovskayaAN.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumSeries = 1;
            do
            {
                sumSeries *= (startValue / (Math.Pow(Math.Pow(Math.Sin(1), -7), -2)));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
