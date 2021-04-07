using Basic.Topics;

namespace Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new BuildInTypes().Run();
            new Keywords().Run();
            new Topics.Abstract.Runner().Go();
        }
    }
}