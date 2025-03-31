namespace GaderypolukiCipher
{
    class Cypher() {
        public static string GaderypolukiDictionary(string input)
        {
            var dict = new Dictionary<char, char>
            {
                {'G', 'A'},
                {'A', 'G'},
                {'D', 'E'},
                {'E', 'D'},
                {'R', 'Y'},
                {'Y', 'R'},
                {'P', 'O'},
                {'O', 'P'},
                {'L', 'U'},
                {'U', 'L'},
                {'K', 'I'},
                {'I', 'K'}
            };

            input = input.ToUpper();
            string output = string.Empty;

            foreach (char c in input)
            {
                if (dict.ContainsKey(c)) {
                    output += dict[c];
                }
                else {
                    output += c;
                }
            }

            return output;
        }
    }
}
