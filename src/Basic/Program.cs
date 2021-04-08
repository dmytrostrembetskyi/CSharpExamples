using Basic.Topics.BuildInTypes;
using Basic.Topics.ClassConstants;

namespace Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new TopicRunner().Run();
            new Topics.AbstractKeyword.TopicRunner().Run();
            new ExampleSandbox().Run();
            new Topics.ClassConstructor.ExampleSandbox().Run();
        }
    }
}