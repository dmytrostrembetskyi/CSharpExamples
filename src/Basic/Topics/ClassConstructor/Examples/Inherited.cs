namespace Basic.Topics.ClassConstructor.Examples
{
    public class Inherited : Parent
    {
        public Inherited()
        {
        }

        public Inherited(int field1) : base(field1)
        {
        }
    }

    public class Parent
    {
        public Parent()
        {
        }

        public Parent(int field1)
        {
        }
    }
}