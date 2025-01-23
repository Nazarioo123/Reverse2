using System;
using System.IO;

class Program
{
       static void Main()

        {
         string s = Console.ReadLine();
        char[] sReverse = s.ToCharArray();
        Array.Reverse(sReverse);
        s = new string(sReverse);
        Console.WriteLine(s);
        Console.ReadLine();
         


        }
  
}
