using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShaldinDA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            var values = fileContent
                .Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(val =>
                {
                    if (double.TryParse(val, out double doubleValue))
                    {
                        return Math.Round(doubleValue, 3);
                    }
                    return (double?)null;
                })
                .Where(val => val.HasValue)
                .Select(val => val.Value)
                .ToArray();
            var integers = values.Where(val => val == Math.Truncate(val)).ToArray();
            var maxInteger = integers.Max();
            var minInteger = integers.Min();
            var difference = maxInteger - minInteger;

            Console.WriteLine(Math.Round(difference, 3));
            return difference;
        }

    }
}
