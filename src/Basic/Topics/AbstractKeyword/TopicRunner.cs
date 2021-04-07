using Basic.Topics.AbstractKeyword.Creation;

namespace Basic.Topics.AbstractKeyword
{
    public class TopicRunner
    {
        public void Run()
        {
            new ExampleRunner().Run();
            new Properties.ExampleRunner().Run();
            new Methods.ExampleRunner().Run();
        }
    }
}