// ReSharper disable EqualExpressionComparison
// ReSharper disable ConvertToConstant.Local

namespace V3Runner
{
    internal class Operator_Comparison_NaN
    {
        public Operator_Comparison_NaN()
        {
            ReturnFalseIfAnyOperandIsNaN();
        }

        void ReturnFalseIfAnyOperandIsNaN()
        {
            var nan = 0 / 0D;
            var a = 1 < nan;
            var b = 1 > nan;
            var c = nan <= 1;
            var d = nan >= 1;
            var e = nan <= nan;
        }
    }
}