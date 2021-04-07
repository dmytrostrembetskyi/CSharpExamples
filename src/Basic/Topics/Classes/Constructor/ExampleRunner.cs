namespace Basic.Topics.Classes.Constructor
{
    public class ExampleRunner
    {
        public void Run()
        {
            var default1 = new Basic();

            // var withParameters1 = new WithParameters();
            var withParameters2 = new WithParameters(1);
            var withParameters3 = new WithParameters(1, 1);

            // var private1 = new Private();
            var private2 = Private.Create();
            var private3 = Private.Create(1);
            var private4 = Private.Create(1, 1);

            var privateWithNested1 = new PrivateWithNested.Nested();
            var privateWithNested2 = privateWithNested1.Create();

            var copy1 = new CopyInstance {Property1 = 1, Property2 = 1};
            var copy2 = new CopyInstance(copy1);

            var hardcoded1 = new Hardcoded();

            var overloaded1 = new Overloaded(1);
            var overloaded2 = new Overloaded(1, 1);

            var canNot1 = new CanNot();
        }
    }
}