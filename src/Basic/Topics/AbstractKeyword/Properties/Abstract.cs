namespace Basic.Topics.AbstractKeyword.Properties
{
    internal abstract class Abstract
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
}