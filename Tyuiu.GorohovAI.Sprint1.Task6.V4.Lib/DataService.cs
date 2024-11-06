using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorohovAI.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string input)
        {
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new System.Text.StringBuilder();

            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    if (result.Length > 0)
                    {
                        result.Append(" "); // Добавляем пробел перед словом, если это не первое слово
                    }
                    result.Append(word);
                }
            }

            return result.ToString();
        }
    }
}
