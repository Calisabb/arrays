#region 1.ededlerden en boyuk
using System.Globalization;
using System.Runtime.InteropServices;

// int[] nums = {2,1,5,4,6,3};
// int max_sum = 0;
// foreach (int i in nums)
// {
//     if (max_sum < i)
//     {
//         max_sum = i;
//     }
// }
// Console.WriteLine(max_sum);
#endregion

#region 2.verilmis sozu tapin

// string[] array = {"code" ,"it","c#", "python"};
// string a = "c#";
// for (int index=0; index<array.Length; index++)
// {
//     if (a==array[index])
//     {
//         Console.WriteLine(array[index]);
//         Console.WriteLine($"position on this array: {index}");
//     }
// }

#endregion

#region 3. n ededi ve array
// int[] ints = {12,3,4,5,6};
// int b = 5;
// foreach (int i in ints)
// {
//     if (b>i)
//     {
//         System.Console.WriteLine(true);
//     }
//     else
//     {
//         System.Console.WriteLine(false);
//     }
// }
#endregion

#region Optional

string[] strings = {"ti" ,"ymedacAedoC", "malas"};
string[] reversed = Array.Empty<string>();
string reverse_word = "";

for (int i = 0; i<strings.Length; i++)
{
    foreach (char chars in strings[i])
    {
        reverse_word += chars;
        reversed.Append(reverse_word);
        
    }
}

foreach (string words in reversed)
{
    Console.WriteLine(words);
}

#endregion
