using Basic.Topics.BuildInTypes;

namespace Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new TopicRunner().Run();
            new Topics.Classes.TopicRunner().Run();
            new Topics.AbstractKeyword.TopicRunner().Run();
        }
    }
}