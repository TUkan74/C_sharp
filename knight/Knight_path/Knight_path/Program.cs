using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Knight_path
{
    internal class Program
    {
        //can you jump there? 
        bool is_valid(int x, int y,bool[,] sachovnica)
        {
            if ((0 <= x) && (x < 8))
            {
                if ((0 <= y) && (y < 8))
                {
                    if (sachovnica[x,y] == false)
                    {
                        return true;
                    }
                }
            }
            return  true;
        }
        
        static void Main(string[] args)
        {
            //variables
            bool[,] sachovnica;
            sachovnica = new bool[8,8];




            //get input
            (int, int) sur = (0, 0);
            (int , int) start = (0, 0);
            (int, int) end = (0, 0);
            string cor;
            int num_o = Convert.ToInt32(Console.ReadLine()) ;
            
            for (int i = 0;i < num_o;i++)
            {
                cor = Console.ReadLine();
                for (int j = 0;j < cor.Length;j++) {
                    if (cor[j] != )
                }
            }
            //Console.WriteLine($"{sachovnica[0, 0]}");
            Console.ReadLine();
        }
    }
}
