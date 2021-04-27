namespace Basic.Topics.ClassConstructor.Examples
{
    public class WithParameters
    {
        int field1;
        int field2;
        int field3;

        public WithParameters(int field1)
        {
            this.field1 = field1;
        }

        // public WithParameters(int field1)
        // {
        //     this.field1 = field1;
        // }

        public WithParameters(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }
    }
}