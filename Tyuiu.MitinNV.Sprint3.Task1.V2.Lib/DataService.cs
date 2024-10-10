using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            var i = startValue;
            while (i <= stopValue) 
            { 
                sumSeries += Math.Sin(i) * 0.5;
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
