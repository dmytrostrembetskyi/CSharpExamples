﻿// ReSharper disable NotAccessedField.Local

namespace Basic.Topics.ClassConstructor.Examples
{
    public class Static
    {
        public static int Field2;
        int _field1;

        static Static()
        {
            Field2 = 2;
        }

        public Static(int field1)
        {
            _field1 = field1;
        }
    }
}