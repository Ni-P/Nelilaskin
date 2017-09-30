using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelilaskin
{
    public partial class Nelilaskin : Form
    {
        private Laskin laskin;

        public Nelilaskin()
        {
            InitializeComponent();
            laskin = new Laskin();
            

        }

        private void UpdateText(string s, bool clear = false)
        {
            if (clear) outputComponent.Text = String.Empty;
            if (outputComponent.Text.Equals("0")) // replace zero with a number or op
            {
                if (s.Equals(","))
                {
                    outputComponent.Text += s;
                } else
                {
                    outputComponent.Text = s;
                }

            } else if (s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/")) // setting op on screen
            {
                outputComponent.Text = s;
            }
            else
            {
                if (outputComponent.Text.Equals("+") || outputComponent.Text.Equals("-") || outputComponent.Text.Equals("*") || outputComponent.Text.Equals("/")) // replace op with number
                {
                    outputComponent.Text = s;
                } else
                {
                    outputComponent.Text += s;
                }
            }
            if (outputComponent.Text.Length == 0) outputComponent.Text = "0";
        }

        private void ClearAll(object sender, EventArgs e)
        {
            UpdateText("0", true);
            laskin.ClearAll();
        }

        private void SetAddition(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.ADDITION))
            {
                UpdateText("+", true);

            }
        }

        private void SetSubtraction(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.SUBTRACTION))
            {
                UpdateText("-", true);

            }
        }

        private void SetMultiplication(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.MULTIPLICATION))
            {
                UpdateText("*", true);

            }
        }

        private void SetDivision(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.DIVISION))
            {
                UpdateText("/", true);

            }
        }

        private void SetEqual()
        {
            if(laskin.Calculate())
            {
                UpdateText(laskin.GetResult(), true);
            }
        }

        private void SetFraction(object sender, EventArgs e)
        {
            if (laskin.AddDigit(","))
            {
                UpdateText(",");

            }
        }

        private void SetOne(object sender, EventArgs e)
        {
            if (laskin.AddDigit("1"))
            {
                UpdateText("1");
            }


        }

        private void SetTwo(object sender, EventArgs e)
        {
           if (laskin.AddDigit("2"))
            {
                UpdateText("2");
            }
        }

        private void SetThree(object sender, EventArgs e)
        {
            if (laskin.AddDigit("3"))
            {
                UpdateText("3");
            }
        }

        private void SetFour(object sender, EventArgs e)
        {
            if (laskin.AddDigit("4"))
            {
                UpdateText("4");
            }
        }

        private void SetFive(object sender, EventArgs e)
        {
            if (laskin.AddDigit("5"))
            {
                UpdateText("5");
            }
        }

        private void SetSix(object sender, EventArgs e)
        {
            if (laskin.AddDigit("6"))
            {
                UpdateText("6");
            }
        }

        private void SetSeven(object sender, EventArgs e)
        {
            if (laskin.AddDigit("7"))
            {
                UpdateText("7");
            }
        }

        private void SetEight(object sender, EventArgs e)
        {
            if (laskin.AddDigit("8"))
            {
                UpdateText("8");
            }
        }

        private void SetNine(object sender, EventArgs e)
        {
            if (laskin.AddDigit("9"))
            {
                UpdateText("9");
            }
        }

        private void SetZero(object sender, EventArgs e)
        {
            
            if (laskin.AddDigit("0"))
            {
                UpdateText("0");
            }
        }

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("pressed: " + (int)e.KeyChar);
            if (e.KeyChar == (char)Keys.D1) SetOne(sender, e);
            else if (e.KeyChar == (char)Keys.D2) SetTwo(sender, e);
            else if (e.KeyChar == (char)Keys.D3) SetThree(sender, e);
            else if (e.KeyChar == (char)Keys.D4) SetFour(sender, e);
            else if (e.KeyChar == (char)Keys.D5) SetFive(sender, e);
            else if (e.KeyChar == (char)Keys.D6) SetSix(sender, e);
            else if (e.KeyChar == (char)Keys.D7) SetSeven(sender, e);
            else if (e.KeyChar == (char)Keys.D8) SetEight(sender, e);
            else if (e.KeyChar == (char)Keys.D9) SetNine(sender, e);
            else if (e.KeyChar == (char)Keys.D0) SetZero(sender, e);
            else if (e.KeyChar == '+') SetAddition(sender, e);
            else if (e.KeyChar == '-') SetSubtraction(sender, e);
            else if (e.KeyChar == '*') SetMultiplication(sender, e);
            else if (e.KeyChar == '/') SetDivision(sender, e);
            else if (e.KeyChar == (char)Keys.Space || e.KeyChar == '\n' || e.KeyChar == (char)Keys.Enter)
            {
                SetEqual();
            }
            else if (e.KeyChar == (char)Keys.Escape) ClearAll(sender, e);
            else if (e.KeyChar == ',' || e.KeyChar == '.') SetFraction(sender, e);
            else if (e.KeyChar == (char)Keys.Back)
            {
                Console.WriteLine("BACKSPACE");
                SetUndo();
            }
        }

        private void SetOne(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("1"))
            {
                UpdateText("1");
            }
            

        }

        private void SetTwo(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("2"))
            {
                UpdateText("2");
            }
            
        }

        private void SetThree(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("3"))
            {
                UpdateText("3");
            }
            
        }

        private void SetFour(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("4"))
            {
                UpdateText("4");
            }
            
        }

        private void SetFive(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("5"))
            {
                UpdateText("5");
            }
            
        }

        private void SetSix(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("6"))
            {
                UpdateText("6");
            }
            
        }

        private void SetSeven(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("7"))
            {
                UpdateText("7");
            }
            
        }

        private void SetEight(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("8"))
            {
                UpdateText("8");
            }
                
        }

        private void SetNine(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("9"))
            {
                UpdateText("9");
            }
                
        }

        private void SetZero(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("0"))
            {
                UpdateText("0");
            }
            
        }

        private void SetFraction(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit(","))
            {
                UpdateText(",");

            }
            
        }

        private void SetAddition(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.ADDITION))
            {
                UpdateText("+", true);

            }
                
        }

        private void SetSubtraction(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.SUBTRACTION))
            {
                UpdateText("-", true);

            }
            
        }

        private void SetMultiplication(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.MULTIPLICATION))
            {
                UpdateText("*", true);

            }
            
        }

        private void SetDivision(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.DIVISION))
            {
                UpdateText("/", true);

            }
            
        }

        private void ClearAll(object sender, MouseEventArgs e)
        {
            UpdateText("0", true);
            laskin.ClearAll();
            
        }

        private void SetEqual(object sender, MouseEventArgs e)
        {
            if (laskin.Calculate())
            {
                UpdateText(laskin.GetResult(), true);
            }
            
        }

        private void HandleEnter(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetEqual();
            
        }

        private void RemoveLastDigit(object sender, MouseEventArgs e)
        {
            SetUndo();
            
        }

        private void SetUndo()
        {
            if (laskin.UndoEntry())
            {
                int pos = outputComponent.Text.Length-1;
                UpdateText(outputComponent.Text.Remove(pos), true);
            }
        }

        private void Btn_equal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {

            if (laskin.Calculate())
            {
                UpdateText(laskin.GetResult(), true);
            }
            }
            
        }
    }
}
