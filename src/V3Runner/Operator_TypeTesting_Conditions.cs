using System;
using System.Collections;
using System.Collections.Generic;

namespace V3Runner
{
    internal class Operator_TypeTesting_Conditions
    {
        public Operator_TypeTesting_Conditions()
        {
            AnyReferenceTypeToObject();
            AnyReferenceTypeToDynamic();
            DerivedFromClass();
            ImplementInterface();
            ArrayToOtherArray();
            ArrayToSystemArrayItsInterfaces();
            ArrayToList();
            Delegate();
            IdentityConversion();
            TypeParameters();

            IsTrueWhenBoxingConversionExists();
            IsTrueWhenNullableHasValue();

            IsFalseWhenHigherOnSameHierarchy();
            IsFalseWhenNumericConversion();
        }

        void TypeParameters()
        {
            var a = new TypeParametersExample<string>();
            var c = a is TypeParametersExample<string>;
            var d = a is TypeParametersExample<object>;
        }

        void Delegate()
        {
            Action a = delegate { };
            var b = a is Delegate;
        }

        void ArrayToList()
        {
            var a = new string[1];
            var b = a is IList<string>;
            var c = a is IList<int>;
            var d = a is IList<object>;

            var shouldBeSingleDimensioned = new string[1, 2];
            var e = shouldBeSingleDimensioned is IList<string>;
            var f = shouldBeSingleDimensioned is IList<string[]>;
        }

        void ArrayToSystemArrayItsInterfaces()
        {
            var a = new object[1];
            var b = a is Array;
            var c = a is ICloneable;
            var d = a is IList;
            var e = a is IStructuralComparable;
            var f = a is IStructuralEquatable;
        }

        void ArrayToOtherArray()
        {
            var a = new string[1];
            var b = a is string[];
            var c = a is object[];

            var shouldHaveSameNumberOfDimensions = new string[1, 2];
            var d = shouldHaveSameNumberOfDimensions is string[,];
            var e = shouldHaveSameNumberOfDimensions is string[];

            var bothAreReferenceType = new string[1];
            var f = bothAreReferenceType is object;
            var g = bothAreReferenceType is int;

            var implicitReferenceConversionShouldExists = new UriTypeConverter[1];
            var h = implicitReferenceConversionShouldExists is UriTypeConverter[];
            var i = implicitReferenceConversionShouldExists is UriTypeConverter;
        }

        void AnyReferenceTypeToDynamic()
        {
            var a = new UriTypeConverter();
            var b = a is dynamic;

            var c = "h";
            var d = c is dynamic;
        }

        void AnyReferenceTypeToObject()
        {
            var a = new UriTypeConverter();
            var b = a is object;

            var c = "h";
            var d = c is object;
        }

        void IsFalseWhenNumericConversion()
        {
            var a = 1;
            var b = a is int;
            var c = a is long;
        }

        void IsFalseWhenHigherOnSameHierarchy()
        {
            var a = new SystemException();
            var b = a is SystemException;
            var c = a is Exception;

            var d = new Exception();
            var e = d is SystemException;
            var f = d is Exception;
        }

        void IsTrueWhenNullableHasValue()
        {
            int? a = 1;
            var b = a is int;
            a = null;
            var c = a is int;

            var d = "hello";
            var e = d is string;
            d = null;
            var f = d is string;

            var g = new Exception();
            var h = g is Exception;
            g = null;
            var i = g is Exception;
        }

        void IsTrueWhenBoxingConversionExists()
        {
            var a = 1;
            object b = a;
            var c = b is int;
        }

        void ImplementInterface()
        {
            var a = 1;
            var b = a is IComparable;
        }

        void DerivedFromClass()
        {
            var a = new SystemException();
            var b = a is SystemException;
            var c = a is Exception;
        }

        void IdentityConversion()
        {
            var a = 1d;
            var b = a is double;
        }

        class TypeParametersExample<T>
        {
        }
    }
}