namespace Basic.Topics.Abstract.Properties
{
    public class Example
    {
        public void Run()
        {
            var reference1 = new Class();

            reference1.Property1 = 1;
            var value1 = reference1.Property1;

            reference1.Property2 = 1;
            // var value2 = reference1.Property2;

            // reference1.Property3 = 1;
            var value3 = reference1.Property3;

            reference1.Property4 = 1;
            var value4 = reference1.Property4;

            reference1.Property5 = 1;
            var value5 = reference1.Property5;
            
            reference1.Property7 = 1;
            var value6 = reference1.Property7;
            
            reference1.Property8 = 1;
            var value7 = reference1.Property8;
        }
    }

    abstract class Abstract
    {
        public abstract int Property1 { get; set; }
        public abstract int Property2 { set; }
        public abstract int Property3 { get; }
        public int Property4 { get; set; }

        // public abstract int Property6
        // {
        //     get { return 0; }
        //     set { }
        // }

        public int Property7
        {
            get => 0;
            set
            {
                var a = value;
            }
        }

        public virtual int Property8
        {
            get => 0;
            set
            {
                var a = value;
            }
        }
    }

    class Class : Abstract
    {
        public override int Property1 { get; set; }

        public override int Property2
        {
            set
            {
                var a = value;
            }
        }

        public override int Property3 { get; }
        public int Property5 { get; set; }

        public override int Property8
        {
            get => 0;
            set
            {
                var a = value;
            }
        }
    }
}