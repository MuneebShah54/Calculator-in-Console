namespace ConsoleButton
{
    public class Box
    {
        protected int _left;
        protected int _top;
        protected int _width;
        protected int _height;
        protected string _text;
        public Box(int left, int top, int width, int height, string text)
        {
            _left = left;
            _top = top;
            _width = width;
            _height = height;   
            _text = text;
        }
        public int Left { get { return _left; } set { _left = value; } }
        public virtual void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(_left, _top);
            Console.Write("┌");

            for(int i=0; i<_width; i++)
            {
                Console.Write("─");
            }
            
            Console.Write("┐");
            
            for(int i=1; i<_height; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(_left, _top+i);

                Console.Write("│");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.SetCursorPosition(_left + _width+1 , _top + i);
                Console.Write("│");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(_left, _top + _height);
            Console.Write("└");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.Write("┘");
        }

        public void Highlight()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_left, _top);
            Console.Write("┌");

            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.Write("┐");

            for (int i = 1; i < _height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(_left, _top + i);

                Console.Write("│");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(_left + _width + 1, _top + i);
                Console.Write("│");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(_left, _top + _height);
            Console.Write("└");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.Write("┘");
        }



    }
}
