using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShaldinDA.Sprint5.Task6.V8.Lib
{
    public class DataService : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            int count = 0;
            var words = fileContent.Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (word.Length == 2)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
