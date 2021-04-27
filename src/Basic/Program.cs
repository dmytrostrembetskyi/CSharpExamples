using Basic.Topics.BuildInTypes;
using Basic.Topics.ClassConstants;
using Basic.Topics.Void;

// ReSharper disable UnusedParameter.Local

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new TopicRunner().Run();
            new Topics.AbstractKeyword.TopicRunner().Run();
            new ExampleSandbox().Run();
            new Topics.ClassConstructor.ExampleSandbox().Run();
            new ExampleRunner();
        }
    }
}