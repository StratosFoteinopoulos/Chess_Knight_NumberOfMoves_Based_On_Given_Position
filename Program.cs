using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Knight_NumberOfMoves_Based_On_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.ChessKnight("h4");
            


        }


        public int ChessKnight(string cell)

         {
            string start = "a1";
            var knightpos = cell.ToCharArray();
            var startpos = start.ToCharArray();
            var difx = knightpos[0] - startpos[0];
            var dify = knightpos[1] - startpos[1];
            if ((difx==0&&dify==0)||(difx==7&&dify==0)||(difx==0&&dify==7)||(difx==7&&dify==7))
            {
                Console.WriteLine(2);
                return 2;
            }
            else if (difx==0||difx==7)
            {
                if (dify == 0 || dify == 7)
                {
                    Console.WriteLine(2);
                    return 2;
                }
                else if (dify == 1 || dify == 6)
                {
                    Console.WriteLine(3);
                    return 3;
                }
                else if (dify > 1 && dify < 6)
                {
                    Console.WriteLine(4);
                    return 4;
                }
            }
            else if (difx == 1 || difx == 6) 
            {
                if (dify == 0 || dify==7)
                {
                    Console.WriteLine(3);
                    return 3;
                }
                else if (dify == 1 || dify == 6)
                {
                    Console.WriteLine(4);
                    return 4;
                }
                else if (dify > 1 && dify < 6)
                {
                    Console.WriteLine(6);
                    return 6;
                }
                
                
            }
            else if (difx > 1 && difx < 6) 
            {
                if (dify == 0||dify == 7)
                {
                    Console.WriteLine(4);
                    return 4;
                }
                else if (dify == 1 || dify == 6)
                {
                    Console.WriteLine(6);
                    return 6;
                }
                else if (dify > 1 && dify < 6)
                {
                    Console.WriteLine(8);
                    return 8;
                }
               
            }
            else
                Console.WriteLine("error");
                return 999;
            


        }

    }
}
