namespace Basic.Topics.ArithmeticOperators
{
    public class CanBeUsedWithChars
    {
        public CanBeUsedWithChars()
        {
            var variable = 'i';
            variable++;
            variable--;
            var minus = (char) -variable;
            var plus = (char) +variable;
            var addition = (char) (variable + variable);
            var subtraction = (char) (variable - variable);
            var multiplication = (char) (variable * variable);
            var division = (char) (variable / variable);
            var remainder = (char) (variable % variable);
        }
    }
}