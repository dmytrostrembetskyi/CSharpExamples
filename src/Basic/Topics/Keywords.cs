using System;

namespace Basic.Topics
{
    public class Keywords
    {
        public void Run()
        {
            var @as = null as string;
            var @true = true;
            var @false = false;

            foreach (var var in "") break;

            byte @byte;

            switch (0)
            {
                case 0:
                    break;
            }

            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            char @char;

            checked
            {
                var int1 = 80;
                // var int2 = 2147483647 + int1;
            }
        }

        private abstract class Base
        {
            protected Base(bool @bool)
            {
            }
        }

        private class Child : Base
        {
            private Child(bool @bool) : base(@bool)
            {
            }
        }
    }
}