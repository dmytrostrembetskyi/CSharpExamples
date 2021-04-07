namespace Basic.Topics.Abstract.Methods
{
    public class Example
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
    
    internal abstract class Abstract
    {
        public abstract void Method1();

        public virtual void Method2()
        {
        }

        public void Method3()
        {
        }

        public virtual void Method4()
        {
        }

        public void Method6()
        {
        }

        public void Method7()
        {
        }
    }

    internal class Class : Abstract
    {
        public override void Method1()
        {
        }

        public override void Method2()
        {
        }

        // public override void Method3()
        // {
        // }

        public override void Method4()
        {
            int a;
            base.Method4();
        }

        public void Method5()
        {
        }

        public new void Method6()
        {
        }

        public new void Method7()
        {
            base.Method7();
        }
    }
}