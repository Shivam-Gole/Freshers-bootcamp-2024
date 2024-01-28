using System;

namespace Object_oriented
{
    public class StringPredicate
    {
        public Func<string, bool> CheckStringStartWithAny(string startString)
        {
            return stringItem => stringItem.StartsWith(startString);
        }
    }
}
