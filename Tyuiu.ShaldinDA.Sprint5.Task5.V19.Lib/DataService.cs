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
                    if (int.TryParse(val, out int intValue) && Math.Abs(intValue) < 10)
                    {
                        return (double?)intValue;
                    }
                    return (double?)null;
                })
                .Where(val => val.HasValue)
                .Select(val => val.Value)
                .ToArray();

            var maxInteger = values.Max();
            var minInteger = values.Min();
            var difference = maxInteger - minInteger;

            Console.WriteLine(Math.Round(difference, 3));
            return difference;
        }
    }
}
