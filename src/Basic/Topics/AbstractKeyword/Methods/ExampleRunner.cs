namespace Basic.Topics.AbstractKeyword.Methods
{
    public class ExampleRunner
    {
        public void Run()
        {
            var reference1 = new Class();
            reference1.Method1();
            reference1.Method2();
            reference1.Method3();
            reference1.Method4();
            reference1.Method5();
            reference1.Method6();
            reference1.Method7();

            Abstract reference2 = new Class();
            reference2.Method1();
            reference2.Method2();
            reference2.Method3();
            reference2.Method4();
            reference2.Method6();
            reference2.Method7();
        }
    }
}