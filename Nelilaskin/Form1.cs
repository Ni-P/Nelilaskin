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

        private void updateText(string s, bool clear = false)
        {
            if (clear) output.Text = String.Empty;
            if (output.Text.Equals("0")) // replace zero with a number or op
            {
                if (s.Equals(","))
                {
                    output.Text += s;
                } else
                {
                output.Text = s;
                }

            } else if (s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/")) // setting op on screen
            {
                output.Text = s;
            }
            else
            {
                if (output.Text.Equals("+") || output.Text.Equals("-") || output.Text.Equals("*") || output.Text.Equals("/")) // replace op with number
                {
                    output.Text = s;
                } else
                {
                    output.Text += s;
                }
            }
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

        private void setEqual(object sender, EventArgs e)
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

        private void output_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            else if (e.KeyChar == (char)Keys.Enter) setEqual(sender, e);
            else if (e.KeyChar == (char)Keys.Escape) clearAll(sender, e);
            else if (e.KeyChar == ',' || e.KeyChar == '.') setFraction(sender, e);
        }   
    }
}
