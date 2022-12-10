using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGame
{
    internal class Game
    {
        public void start()
        {
            char[,] Field = new char[15, 30];
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Field[i, j] = ' ';
                    Console.Write(Field[i, j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
            int x = 0;
            int y = 0;
            bool player=true;
            Console.SetCursorPosition(x, y);
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                switch(consoleKeyInfo.Key)
                {
                    case ConsoleKey.W:
                        MoveUp     (Field, ref x, ref y);
                        break;
                    case ConsoleKey.A:
                        MoveLeft   (Field, ref x, ref y);
                        break;
                    case ConsoleKey.S:
                        MoveDown   (Field, ref x, ref y);
                        break;
                    case ConsoleKey.D:
                        MoveRight  (Field, ref x, ref y);
                        break;
                    case ConsoleKey.Enter:               
                            if (Field[y, x] == 'X' || Field[y, x] == '0') break;
                            Field[y, x] = player ? 'X' : '0';
                            player = !player;
                            rePrintArr(Field);
                            Console.SetCursorPosition(x, y);
                        break;
                }

            }
            Console.ReadLine();
        }
        #region [Moving]
        public void MoveUp(char[,]arr, ref int x, ref int y)
        {
            if (y > arr.GetLength(0) - 1) x = 0;
            if (y > arr.GetLength(1) - 1) y = 0;
            if (x < 0)                    x = arr.GetLength(0) - 1;
            if (y < 0)                    y = arr.GetLength(1) - 1;
            try {       Console.SetCursorPosition(x   , y -- ); }
            catch (Exception) { }
        }

        public void MoveDown(char[,] arr, ref int x, ref int y)
        {
            if (x > arr.GetLength(0) - 1) x = 0;
            if (y > arr.GetLength(1) - 1) y = 0;
            if (x < 0)                    x = arr.GetLength(0) - 1;
            if (y < 0)                    y = arr.GetLength(1) - 1;
            try {       Console.SetCursorPosition(x   , y ++ ); }
            catch (Exception) { }
        }

        public void MoveLeft(char[,] arr, ref int x, ref int y)
        {
            if (x > arr.GetLength(0) - 1) x = 0;
            if (y > arr.GetLength(1) - 1) y = 0;
            if (x < 0)                    x = arr.GetLength(0) - 1;
            if (y < 0)                    y = arr.GetLength(1) - 1;
            try {       Console.SetCursorPosition(x --, y    ); }
            catch (Exception) { }
        }
               
        public void MoveRight(char[,] arr, ref int x, ref int y)
        {
            if (x > arr.GetLength(0) - 1) x = 0;
            if (y > arr.GetLength(1) - 1) y = 0;
            if (x < 0)                    x = arr.GetLength(0) - 1;
            if (y < 0)                    y = arr.GetLength(1) - 1;
            try {       Console.SetCursorPosition(x ++, y    ); }
            catch (Exception) {  }
        }
        #endregion
        public void Seeking(Array[,] arr, int x,int y)
        {
           
        }
        public void rePrintArr(char[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine("|");
            }
        }
    }
}
