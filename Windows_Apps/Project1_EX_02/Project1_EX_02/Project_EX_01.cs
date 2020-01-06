using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Calculator
{

	public int Addition(int input1, int input2)
	{
		return input1 + input2;
	}

	public int Subtraction(int input1, int input2)
	{
		return input1 - input2;
	}

	public int Multiplication(int input1, int input2)
	{
		return input1 * input2;
	}

	public int Division(int input1, int input2)
	{
		return input1 / input2;
	}
}

public class Class1
{
	static public void Main(string[] args)
	{
		Calculator cal = new Calculator();
		Console.WriteLine("Welcome to a simple Calculator in C#");
		Console.WriteLine();
		char exit;

		do
		{
			Console.WriteLine("What operation would you like to perform?");
			Console.WriteLine("Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");
			int input = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You entered " + input);


			if (input == 1)
			{
				Console.WriteLine("Enter the two numbers");
				int num1 = Convert.ToInt32(Console.ReadLine());
				int num2 = Convert.ToInt32(Console.ReadLine());
				MessageBox.Show("The sum of two numbers is " + cal.Addition(num1, num2));
			}

			else if (input == 2)
			{
				Console.WriteLine("Enter the two numbers");
				int num1 = Convert.ToInt32(Console.ReadLine());
				int num2 = Convert.ToInt32(Console.ReadLine());
				MessageBox.Show("The difference of two numbers is " + cal.Subtraction(num1, num2));
			}

			else if (input == 3)
			{
				Console.WriteLine("Enter the two numbers");
				int num1 = Convert.ToInt32(Console.ReadLine());
				int num2 = Convert.ToInt32(Console.ReadLine());
				MessageBox.Show("The product of two numbers is " + cal.Multiplication(num1, num2));
			}

			else if (input == 4)
			{
				Console.WriteLine("Enter the two numbers");
				int num1 = Convert.ToInt32(Console.ReadLine());
				int num2 = Convert.ToInt32(Console.ReadLine());
				MessageBox.Show("The division of two numbers is " + cal.Division(num1, num2));
			}
			Console.WriteLine();
			Console.WriteLine("Would you like to restart?");
			exit = Convert.ToChar(Console.ReadLine());
		} while (exit == 'y' || exit == 'Y');

	}
}
