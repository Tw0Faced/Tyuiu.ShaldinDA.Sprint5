using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShaldinDA.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            double calculation = Math.Round((Math.Pow(x,3) - 1)/(4 * Math.Pow(x,2)), 3);
            byte[] byteArray = BitConverter.GetBytes(calculation);
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllBytes(tempFilePath, byteArray);
            return tempFilePath;
        }
    }
}
