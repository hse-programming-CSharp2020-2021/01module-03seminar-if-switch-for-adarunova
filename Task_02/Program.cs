/*
 * 2) Написать метод, преобразующий число переданное в качестве параметра в число, 
 * записанное теми же цифрами, но идущими в обратном порядке. 
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 1024 
 * -------test_2-------
 * 120
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 4201
 * -------test_2-------
 * 21
 * --------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02 {

	class Program {

		static void Main(string[] args) 
		{
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine(Reverse(x));
			Console.ReadLine();
		}

		public static int Reverse(int x) 
		{
			char[] digits = x.ToString().ToCharArray();
			Array.Reverse(digits);
			return int.Parse(new string(digits));

		}
	}
}
