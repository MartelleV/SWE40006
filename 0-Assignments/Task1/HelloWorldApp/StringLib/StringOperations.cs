namespace StringLib
{
    /// <summary>
    /// Provides string manipulation utility operations.
    /// Compiled as StringLib.dll — packaged as a dependency in the MSI installer.
    /// </summary>
    public static class StringOperations
    {
        /// <summary>
        /// Reverses the characters in a string.
        /// </summary>
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] chars = input.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Converts a string to Title Case (first letter of each word capitalised).
        /// </summary>
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) +
                               (words[i].Length > 1 ? words[i].Substring(1).ToLower() : "");
                }
            }

            return string.Join(" ", words);
        }

        /// <summary>
        /// Counts the number of vowels (a, e, i, o, u) in a string, case-insensitive.
        /// </summary>
        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int count = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".IndexOf(c) >= 0)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Returns whether the given string is a palindrome (ignoring case and spaces).
        /// </summary>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string cleaned = input.Replace(" ", "").ToLower();
            string reversed = Reverse(cleaned);
            return cleaned == reversed;
        }

        /// <summary>
        /// Returns the version string of this library (for demonstration in the UI).
        /// </summary>
        public static string GetLibraryInfo()
        {
            return "StringLib v1.0.0";
        }
    }
}