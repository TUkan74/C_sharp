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
            int[,] board;
            board = new int[8,8];




            //get input
            (int, int) sur = (0, 0);
            (int , int) start = (0, 0);
            (int, int) end = (0, 0);
            string[] cor;
            int num_o = Convert.ToInt32(Console.ReadLine()) ;
            //coordinance of obstacles added to board
            for (int i = 0;i < num_o;i++) {
                
                cor=(Console.ReadLine()).Split(' ');
                board[Convert.ToInt32(cor[0]), Convert.ToInt32(cor[1])] = 1;
            }
            //start position
            cor = (Console.ReadLine()).Split(' ');
            start = (Convert.ToInt32(cor[0]), Convert.ToInt32(cor[1]));
            //end position
            cor = (Console.ReadLine()).Split(' ');
            end = (Convert.ToInt32(cor[0]), Convert.ToInt32(cor[1]));

            //write out whole array
            /*foreach (var sq in sachovnica)
            {
                System.Console.WriteLine($"<{sq}>");
            }*/
            
            Console.ReadLine();
        }
    }
}
