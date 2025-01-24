using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShaldinDA.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string output = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }

                    output += matrix[i, j];

                    if (j < matrix.GetLength(1) - 1)
                    {
                        output += ";";
                    }
                }
                if (i < matrix.GetLength(0) - 1)
                {
                    output += "\n";
                }
            }


            return output;
        }
    }
}
