using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MitinNV.Sprint3.Task4.V2.Lib
{
    public class DataService : ISprint3Task4V2
    {
        public double Calculate(int startValue, int stopValue)
        {
            var result = 0.0;
            for (var i = startValue; i <= stopValue; i++) 
            { 
                if (i == 0) {
                    break;
                }   
                
                result += Math.Cos(i) / i;
            }

            return Math.Round(result, 3);
        }
    }
}
