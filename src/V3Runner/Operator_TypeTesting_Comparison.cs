using System;
using System.Collections.Generic;

// ReSharper disable IsExpressionAlwaysTrue
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable UnusedTypeParameter
// ReSharper disable OperatorIsCanBeUsed

namespace V3Runner
{
    internal class Operator_TypeTesting_Comparison
    {
        public Operator_TypeTesting_Comparison()
        {
            IdentityConversion();
            Boxing();
            TypeParameters();

            ReferenceTypeToObject();
            DerivedFromClass();
            ImplementInterface();
            ArrayToOtherArray();
            ArrayToSystemArrayOrItsInterfaces();
            ArrayToList();
            Delegate();
            Nullable();
            NumericConversion();

            ReferenceTypeToDynamic();

            //event
        }

        void TypeParameters()
        {
            var a = new TypeParametersExample<string>();

            var c = a is TypeParametersExample<string>;
            var c2 = a.GetType() == typeof(TypeParametersExample<string>);

            var d = a is TypeParametersExample<object>;
            var d2 = a.GetType() == typeof(TypeParametersExample<object>);
        }

        void Delegate()
        {
            Action a = delegate { };

            var b = a is Delegate;
            var b2 = a.GetType() == typeof(Delegate);

            var c = a is Action;
            var c2 = a.GetType() == typeof(Action);
        }

        void ArrayToList()
        {
            var a = new string[1];

            var b = a is IList<string>;
            var b2 = a.GetType() == typeof(IList<string>);

            var d = a is IList<object>;
            var d2 = a.GetType() == typeof(IList<object>);

            var shouldBeSingleDimensioned = new string[1, 2];
            var e = shouldBeSingleDimensioned is IList<string>;
            var f = shouldBeSingleDimensioned is IList<string[]>;
        }

        void ArrayToSystemArrayOrItsInterfaces()
        {
            var a = new object[1];
            var b = a is Array;
            var b2 = a.GetType() == typeof(Array);
        }

        void ArrayToOtherArray()
        {
            var a = new string[1];

            var b = a is string[];
            var b2 = a.GetType() == typeof(string[]);

            var c = a is object[];
            var c2 = a.GetType() == typeof(object[]);

            var shouldHaveSameNumberOfDimensions = new string[1, 2];
            var d = shouldHaveSameNumberOfDimensions is string[,];
            var e = shouldHaveSameNumberOfDimensions is string[];

            var bothAreReferenceType = new string[1];
            var f = bothAreReferenceType is object;
            var g = bothAreReferenceType is int;
        }

        void ReferenceTypeToDynamic()
        {
            var a = new UriTypeConverter();
            var b = a is dynamic;
            // var dynamicTypeIsNowExists = a.GetType() == typeof(dynamic);

            var c = "h";
            var d = c is dynamic;
        }

        void ReferenceTypeToObject()
        {
            var a = new UriTypeConverter();
            var b = a is object;
            var b2 = a.GetType() == typeof(object);

            var c = "h";
            var d = c is object;
            var d2 = c.GetType() == typeof(object);
        }

        void NumericConversion()
        {
            var a = 1;

            var c = a is long;
            var c2 = a.GetType() == typeof(long);
        }

        void Nullable()
        {
            int? a = 1;
            var b = a is int;
            var b2 = a.GetType() == typeof(int);

            a = null;
            var c = a is int;
            // var c2_throwException = a.GetType() == typeof(int);
            var c2 = a?.GetType() == typeof(int);

            var d = "hello";
            var e = d is string;
            var e2 = d.GetType() == typeof(string);

            d = null;
            var f = d is string;
            // var f2_throwException = d.GetType() == typeof(string);
            var f2 = d?.GetType() == typeof(string);
        }

        void Boxing()
        {
            var a = 1;
            object b = a;

            var c = b is int;
            var c2 = b.GetType() == typeof(int);
        }

        void ImplementInterface()
        {
            var a = 1;
            var b = a is IComparable;
            var b2 = a.GetType() == typeof(IComparable);
        }

        void DerivedFromClass()
        {
            var a = new Child();

            var c = a is Parent;
            var c2 = a.GetType() == typeof(Parent);
        }

        void IdentityConversion()
        {
            var a = 1d;

            var b = a is double;
            var b2 = a.GetType() == typeof(double);
        }

        class TypeParametersExample<T>
        {
        }

        class Parent
        {
        }

        class Child : Parent
        {
        }
    }
}