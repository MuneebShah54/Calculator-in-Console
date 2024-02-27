using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleButton
{
    public class Button : Box
    {
        private ConsoleKey key;
        public Button(int left, int top, int width, int height, string text, ConsoleKey key) : base(left, top, width, height, text)
        {
            this.key = key;
        }

        public ConsoleKey Key { get { return key; } }

        public void Draw()
        {
            base.Draw();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(_left + Convert.ToInt32(_width / 2) + 1, _top + Convert.ToInt32(_height / 2));
            Console.Write(_text);
        }
        public void click()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(_left, _top);
            Console.Write("┌");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("┐");

            for (int i = 1; i < _height; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(_left, _top + i);

                Console.Write("│");

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(_left + _width + 1, _top + i);
                Console.Write("│");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(_left + Convert.ToInt32(_width / 2) + 1, _top + Convert.ToInt32(_height / 2));
            Console.Write(_text);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(_left, _top + _height);
            Console.Write("└");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.Write("┘");
        }


    }
}
