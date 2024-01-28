using System;


namespace Object_oriented
{
    public class StartsWithStrategies
    {
        private char startsWith;

        public void SetStartsWith(char key)
        {
            this.startsWith = key;
        }

        public bool Invoke(string item)
        {
            return item.StartsWith(this.startsWith.ToString());
        }
    }
}
