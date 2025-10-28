using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VitovskayaAN.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
                multiplySeries = multiplySeries * ((Math.Pow(value, startValue) + 4) * Math.Cos(value));
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}