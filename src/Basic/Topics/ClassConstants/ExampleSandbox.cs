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
            
            new AllowedTypes().StepIn();

            var buildIn = Math.PI;

            var canNot = new CanNot();
            // CanNot.ChangeValueAnywhere = 2;
            // var canNot2 = new CanNot().BeAccessedFromInstance;
        }
    }
}