namespace Basic.Topics.ClassConstants.Examples
{
    public class CanNot
    {
        public const int BeAccessedFromInstance = 1;
        public const int ChangeValueAnywhere = 1;

        // public CanNot()
        // {
        // ChangeValueAnywhere = 2;
        // }

        // public const int CreateInitializationCircle1 = CreateInitializationCircle2;
        // public const int CreateInitializationCircle2 = CreateInitializationCircle1;

        // public const int BeWithoutInitialization;

        // const object BeAnyObject = new object();

        // const int[] BeArray = new int[0];
        // const string[] BeArray2 = new[] {"one"};

        // const System.DateTime BeStruct = System.DateTime.Now;

        // const System.Action BeDelegate = delegate() { };
        // const event System.Action BeEvent = null;

        // const dynamic BeDynamic = 1;

        // const string BeMethodCallResult = "Hello".Substring(0, 1);

        // const void BeMethod()
        // {
        // }

        // const int BeProperty { get; set; }
    }
}