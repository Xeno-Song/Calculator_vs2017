using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_vs2017
{
	public enum Operator
	{
		Plus,
		Minus,
		Multiply,
		Devide
	}

	class Calculation
	{
		public double num1 { get; protected set; }
		public double num2 { get; protected set; }
		public Operator calc_operator { get; protected set; }

		public Calculation()
		{
			num1 = 0;
			num2 = 0;
		}

		public void SetFirstNum(double _num1)
		{
			num1 = _num1;
		}

		public void SetFirstNum(int _num1)
		{
			num1 = (double)_num1;
		}

		public void SetSecondNum(double _num2)
		{
			num2 = _num2;
		}

		public void SetSecondNum(int _num2)
		{
			num2 = (double)_num2;
		}

		public void SetOperator(Operator _calc_operator)
		{
			calc_operator = _calc_operator;
		}

		public double GetCalculationResult()
		{
			double result = 0.0;

			switch(calc_operator)
			{
				case Operator.Plus:
				{
					result = num1 + num2;
					break;
				}

				case Operator.Minus:
				{
					result = num1 - num2;
					break;
				}

				case Operator.Multiply:
				{
					result = num1 * num2;
					break;
				}

				case Operator.Devide:
				{
					if(Math.Abs(num2) < 0.000000001)
					{
						MessageBox.Show("Cannot device to 0");
						break;
					}

					result = num1 / num2;
					break;
				}
			}

			return result;
		}
	}
}
