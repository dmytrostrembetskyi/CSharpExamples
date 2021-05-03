using System;

namespace V3Runner
{
    internal class BooleanLogicalOperator_LogicalExclusiveOr
    {
        public BooleanLogicalOperator_LogicalExclusiveOr()
        {
            ForBoolGenerateTrueIfBothOperatorsAreDifferent();
        }

        void ForBoolGenerateTrueIfBothOperatorsAreDifferent()
        {
            var a = true ^ true;
            var b = true ^ false;
            var c = false ^ true;
            var d = false ^ false;
        }
    }
}