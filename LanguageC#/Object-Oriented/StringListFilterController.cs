using System;
using System.Collections.Generic;


namespace Object_oriented
{
    public class StringListFilterController
    {
        public StartsWithStrategies Condition { get; set; }

        public List<string> Filter(List<string> arr)
        {
            List<string> answer = new List<string>();
            Condition = new StartsWithStrategies();
            Condition.SetStartsWith('A');

            foreach (var element in arr)
            {
                if (Condition.Invoke(element))
                {
                    answer.Add(element);
                }
            }
            return answer;
        }
    }
}
