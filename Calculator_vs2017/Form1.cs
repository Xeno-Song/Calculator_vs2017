using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_vs2017
{
	public partial class Form1 : Form
	{
		public bool is_buffered;
		public int num;
		public int num_buffer;

		Calculation calc;

		public Form1()
		{
			InitializeComponent();

			num = 0;
			is_buffered = false;
			num_buffer = 0;

			SetTextOutput(0);
			calc = new Calculation();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			AddNumBelow(3, ref num);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			AddNumBelow(0, ref num);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			AddNumBelow(1, ref num);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			AddNumBelow(2, ref num);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddNumBelow(4, ref num);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddNumBelow(5, ref num);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddNumBelow(6, ref num);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddNumBelow(7, ref num);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			AddNumBelow(8, ref num);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AddNumBelow(9, ref num);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			SetNumToBuffer();
			calc.SetOperator(Operator.Plus);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			SetNumToBuffer();
			calc.SetOperator(Operator.Minus);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			SetNumToBuffer();
			calc.SetOperator(Operator.Multiply);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			SetNumToBuffer();
			calc.SetOperator(Operator.Devide);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			double result = 0.0;
			SetNumToBuffer();
			result = calc.GetCalculationResult();

			num_buffer = (int)result;
			calc.SetFirstNum(num_buffer);

			SetTextOutput(result);
		}

		private int AddNumBelow(int _num, ref int result)
		{
			result = result * 10 + _num;
			SetTextOutput(result);

			return result;
		}

		private void SetNumToBuffer()
		{
			if (is_buffered)
				calc.SetSecondNum(num);
			else
				calc.SetFirstNum(num);

			is_buffered = true;
			SetTextOutput(0);

			num_buffer = num;
			num = 0;
		}

		private void SetTextOutput(int _num)
		{
			ResultText.Text = _num.ToString();
		}

		private void SetTextOutput(double _num)
		{
			ResultText.Text = _num.ToString();
		}
	}
}
