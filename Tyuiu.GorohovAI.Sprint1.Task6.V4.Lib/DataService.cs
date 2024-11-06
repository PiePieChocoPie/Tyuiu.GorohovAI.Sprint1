using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorohovAI.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string input)
        {
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string g;
            foreach (string word in words)
            {
                string modifiedWord;
                if (word.Contains("нн")) 
                {
                    modifiedWord = word;
                }
                else
                {
                    modifiedWord = word.Replace("н", "нн");
                }
                g += modifiedWord + "";
            }
            return g;
        }
    }
}
