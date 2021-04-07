using System;

namespace Basic.Topics.Abstract
{
   interface I1
    {
        void MethodLevel0();
    }

    abstract class A1 : I1
    {
        public abstract string PropertyLevel1 { get; set; }
        public abstract int this[int index] { get; set; }
        public abstract void MethodLevel1();
        public abstract event EventHandler EventLevel1;

        public abstract void MethodLevel0();
    }

    abstract class A2 : A1
    {
        public abstract string PropertyLevel2 { get; set; }
        public abstract void MethodLevel2();
        public abstract event EventHandler EventLevel2;
    }

    class C1 : A2
    {
        public override string PropertyLevel1 { get; set; }

        public override int this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override string PropertyLevel2 { get; set; }

        public override void MethodLevel1()
        {
            throw new NotImplementedException();
        }

        public override event EventHandler EventLevel1;

        public override void MethodLevel0()
        {
            throw new NotImplementedException();
        }

        public override void MethodLevel2()
        {
            throw new NotImplementedException();
        }

        public override event EventHandler EventLevel2;
    }
}