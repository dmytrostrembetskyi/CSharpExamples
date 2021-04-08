using Basic.Topics.ClassConstructor.Examples;

namespace Basic.Topics.ClassConstructor
{
    public class ExampleSandbox
    {
        public void Run()
        {
            var @default = new Default();

            // var withParameters = new WithParameters();
            var withParameters2 = new WithParameters(1);
            var withParameters3 = new WithParameters(1, 1);

            // var private = new Private();
            var private2 = Private.Create();
            var private3 = Private.Create(1);
            var private4 = Private.Create(1, 1);

            var privateWithNested = new PrivateWithNested.Nested();
            var privateWithNested2 = privateWithNested.Create();

            var copy = new CopyInstance {Property1 = 1, Property2 = 1};
            var copy2 = new CopyInstance(copy);

            var parameterless = new Parameterless();

            var overloaded = new Overloaded(1);
            var overloaded2 = new Overloaded(1, 1);

            var hasReturn = new HasReturn(1, 1);

            var canNot = new CanNot();
        }
    }
}