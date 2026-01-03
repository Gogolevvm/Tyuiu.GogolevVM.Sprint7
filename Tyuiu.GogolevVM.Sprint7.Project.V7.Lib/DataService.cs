namespace Tyuiu.GogolevVM.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public string[,] getFile(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n','\r');
            string[] lines = file.Split(new char[] { '\r'}, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = line_mas[j];
                }
            }
            return array;
        }
    }
}
