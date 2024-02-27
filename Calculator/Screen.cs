
namespace ConsoleButton
{
    public class Screen : Box
    {
        private char _operator;
        private double _number1;
        private double _number2;
        private double _result;
        public Screen(int left, int top, int width, int height, string text) : base(left, top, width, height, text)
        {
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(_left, _top);
            Console.Write("┌");

            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

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

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(_left, _top + _height);
            Console.Write("└");

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < _width; i++)
            {
                Console.Write("─");
            }

            Console.Write("┘");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(_left + 1, _top + 1);
            Console.Write(_text);
        }

        public void EmptyScreen()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(_left + 1, _top + 1);
            for (int i = 0; i < _width; i++)
            {
                Console.Write(" ");
            }
        }

        public void Update(string key)
        {
            switch (key)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    _text += key;
                    break;
                case "+":
                    {
                        _operator = '+';
                        _number1 = Convert.ToDouble(_text);
                        _text = "";
                        EmptyScreen();
                    }
                    break;
                case "-":
                    {
                        _operator = '-';
                        _number1 = Convert.ToDouble(_text);
                        _text = "";
                        EmptyScreen();
                    }
                    break;
                case "*":
                    {
                        _operator = '*';
                        _number1 = Convert.ToDouble(_text);
                        _text = "";
                        EmptyScreen();
                    }
                    break;
                case "/":
                    {
                        _operator = '/';
                        _number1 = Convert.ToDouble(_text);
                        _text = "";
                        EmptyScreen();
                    }
                    break;
                case "=":
                    {
                        _number2 = Convert.ToDouble(_text);

                        switch (_operator)
                        {
                            case '+':
                                {
                                    _result = _number1 + _number2;
                                    _text = Convert.ToString(_result);
                                }

                                break;
                            case '-':
                                {
                                    _result = _number1 - _number2;
                                    _text = Convert.ToString(_result);
                                }
                                break;
                            case '*':
                                {
                                    _result = _number1 * _number2;
                                    _text = Convert.ToString(_result);
                                }
                                break;
                            case '/':
                                {
                                    _result = _number1 / _number2;
                                    _text = Convert.ToString(_result);
                                }
                                break;
                        }
                    }
                    break;
                case "AC":
                    {
                        _text = "";
                        EmptyScreen();
                    }
                    break;
            }
        }
    }
}
