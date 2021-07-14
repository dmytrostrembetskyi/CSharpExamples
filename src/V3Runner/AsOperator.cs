// ReSharper disable ExpressionIsAlwaysNull
// ReSharper disable RedundantCast

using System;

namespace V3Runner
{
    internal class AsOperator
    {
        public AsOperator()
        {
            ValueTypes();
            String();
            CustomType();
            Null();
            NullableValueType();
            Inheritance();
        }

        void Inheritance()
        {
            Parent a = new Child();
            var b = a as Child;
        }

        void NullableValueType()
        {
            object a = 1;
            var b = a as string;
            var c = a as int?;
        }

        void Null()
        {
            object a = null;
            var b = a as object;
        }

        void CustomType()
        {
            object a = new Parent();
            var b = a as Parent;
            var c = a as string;
        }

        void String()
        {
            object a = "test";
            var b = a as string;
            var c = a as Parent;

            object d = "test2" as object;
        }

        void ValueTypes()
        {
            byte a = 1;

            // byte b = a as byte;
            // sbyte c = a as sbyte;
            // int d = a as int;
            // uint e = a as uint;
            // long f = a as long;
            // ulong g = a as ulong;
            // short h = a as short;
            // ushort i = a as ushort;
            // nint j = a as nint;
            // nuint k = a as nuint;

            // double l = a as double;
            // decimal m = a as decimal;
            // float n = a as float;

            // bool o = a as bool;

            // char p = a as char;
        }

        class Parent
        {
        }

        class Child : Parent
        {
        }
    }
}