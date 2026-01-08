using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0108assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //미로찾기
            Console.SetWindowSize(40, 20);
            Console.SetBufferSize(40, 20);
            int x = 1, y = 0;
            int targetX = 13, targetY = 9;
            int count = 0;
            ConsoleKeyInfo keyInfo;//키 관련 정보
            Console.CursorVisible = false;

            ////■는벽,□는 통로
            //Console.WriteLine("■■■■■■■■■■■■■");
            //Console.WriteLine("■□□□□□■□■□□□□□■");
            //Console.WriteLine("■□■■■□■□■□■□■□■");
            //Console.WriteLine("■□■□■■■□■■■□■□■");
            //Console.WriteLine("■□■□□□□□□□□□■□■");
            //Console.WriteLine("■□■■■■■□■■■■■□■");
            //Console.WriteLine("■□□□■□□□□□■□□□■");
            //Console.WriteLine("■□■■■■■□■□■□■■■");
            //Console.WriteLine("■□□□□□□□■□■□□□■");
            //Console.WriteLine("■■■■■■■■■■■■■□■");

            int[,] maze = new int[,]
            {
            { 1,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,0,0,0,0,0,1,0,1,0,0,0,0,0,1 },
            { 1,0,1,1,1,0,1,0,1,0,1,0,1,0,1 },
            { 1,0,1,0,1,1,1,0,1,1,1,0,1,0,1 },
            { 1,0,1,0,0,0,0,0,0,0,0,0,1,0,1 },
            { 1,0,1,1,1,1,1,0,1,1,1,1,1,0,1 },
            { 1,0,0,0,1,0,0,0,0,0,1,0,0,0,1 },
            { 1,0,1,1,1,1,1,0,1,0,1,0,1,1,1 },
            { 1,0,0,0,0,0,0,0,1,0,1,0,0,0,1 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,0,1 }
             };

            while (true)
            {
                Console.Clear();
              
                for(int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 15; col++)
                    {
                        Console.Write(maze[row, col] == 1 ? "■" : "□");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($"┃                  ┃");
                Console.WriteLine($"┃총 이동횟수: {count:D4} ┃");
                Console.WriteLine($"┃                  ┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━┛");

                Console.SetCursorPosition(targetX, targetY);
                Console.Write("🏠");//목적지
                Console.SetCursorPosition(x, y);
                Console.Write("●");//현재위치
                if (x == targetX && y == targetY)
                {
                    Console.Clear();
                    Console.WriteLine($"\n총 이동횟수: {count}\n");
                    break;
                }

                keyInfo = Console.ReadKey(true);//키 입력 받기(출력x)
                int newX = x;
                int newY = y;

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: newY=y-1; break;
                    case ConsoleKey.DownArrow: newY=y+1; break;
                    case ConsoleKey.LeftArrow: newX=x-1; break;
                    case ConsoleKey.RightArrow: newX = x+1; break;
                }
                if (newX >= 0 && newX < 15 && newY >= 0 && newY < 10 && maze[newY, newX] == 0)
                {
                    x = newX;
                    y = newY;
                    count++;
                }

            }
        }
    }
}
