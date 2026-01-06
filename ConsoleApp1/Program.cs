internal class Program
{
    private static void Main(string[] args)
    {
        string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\TEST.csv";

        using (var writer = new StreamWriter(pathSaveFile))
        {
            writer.WriteLine("1;2");
            writer.WriteLine("3;4");
            writer.WriteLine("5;6");
        }
        Console.WriteLine(File.ReadAllText(pathSaveFile));
    }
}