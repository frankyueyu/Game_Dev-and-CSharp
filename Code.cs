class Code
{
    public static string MorseToKeyboardSection(string morse, char[] keyboardLeft, char[] keyboardRight)
    {
        Random random = new();
        string output = "";

        foreach (char i in morse)
        {
            switch (i)
            {
                case '.':
                {
                    output += keyboardLeft[random.Next(keyboardLeft.Length)];
                    break;
                }
                case '-':
                {
                    output += keyboardRight[random.Next(keyboardRight.Length)];
                    break;
                }
                case ' ':
                {
                    output += " ";
                    break;
                }
                case '/':
                {
                    output += " | ";
                    break;
                }
                default:
                {
                    output += "?";
                    break;
                }
            }
        }
        return output;
    }
}