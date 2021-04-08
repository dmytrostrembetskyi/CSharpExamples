using System;
using Basic.Topics.ClassConstants.Examples;

namespace Basic.Topics.ClassConstants
{
    public class ExampleSandbox
    {
        public void Run()
        {
            var basic = Simple.Const;

            var multiple = MultipleDeclaration.Const1;
            var multiple2 = MultipleDeclaration.Const2;

            var @private = new Private().Get();

            var calculated = Calculated.Const3;

            var allowedTypes = AllowedTypes.Numeric;
            var allowedTypes2 = AllowedTypes.Numeric2;
            var allowedTypes3 = AllowedTypes.Numeric3;
            var allowedTypes4 = AllowedTypes.Boolean;
            var allowedTypes5 = AllowedTypes.Boolean2;
            var allowedTypes6 = AllowedTypes.String;
            var allowedTypes7 = AllowedTypes.String2;
            var allowedTypes8 = AllowedTypes.Object;
            var allowedTypes9 = AllowedTypes.Dynamic;
            var allowedTypes10 = AllowedTypes.Action;
            var allowedTypes11 = AllowedTypes.Array;

            var buildIn = Math.PI;

            var canNot = new CanNot();
            // CanNot.ChangeValueAnywhere = 2;
            // var canNot2 = new CanNot().BeAccessedFromInstance;
        }
    }
}