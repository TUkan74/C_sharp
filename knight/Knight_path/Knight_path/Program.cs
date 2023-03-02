using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Knight_path
{
    internal class Program
    {
        //can you jump there? 
        static bool is_valid(int x,int y,int[,] board)
        {
            if ((0 <= x) && (x < 8))
            {
                if ((0 <= y) && (y < 8))
                {
                    if (board[x,y] == 0) 
                    {
                        return true;
                    }
                }
            }
            else { return false; }
            return false;
        }


        
        static void Main(string[] args)
        {
            //variables
            int[,] board;
            board = new int[8,8];
            (int, int,int) start;
            (int, int) end = (0,0);
            string[] cor;
            Queue<(int,int,int)> Q = new Queue<(int,int,int)>();
            int[] move_x = { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] move_y = { 1, 1, 0, -1, -1, -1, 0, 1 };

            //get input

            int num_o = Convert.ToInt32(Console.ReadLine()) ;
            //coordinance of obstacles added to board
            for (int i = 0;i < num_o;i++) {
                
                cor=(Console.ReadLine()).Split(' ');
                board[Convert.ToInt32(cor[0])-1, Convert.ToInt32(cor[1])-1] = 99;
            }
            
            //start position
            cor = (Console.ReadLine()).Split(' ');
            start = (Convert.ToInt32(cor[0])-1, Convert.ToInt32(cor[1])-1,0);
            board[start.Item1,start.Item2 ] = 99;

            //end position
            cor = (Console.ReadLine()).Split(' ');
            end = (Convert.ToInt32(cor[0])-1, Convert.ToInt32(cor[1])-1);
            board[end.Item1,end.Item2] = 0;

            //Console.WriteLine($"{start}");
            //position variables and main Queue
            Q.Enqueue(start);
            (int,int,int) pos; 
            (int, int, int) nxt;
            int x, y;
            int noj = 0;
            bool no_path = true;
            while ((Q.Count > 0)&& no_path)
            {
                pos =  Q.Dequeue();
                x = pos.Item1; 
                y= pos.Item2 ;
                noj = pos.Item3 ;
                
                //Console.WriteLine($"position: {pos}");
                //Console.WriteLine($"target: {end}");

                //done?
                if ((pos.Item1== end.Item1) && (pos.Item2==end.Item2))
                {
                    Console.WriteLine($"{noj}");
                    no_path = false;
                    break;
                }

                //moving the knight
                for (int i = 0; i < 8; i++)
                {
                    nxt = (x + move_x[i], y + move_y[i], noj + 1);
                    
                    if (Program.is_valid(nxt.Item1,nxt.Item2, board)){
                        Q.Enqueue(nxt);
                        board[nxt.Item1, nxt.Item2] = 99;
                        //Console.WriteLine($"next after jump: {nxt}");
                    }
                }
            }
            if (no_path)
            {
                Console.WriteLine("-1");
            }
            
            Console.ReadLine();
        }
    }
}
