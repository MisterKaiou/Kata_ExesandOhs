using System;
using System.Linq;

namespace ExesandOhs.main
{
    public class XOCounter
    {
        public bool XO(string input) => input.Count(n => char.Equals(char.ToLower(n), 'x')) == input.Count(c => char.Equals(char.ToLower(c), 'o'));
    }
}