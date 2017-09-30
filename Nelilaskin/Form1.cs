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
            //laskin.AddDigit("0");
            this.outputComponent.Select();
        }

        private void updateText(string s, bool clear = false)
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

        private void clearAll(object sender, EventArgs e)
        {
            updateText("0", true);
            laskin.ClearAll();
        }

        private void setAddition(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.ADDITION))
            {
                updateText("+", true);

            }
        }

        private void setSubtraction(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.SUBTRACTION))
            {
                updateText("-", true);

            }
        }

        private void setMultiplication(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.MULTIPLICATION))
            {
                updateText("*", true);

            }
        }

        private void setDivision(object sender, EventArgs e)
        {
            if (laskin.SetOperation(Operations.DIVISION))
            {
                updateText("/", true);

            }
        }

        private void setEqual()
        {
            if(laskin.Calculate())
            {
                updateText(laskin.GetResult(), true);
            }
        }

        private void setFraction(object sender, EventArgs e)
        {
            if (laskin.AddDigit(","))
            {
                updateText(",");

            }
        }

        private void setOne(object sender, EventArgs e)
        {
            if (laskin.AddDigit("1"))
            {
                updateText("1");
            }


        }

        private void setTwo(object sender, EventArgs e)
        {
           if (laskin.AddDigit("2"))
            {
                updateText("2");
            }
        }

        private void setThree(object sender, EventArgs e)
        {
            if (laskin.AddDigit("3"))
            {
                updateText("3");
            }
        }

        private void setFour(object sender, EventArgs e)
        {
            if (laskin.AddDigit("4"))
            {
                updateText("4");
            }
        }

        private void setFive(object sender, EventArgs e)
        {
            if (laskin.AddDigit("5"))
            {
                updateText("5");
            }
        }

        private void setSix(object sender, EventArgs e)
        {
            if (laskin.AddDigit("6"))
            {
                updateText("6");
            }
        }

        private void setSeven(object sender, EventArgs e)
        {
            if (laskin.AddDigit("7"))
            {
                updateText("7");
            }
        }

        private void setEight(object sender, EventArgs e)
        {
            if (laskin.AddDigit("8"))
            {
                updateText("8");
            }
        }

        private void setNine(object sender, EventArgs e)
        {
            if (laskin.AddDigit("9"))
            {
                updateText("9");
            }
        }

        private void setZero(object sender, EventArgs e)
        {
            
            if (laskin.AddDigit("0"))
            {
                updateText("0");
            }
        }

        private void window_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Select();
            //Console.WriteLine("pressed: " + e.KeyChar);
            if (e.KeyChar == (char)Keys.D1) setOne(sender, e);
            else if (e.KeyChar == (char)Keys.D2) setTwo(sender, e);
            else if (e.KeyChar == (char)Keys.D3) setThree(sender, e);
            else if (e.KeyChar == (char)Keys.D4) setFour(sender, e);
            else if (e.KeyChar == (char)Keys.D5) setFive(sender, e);
            else if (e.KeyChar == (char)Keys.D6) setSix(sender, e);
            else if (e.KeyChar == (char)Keys.D7) setSeven(sender, e);
            else if (e.KeyChar == (char)Keys.D8) setEight(sender, e);
            else if (e.KeyChar == (char)Keys.D9) setNine(sender, e);
            else if (e.KeyChar == (char)Keys.D0) setZero(sender, e);
            else if (e.KeyChar == '+') setAddition(sender, e);
            else if (e.KeyChar == '-') setSubtraction(sender, e);
            else if (e.KeyChar == '*') setMultiplication(sender, e);
            else if (e.KeyChar == '/') setDivision(sender, e);
            else if (e.KeyChar == 'r')
            {
                //this.btn_equal.Select();
                //Console.WriteLine("ENTER");
                setEqual();
            }
            else if (e.KeyChar == (char)Keys.Escape) clearAll(sender, e);
            else if (e.KeyChar == ',' || e.KeyChar == '.') setFraction(sender, e);
            else if (e.KeyChar == (char)Keys.Back)
            {
                Console.WriteLine("BACKSPACE");
                setUndo();
            }
        }

        private void setOne(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("1"))
            {
                updateText("1");
            }
            resetButtons();

        }

        private void setTwo(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("2"))
            {
                updateText("2");
            }
            resetButtons();
        }

        private void setThree(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("3"))
            {
                updateText("3");
            }
            resetButtons();
        }

        private void setFour(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("4"))
            {
                updateText("4");
            }
            resetButtons();
        }

        private void setFive(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("5"))
            {
                updateText("5");
            }
            resetButtons();
        }

        private void setSix(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("6"))
            {
                updateText("6");
            }
            resetButtons();
        }

        private void setSeven(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("7"))
            {
                updateText("7");
            }
            resetButtons();
        }

        private void setEight(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("8"))
            {
                updateText("8");
            }
                resetButtons();
        }

        private void setNine(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("9"))
            {
                updateText("9");
            }
                resetButtons();
        }

        private void setZero(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit("0"))
            {
                updateText("0");
            }
            resetButtons();
        }

        private void setFraction(object sender, MouseEventArgs e)
        {
            if (laskin.AddDigit(","))
            {
                updateText(",");

            }
            resetButtons();
        }

        private void setAddition(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.ADDITION))
            {
                updateText("+", true);

            }
                resetButtons();
        }

        private void setSubtraction(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.SUBTRACTION))
            {
                updateText("-", true);

            }
            resetButtons();
        }

        private void setMultiplication(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.MULTIPLICATION))
            {
                updateText("*", true);

            }
            resetButtons();
        }

        private void setDivision(object sender, MouseEventArgs e)
        {
            if (laskin.SetOperation(Operations.DIVISION))
            {
                updateText("/", true);

            }
            resetButtons();
        }

        private void clearAll(object sender, MouseEventArgs e)
        {
            updateText("0", true);
            laskin.ClearAll();
            resetButtons();
        }

        private void setEqual(object sender, MouseEventArgs e)
        {
            if (laskin.Calculate())
            {
                updateText(laskin.GetResult(), true);
            }
            resetButtons();
        }

        private void handleEnter(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                setEqual();
            resetButtons();
        }

        private void resetButtons()
        {
            btn_equal.Enabled = false;
            btn_equal.Enabled = true;
            btn_1.Enabled = false;
            btn_1.Enabled = true;
            btn_2.Enabled = false;
            btn_2.Enabled = true;
            btn_3.Enabled = false;
            btn_3.Enabled = true;
            btn_4.Enabled = false;
            btn_4.Enabled = true;
            btn_5.Enabled = false;
            btn_5.Enabled = true;
            btn_6.Enabled = false;
            btn_6.Enabled = true;
            btn_7.Enabled = false;
            btn_7.Enabled = true;
            btn_8.Enabled = false;
            btn_8.Enabled = true;
            btn_9.Enabled = false;
            btn_9.Enabled = true;
            btn_0.Enabled = false;
            btn_0.Enabled = true;
            btn_addition.Enabled = false;
            btn_addition.Enabled = true;
            btn_subtraction.Enabled = false;
            btn_subtraction.Enabled = true;
            btn_multiplication.Enabled = false;
            btn_multiplication.Enabled = true;
            btn_division.Enabled = false;
            btn_division.Enabled = true;
            btn_clear.Enabled = false;
            btn_clear.Enabled = true;
            btn_fraction.Enabled = false;
            btn_fraction.Enabled = true;
            //btn_.Enabled = true;
            //btn_.Enabled = false;
            //btn_.Enabled = true;

        }

        private void removeLastDigit(object sender, MouseEventArgs e)
        {
            setUndo();
            resetButtons();
        }

        private void setUndo()
        {
            if (laskin.undoEntry())
            {
                int pos = outputComponent.Text.Length-1;
                updateText(outputComponent.Text.Remove(pos), true);
            }
        }
    }
}
