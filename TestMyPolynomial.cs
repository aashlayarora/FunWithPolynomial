using System;
namespace MyPolynomial
{
	public class TestMyPolynomial
	{
		public static void Main(String[] args)
		{

			MyPolynomial first = new MyPolynomial(new double[] { 2,0,0,1});
			MyPolynomial second = new MyPolynomial(new double[] { 2,1,6});
			Console.WriteLine(first);
			Console.WriteLine(second);
		    Console.WriteLine(first.Add(second));
			//Console.WriteLine(second.Add(first));
			//Console.WriteLine(first.Multiply(second));
			//Console.WriteLine(second.Multiply(first));
			//Console.WriteLine(first.Evaluate(2));
			//Console.WriteLine(second.Evaluate(2));

		}
	}
}