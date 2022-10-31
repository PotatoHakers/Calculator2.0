using System.Windows.Forms;

namespace Calculator.Method
{
    public class CalculateMethod
    {
        public string Calculate(float a, int count, string textBox)
        {

            switch (count)
            {
                case 1:
                    textBox = (a + float.Parse(textBox)).ToString();
                    return textBox;
                case 2:
                    textBox = (a - float.Parse(textBox)).ToString();
                    return textBox;
                case 3:
                    textBox = (a * float.Parse(textBox)).ToString();
                    return textBox;
                case 4:
                    if (float.Parse(textBox).ToString() == "0")
                    {
                        return "NOT ÷ 0";
                    }
                    else
                    {
                        textBox = (a / float.Parse(textBox)).ToString();
                        return textBox;
                    }
                    

                default: return "0";

            }
           return "0";
        }

        public void KeyboardEnteringNumber(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!System.Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }
    }
}
