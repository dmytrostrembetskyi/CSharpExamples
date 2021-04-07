namespace Basic.Topics.Abstract.Creation
{
    public class Example
    {
        public void Run()
        {
            var reference1 = new Class();
            Abstract reference2;
            Abstract reference3 = new Class();
            // var reference4 = new AbstractClass();
        }
    }
    
    abstract class Abstract
    {
    }

    class Class : Abstract
    {
    }
}