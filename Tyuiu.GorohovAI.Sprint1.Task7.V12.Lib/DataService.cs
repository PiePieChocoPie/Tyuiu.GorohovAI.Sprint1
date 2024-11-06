using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorohovAI.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Pow(((x+1.0)/x-1.0),x) + 18*x*Math.Pow(y,2)),3) + 7.594;
        }
    }
}
