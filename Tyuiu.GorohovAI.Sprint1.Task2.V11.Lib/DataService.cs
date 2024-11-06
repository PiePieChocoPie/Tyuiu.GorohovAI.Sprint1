using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorohovAI.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int hours, int valueTwo)
        {
            return (hours * 60 + valueTwo) * 60;
        }
    }
}
