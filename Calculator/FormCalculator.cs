using System;
using Calculator.Method;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        int _a;
        int _count;
        bool _sigh = true;
        CalculateMethod _calculateMethod = new CalculateMethod();

        public FormCalculator()
        {
            InitializeComponent();

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 0;
        }

        private void buttonNumberOne_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 1;
        }

        private void buttonNumberTwo_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 2;
        }

        private void buttonNumberThree_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 3;
        }

        private void buttonNumberFour_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 4;
        }

        private void buttonNumberFive_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 5;
        }

        private void buttonNumberSix_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 6;
        }

        private void buttonNumberSeven_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 7;
        }

        private void buttonNumberEight_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 8;
        }

        private void buttonNumberNine_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + 9;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            labelFirstNumber.Text = "";
        }

        /* private void buttonDouble_Click(object sender, EventArgs e)
         {
             if (textBoxResult.Text.IndexOf(",") == -1)
             {
                 textBoxResult.Text += ",";
             }
         }*/

        private void textBoxResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            _calculateMethod.KeyboardEnteringNumber(e);
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _a = int.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            _count = 1;
            labelFirstNumber.Text = _a.ToString() + "+";
            _sigh = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = _calculateMethod.Calculate(_a, _count, textBoxResult.Text);
            labelFirstNumber.Text = "";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _a = int.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            _count = 2;
            labelFirstNumber.Text = _a.ToString() + "-";
            _sigh = true;
        }

        private void buttonMyltiply_Click(object sender, EventArgs e)
        {
            _a = int.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            _count = 3;
            labelFirstNumber.Text = _a.ToString() + "*";
            _sigh = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            _a = int.Parse(textBoxResult.Text);
            textBoxResult.Clear();
            _count = 4;
            labelFirstNumber.Text = _a.ToString() + "/";
            _sigh = true;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (_sigh == true)
            {
                textBoxResult.Text = "-" + textBoxResult.Text;
                _sigh = false;
            }
            else if (_sigh == false)
            {
                textBoxResult.Text = textBoxResult.Text.Replace("-", "");
                _sigh = true;
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 9)
            {
                textBoxResult.Text = "EXCEEDED";
            }
        }
    }
}

