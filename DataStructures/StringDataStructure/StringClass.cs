using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StringDataStructure
{
    public static class StringProblems
    {

        public static bool CheckAnagrams(string input,string input2)
        {           
            if(string.IsNullOrEmpty(input) || string.IsNullOrEmpty(input2))
                return false;

            var sortedInput = string.Join("",input.OrderBy(x=>x).ToArray());
            var sortedInput2 = string.Join("", input2.OrderBy(x => x).ToArray());
            return sortedInput.Equals(sortedInput2);        
        }
    }
}
