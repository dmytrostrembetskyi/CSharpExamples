namespace Basic.Topics.ArithmeticOperators
{
    public class CanNotBeUsedWithObject
    {
        public CanNotBeUsedWithObject()
        {
            var variable = new object();
            // variable++;
            // variable--;
            // var minus = -variable;
            // var plus = +variable;
            // var addition = variable + variable;
            // var subtraction = variable - variable;
            // var multiplication = variable * variable;
            // var division = variable / variable;
            // var remainder = variable % variable;
        }
    }
}