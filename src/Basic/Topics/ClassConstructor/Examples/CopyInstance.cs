namespace Basic.Topics.ClassConstructor.Examples
{
    public class CopyInstance
    {
        public CopyInstance()
        {
        }

        public CopyInstance(CopyInstance parameter1)
        {
            Property1 = parameter1.Property1;
            Property2 = parameter1.Property2;
        }

        public int Property1 { get; set; }
        public int Property2 { get; set; }
    }
}