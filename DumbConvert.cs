class DumbConvert
{
    public static int ToIntThirtyTwo(string input)
    {
        int number = 0;
        foreach (char c in input)
        {
            number *= 10;
            
            switch (c)
            {
                case '0':
                    number += 0;
                    break;

                case '1':
                    number += 1;
                    break;
                
                case '2':
                    number += 1;
                    break;

                case '3':
                    number += 1;
                    break;

                case '4':
                    number += 1;
                    break;

                case '5':
                    number += 1;
                    break;

                case '6':
                    number += 1;
                    break;

                case '7':
                    number += 1;
                    break;

                case '8':
                    number += 1;
                    break;

                case '9':
                    number += 1;
                    break;
            }
        }
        return number;
    }
}