
using System;
class Hello
{
    static string Fact(int num)
    {
        string vysledok = $"{num}"+"=";
        int i = 2;
        while (i*i <= num) 
        {
            if (num%i != 0 )
            {
                i++;
            }
            else
            {
                num/=i;
                vysledok += $"{i}" + "*";
            }

        }
        if (num>1)
        {
            vysledok += $"{num}";
        }
        return vysledok;
         
    }
    
    
    static void Main(string[] args)
    {
        // Output: Hello, world!
        int cislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fact(cislo));
    }
}

