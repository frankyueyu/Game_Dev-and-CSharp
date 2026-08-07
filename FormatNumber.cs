using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        BigInteger bigNumber = BigInteger.Parse("999999999999999999999999999");
        Console.WriteLine(FormatNumber(bigNumber));
    }
    public static string FormatNumber(string x)
    {
        int originalLength = x.Length;
        int j = 0;
    
        for (int i = 1; i <= originalLength; i++)
        {
            if (i % 3 == 0)
            {
                x = x.Insert(x.Length - (i + j), ",");
                j++;
            }
        }

        return x;
    }

    public static string FormatNumber(BigInteger x)
    {
        string y = x.ToString();
        int originalLength = y.Length;
        int j = 0;

        for (int i = 1; i <= originalLength; i++)
        {
            int yLength = y.Length;
            if (i % 3 == 0 && i != originalLength)
            {
                y = y.Insert(yLength - (i + j), ",");
                j++;
            }
        }

        return y;
    }
}

/*
hold on...in honor of potat...

```C#
using System;

public string formatNumber(string x)
{
    for (int i = 0; i < x.Length; i++)
    {
        if (i % 3 == 0)
        {
            x.Insert(x[^(i + 1)], ",");
        }
    }
}

public string formatNumber(System.Numerics.BigInteger x)
{
    x = x.ToString();

    for (int i = 0; i < x.Length; i++)
    {
        if (i % 3 == 0)
        {
            x.Insert(x[^(i + 1)], ",");
        }
    }
}
```

ok we are ***GOOD***

um lemme run it in VS Code...
*/