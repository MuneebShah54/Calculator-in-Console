
namespace ConsoleButton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Frame frame= new Frame();
    

            //Creating buttons

            Button button1 = new Button(2, 5, 7, 4, "1", ConsoleKey.D1);
            Button button2 = new Button(11, 5, 7, 4, "2", ConsoleKey.D2);
            Button button3 = new Button(20, 5, 7, 4, "3", ConsoleKey.D3);
            Button buttonBack = new Button(29, 5, 7, 4, "AC", ConsoleKey.Backspace);
            Button button4 = new Button(2, 10, 7, 4, "4", ConsoleKey.D4);
            Button button5 = new Button(11, 10, 7, 4, "5", ConsoleKey.D5);
            Button button6 = new Button(20, 10, 7, 4, "6", ConsoleKey.D6);
            Button buttonPlus = new Button(29, 10, 7, 4, "+", ConsoleKey.Add);
            Button button7 = new Button(2, 15, 7, 4, "7", ConsoleKey.D7);
            Button button8 = new Button(11, 15, 7, 4, "8", ConsoleKey.D8);
            Button button9 = new Button(20, 15, 7, 4, "9", ConsoleKey.D9);
            Button buttonMinus = new Button(29, 15, 7, 4, "-", ConsoleKey.Subtract);
            Button button0 = new Button(2, 20, 7, 4, "0", ConsoleKey.D0);
            Button buttonMultiply = new Button(11, 20, 7, 4, "*", ConsoleKey.Multiply);
            Button buttonDivide = new Button(20, 20, 7, 4, "/", ConsoleKey.Divide);
            Button buttonEqual = new Button(29, 20, 7, 4, "=", ConsoleKey.Enter);

            //Creating Screen
            Screen screen = new Screen(2, 1, 34, 3, "");

            frame.AddControl(button1);
            frame.AddControl(button2);
            frame.AddControl(button3);
            frame.AddControl(button4);
            frame.AddControl(button5);
            frame.AddControl(button6);
            frame.AddControl(button7);
            frame.AddControl(button8);
            frame.AddControl(button9);
            frame.AddControl(button0);
            frame.AddControl(buttonMinus);
            frame.AddControl(buttonMultiply);
            frame.AddControl(buttonDivide);
            frame.AddControl(buttonEqual);
            frame.AddControl(buttonPlus);
            frame.AddControl(buttonBack);
            frame.AddControl(screen);

            frame.Show();

            //Display calculator

            
        }
    }
}