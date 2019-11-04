﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Значение x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Значение y не может быть отрицательным");
            
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.SetSym('(');
            p.Draw(5, 5);
            p.SetSym(')');
            p.Draw(6, 5);
            p.SetSym('|');
            p.Draw(5, 6);
            p.SetSym('|');
            p.Draw(6, 6);
            p.SetSym('/');
            p.Draw(5, 7);
            p.SetSym('\\');
            p.Draw(6, 7);
            Console.ReadKey();
        }
    }
}
