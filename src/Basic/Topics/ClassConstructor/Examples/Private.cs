﻿// ReSharper disable UnusedParameter.Local

namespace Basic.Topics.ClassConstructor.Examples
{
    public class Private
    {
        Private()
        {
        }

        Private(int field1)
        {
        }

        public static Private Create()
        {
            return new Private();
        }

        public static Private Create(int parameter1)
        {
            return new Private(parameter1);
        }
    }
}