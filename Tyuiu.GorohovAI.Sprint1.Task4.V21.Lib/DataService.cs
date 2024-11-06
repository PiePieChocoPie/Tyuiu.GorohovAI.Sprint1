using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorohovAI.Sprint1.Task4.V21.Lib
{
    public class DataService : ISprint1Task4V21
    {
        public double Calculate(double x, double y)
        {
            return Math.Abs((1+x*x)-y)/(x+y);
        }
    }
}
