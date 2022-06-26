using System; class StringCompare
{
    //programs to compare two strings.
    static void CompareString()
    {
        string str1,str2;
        int l1, l2;
        bool result = true;
        Console.WriteLine("Please enter 1st string:");
        str1 = Console.ReadLine();
        Console.WriteLine("Please enter 2nd string:");
        str2 = Console.ReadLine();
        l1 = str1.Length;
        l2 = str2.Length;
        if (l1==l2)
        {
            for (int i = 0; i < l1; i++)
            {
                if (!(str1[i] == str2[i]))
                {
                    result = false;
                    break;
                }
            }
            if (l1==l2)
            {
                Console.WriteLine("Output: Both strings are equal.");
            }
        }
        else if (l1<l2)
        {
            Console.WriteLine("Output: The first string is smaller than the second string.");
        }
        else if (l1>l2)
        {
            Console.WriteLine("Output: The first string is greater than the second string.");
        }
    }
    public static void Main(string[] arg)
    {
        CompareString();
    }
}

