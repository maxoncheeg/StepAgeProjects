namespace WpfSharpEx1_2
{
    static class StringMethods
    {
        public static string StringReverse(this string line)
        {
            string result = "";

            for (int i = line.Length - 1; i >= 0; i--)
                result += line[i];

            return result;
        }

        public static string InsertInLine(this string inputLine, string line, int firstIndex, int lastIndex)
        {
            string result = "";

            for (int i = 0; i <= firstIndex; i++)
                result += inputLine[i];

            result += line;

            for (int i = lastIndex; i < inputLine.Length; i++)
                result += inputLine[i];

            return result;
        }
    }
}
