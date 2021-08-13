namespace Basic.Topics.ClassConstants.Examples
{
    public class Calculated
    {
        const int Const1 = 1;
        const decimal Const2 = 2;
        public const int Const3 = Const1 + (int)Const2 + 108;
    }
}