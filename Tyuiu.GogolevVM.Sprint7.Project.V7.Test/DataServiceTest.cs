using Tyuiu.GogolevVM.Sprint7.Project.V7.Lib;
namespace Tyuiu.GogolevVM.Sprint7.Project.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\TEST.csv";

            using (var writer = new StreamWriter(pathSaveFile))
            {
                writer.WriteLine("1;2");
                writer.WriteLine("3;4");
                writer.WriteLine("5;6");
            }

            string[,] res = ds.getFile(pathSaveFile);
            string[,] wait = { { "1", "2" }, { "3", "4" }, { "5", "6" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
