using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double _res;
        private bool bl;
        private string _symbol;

        private void One_Click(object sender, EventArgs e)
        {
            InputBox.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            InputBox.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            InputBox.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            InputBox.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            InputBox.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            InputBox.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            InputBox.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            InputBox.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            InputBox.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            InputBox.Text += 0;
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(InputBox.Text) > 0)
            {
                InputBox.Text = "-" + InputBox.Text;
            }
            else
            {
                InputBox.Text = Math.Abs(Convert.ToDouble(InputBox.Text)).ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            _symbol = null;
            _res = 0;
            ResultBox.Clear();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (InputBox.Text.Count() > 0)
                _res = _res + Convert.ToDouble(InputBox.Text);
            InputBox.Clear();

            _symbol = Plus.Text;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (InputBox.Text.Count() > 0)
                _res = _res - Convert.ToDouble(InputBox.Text);
            InputBox.Clear();

            _symbol = Minus.Text;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (_res == 0) _res = 1;
            if (InputBox.Text.Count() > 0)
                _res = _res * Convert.ToDouble(InputBox.Text);
            InputBox.Clear();

            _symbol = Multiply.Text;
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            if (_res == 0) _res = 1;
            if (InputBox.Text.Count() > 0)
                _res = _res / Convert.ToDouble(InputBox.Text);
            InputBox.Clear();

            _symbol = Devide.Text;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (_symbol == Plus.Text) _res = _res + Convert.ToDouble(InputBox.Text);
            else
            {
                if (_symbol == Minus.Text) _res = _res - Convert.ToDouble(InputBox.Text);
                else
                {
                    if (_symbol == Multiply.Text) _res = _res * Convert.ToDouble(InputBox.Text);
                    else
                    {
                        if (_symbol == Devide.Text) _res = _res / Convert.ToDouble(InputBox.Text);
                        else
                        {
                            if (InputBox.Text.Count() > 0)
                                _res = Convert.ToDouble(InputBox.Text);
                        }
                    }
                }
            }

            _symbol = null;
            InputBox.Clear();
            ResultBox.Text = _res.ToString();
        }

        private void Standart_CheckedChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(163, 279);
            this.Sqr.Location = new System.Drawing.Point(180, 98);
            this.PI.Location = new System.Drawing.Point(180, 134);
            this.Log.Location = new System.Drawing.Point(180, 206);
            this.Point.Location = new System.Drawing.Point(180, 170);
            this.ResultBox.Size = new System.Drawing.Size(138, 25);
            this.InputBox.Size = new System.Drawing.Size(138, 25);
            this.Equal.Size = new System.Drawing.Size(138, 30);
        }

        private void Engineer_CheckedChanged(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(205, 279);
            this.Sqr.Location = new System.Drawing.Point(155, 98);
            this.PI.Location = new System.Drawing.Point(155, 134);
            this.Log.Location = new System.Drawing.Point(155, 206);
            this.Point.Location = new System.Drawing.Point(155, 170);
            this.ResultBox.Size = new System.Drawing.Size(180, 25);
            this.InputBox.Size = new System.Drawing.Size(180, 25);
            this.Equal.Size = new System.Drawing.Size(180, 30);

        }

    }
}
