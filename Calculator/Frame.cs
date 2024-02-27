using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleButton
{
    public class Frame
    {
        private List<Box> _controlList;
        int _index = 0;
        public Frame() 
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.CursorVisible = false;
            _controlList = new List<Box>();
        }

        public void AddControl(Button control)
        {
            if(control != null)
            {
                _controlList.Add(control);
                control.Draw();
            }
        }
        public void AddControl(Screen control)
        {
            if (control != null)
            {
                _controlList.Add(control);
                control.Draw();
            }
        }

        public void Show()
        {
            /*foreach(var box in _controlList)
            {
                box.Draw();
            }*/

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                string keyString = ReturnKeyChar(key);
                if(key == ConsoleKey.Tab)
                {
                    if(_index>0)
                    {
                        _controlList[_index - 1].Draw();
                    }
                    TabClicked();
                    _index++;
                }
                else 
                if(key == ConsoleKey.Spacebar)
                {
                    Button defaultButton = (Button)_controlList[_index - 1];
                    ConsoleKey buttonKey = defaultButton.Key;
                    string defaultKeyString = ReturnKeyChar(buttonKey);
                    Screen screen = (Screen)_controlList[_controlList.Count - 1];
                    screen.Update(defaultKeyString);
                    screen.Draw();
                }
                else
                {
                    if (_index > 0)
                    {
                        _controlList[_index - 1].Draw();
                        _index = 0;
                    }

                    IsKey(key);
                    Screen screen = (Screen)_controlList[_controlList.Count - 1];
                    screen.Update(keyString);
                    screen.Draw();
                }
            }
        }

        public void TabClicked()
        {
            

            if (_index == _controlList.Count - 1)
            {
                _index = 0;
            }

            for(int i = 0; i< _controlList.Count; i++)
            {
                if(_index == i)
                {
                    _controlList[i].Highlight();
                    break;
                }
                
            }
            
        }

        public void IsKey(ConsoleKey key)
        {
            if (key != null)
            {
                foreach (Button control in _controlList)
                {
                    if(control.Key == key)
                    {
                        control.click();
                        System.Threading.Thread.Sleep(100);
                        control.Draw();
                        break;
                    }
                }
            }
        }

        public string ReturnKeyChar(ConsoleKey key)
        {
            if (key == ConsoleKey.D1)
            {
                return "1";
            }
            else if (key == ConsoleKey.D2)
            {
                return "2";
            }
            else if (key == ConsoleKey.D3)
            {
                return "3";
            }
            else if (key == ConsoleKey.D4)
            {
                return "4";
            }
            else if (key == ConsoleKey.D5)
            {
                return "5";
            }
            else if (key == ConsoleKey.D6)
            {
                return "6";
            }
            else if (key == ConsoleKey.D7)
            {
                return "7";
            }
            else if (key == ConsoleKey.D8)
            {
                return "8";
            }
            else if (key == ConsoleKey.D9)
            {
                return "9";
            }
            else if (key == ConsoleKey.Backspace)
            {
                return "AC";

            }
            else if (key == ConsoleKey.Add)
            {
                return "+";
            }
            else if (key == ConsoleKey.Subtract)
            {
                return "-";
            }
            else if (key == ConsoleKey.D0)
            {
                return "0";
            }
            else if (key == ConsoleKey.Multiply)
            {
                return "*";
            }
            else if (key == ConsoleKey.Divide)
            {
                return "/";
            }
            else if (key == ConsoleKey.Enter)
            {
                return "=";
            }
            return "";
        }
    }
}
