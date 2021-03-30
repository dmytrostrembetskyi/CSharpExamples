namespace Basic.Topics
{
    public class BuildInTypes
    {
        public void Run()
        {
            Value();
            Reference();
        }

        private void Value()
        {
            byte @byte;
            sbyte @sbyte;
            int @int;
            uint @uint;
            long @long;
            ulong @ulong;
            short @short;
            ushort @ushort;
            nint nint;
            nuint nuint;

            double @double;
            decimal @decimal;
            float @float;

            bool @bool;

            char @char;
        }

        private void Reference()
        {
            object @object;
            string @string;
            dynamic dynamic;
        }
    }
}