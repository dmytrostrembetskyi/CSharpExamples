// ReSharper disable UnassignedGetOnlyAutoProperty

namespace Basic.Topics.AbstractKeyword.Properties
{
    internal class Class : Abstract
    {
        public override int Property1 { get; set; }

        public override int Property2
        {
            set
            {
                var a = value;
            }
        }

        public override int Property3 { get; }
        public int Property5 { get; set; }

        public override int Property8
        {
            get => 0;
            set
            {
                var a = value;
            }
        }
    }
}