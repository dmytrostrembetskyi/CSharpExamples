using System;

// ReSharper disable CommentTypo
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable PossiblyMistakenUseOfInterpolatedStringInsert

namespace V5.C06Conversion.Implicit.C04InterpolatedString
{
    public class Case1
    {
        public Case1()
        {
            string a = $"{1}";
            string a2 = "{1}";

            IFormattable b = $"{2}";
            // IFormattable b2 = "2";

            FormattableString c = $"{3}";
            // FormattableString c2 = "3";
        }
    }
}