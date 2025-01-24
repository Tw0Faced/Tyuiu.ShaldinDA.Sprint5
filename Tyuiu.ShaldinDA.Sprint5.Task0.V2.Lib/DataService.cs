using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShaldinDA.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Round(Math.Exp(x) / x, 3);
            string resultText = result.ToString();

            return resultText;
        }
    }
}
