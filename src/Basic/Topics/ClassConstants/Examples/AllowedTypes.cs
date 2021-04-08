using System;

// ReSharper disable BuiltInTypeReferenceStyle

namespace Basic.Topics.ClassConstants.Examples
{
    public class AllowedTypes
    {
        public const int Numeric = 1;
        public const decimal Numeric2 = 1;
        public const Int32 Numeric3 = 1;

        public const bool Boolean = true;
        public const Boolean Boolean2 = true;

        public const string String = "Hello";
        public const string String2 = null;

        public const object Object = null;

        public const dynamic Dynamic = null;

        public const Action Action = null;

        public const int[] Array = null;
    }
}