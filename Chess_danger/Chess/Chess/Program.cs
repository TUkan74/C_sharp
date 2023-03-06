using Chess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    class Figure
    {

        public (int x, int y) GetNext()
        {

        }
    }


    class Bishop : Figure
    {
        public (int x, int y) GetNext()
        {
            return (1, 2);
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            Bishop bishop = new Bishop();
            Console.WriteLine(b.GetNext());
        }
    }
}