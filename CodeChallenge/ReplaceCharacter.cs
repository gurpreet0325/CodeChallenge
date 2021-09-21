using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class ReplaceCharacter
    {
        public static string Replace(string inputText)
        {
            Dictionary<char, char> replacementDictionary = new Dictionary<char, char>();
            replacementDictionary.Add('a', '@');

            char[] charList = inputText.ToCharArray();

            for (int i = 0; i < charList.Length; i++)
            {
                char replacedChar;
                if (replacementDictionary.TryGetValue(charList[i], out replacedChar))
                    charList[i] = replacedChar;
            }

            return new string(charList);
        }
    }
}
