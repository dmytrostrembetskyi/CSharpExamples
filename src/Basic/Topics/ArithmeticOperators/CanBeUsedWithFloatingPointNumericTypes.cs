namespace Basic.Topics.ArithmeticOperators
{
    public class CanBeUsedWithFloatingPointNumericTypes
    {
        public CanBeUsedWithFloatingPointNumericTypes()
        {
            Float();
            Double();
            Decimal();
        }

        void Decimal()
        {
            var variable = 8.5m;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Double()
        {
            var variable = 8.5d;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Float()
        {
            var variable = 8.5f;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }
    }
}