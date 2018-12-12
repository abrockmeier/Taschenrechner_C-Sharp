using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
	class Program
	{
		static void Main(string[] args)
		{
		//Variablen
		double numberA;
		double numberB;
		double result;
		char operand;
		//Eingabe
		
		Console.WriteLine("Bitte geben sie die Erste Zahl ein:");
		numberA = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Bitte geben sie die Zweite Zahl ein:");
		numberB = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Bitte Operanden auswählen: +, -, *, / ");
		operand = Convert.ToChar(Console.ReadLine());
		//Verarbeitung
		Console.WriteLine("Die Berechnung von:",Environment.NewLine);
		
		switch (operand)
		{
		
		// ADD
		case '+':
			result = (numberA + numberB);
			Console.WriteLine(numberA + " + " + numberB + " = " + result + "\n");
		break;

		// SUB
		case '-':
			result = (numberA - numberB);
			Console.Write(numberA + " - " + numberB + " = " + result + "\n");
		break;
			
		// MUL
		case '*':
			result = (numberA * numberB);
			Console.WriteLine(numberA + " * " + numberB + " = " + result + "\n");
		break;
		
		// DIV
		case '/':
			result = (numberA / numberB);
			Console.WriteLine(numberA + " / " + numberB + " = " + result + "\n");
		break;
		
		//FALSE INPUT
		default:
		Console.WriteLine("Sie haben keinen gültige Zahl bzw. Operanden eingegeben!");
		Console.ReadLine();
		break;
		}

		//OUTPUT IS IN SWITCH-CASE BLOCK
		}
	}
}