using System;
using System.Text;
public class equals
{
    public static void CheckEquality()
    {
        StringBuilder sb1 = new StringBuilder("Test");
        StringBuilder sb2 = new StringBuilder("Test");
        Console.WriteLine(sb1.Equals(sb2));
        StringBuilder sb3 = sb1;
        Console.WriteLine(sb1.Equals(sb3));
    }
}