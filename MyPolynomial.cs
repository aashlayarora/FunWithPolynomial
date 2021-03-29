using System;

namespace MyPolynomial
{
	public class MyPolynomial
	{
		private int degree;
		private double[] _coeffs;

		public MyPolynomial(double[] coeffs)
		{
			_coeffs = coeffs;
			degree = coeffs.Length - 1;
		}

		public int GetDegree()
		{
			return degree;
		}

		public override string ToString()
		{
			string PolynomialString = "";

			PolynomialString += _coeffs[0];

			for (int i = 1; i <= GetDegree(); i++)
			{
				if (_coeffs[i] > 0)
				{
					PolynomialString += " + ";
				}
				else if (_coeffs[i] < 0)
				{
					PolynomialString += " - ";
				}

				if (_coeffs[i] != 0)
				{
					PolynomialString += string.Format("{0}x^{1}", Convert.ToString(Math.Abs(_coeffs[i])), i);

				}


			}

			return PolynomialString;
		}

		public double Evaluate(double x)
		{
			double value = 0;

			int currentPower = degree;
			double currentTerm;
			foreach (double arr_coeff in _coeffs) 
			{

				if (arr_coeff == 0)
				{
					currentPower--;
					continue;
				}
				currentTerm = arr_coeff;

				if (currentPower != 0)
				{
					currentTerm *= Math.Pow(x, currentPower);
				}

				value += currentTerm;

				currentPower--;
			}

			return value;
		}

		public MyPolynomial Add(MyPolynomial input)
		{ 

            int min = Math.Min(degree, input.degree) + 1;

            MyPolynomial bigger = degree > input.degree ? this : input;

            double[] sum = new double[bigger.degree + 1];

            for (int i = 0; i < min; i++)
            {
                sum[i] = _coeffs[i] + input._coeffs[i];
            }

            for (int i = min; i < bigger.degree + 1; i++)
            {
                sum[i] = bigger._coeffs[i];
            }

            return new MyPolynomial(sum);
        }

		public MyPolynomial Multiply(MyPolynomial input)
		{

			double[] product = new double[_coeffs.Length + input._coeffs.Length - 1];

			for (int i = 0; i < _coeffs.Length; i++)
			{
				for (int j = 0; j < input._coeffs.Length; j++)
				{
					product[i + j] += _coeffs[i] * input._coeffs[j];

				}

			}

			return new MyPolynomial(product);


		}
	}
}
