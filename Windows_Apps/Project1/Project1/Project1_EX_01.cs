using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter Username");
		
		string userName = Console.ReadLine();
		Console.WriteLine();

		Console.WriteLine("I see your name to the system is called as " + userName);
		Console.WriteLine();

		Console.WriteLine("What do you preferred to be called ?");
		string prefName = Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine("Hi " + prefName + " ,How old are you?");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine(prefName + "'s age is " + age + " years!");
		Console.WriteLine();

		if (age <= 17)
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine("Hello" + prefName + ", You are a minor!", Console.BackgroundColor);
			Console.Beep();
		}
		else
		{
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Hello "+ prefName + ", You are not a minor!", Console.BackgroundColor);
			MessageBox.Show("!!!!DANGER!!!! " + prefName);
		}

	}
}
