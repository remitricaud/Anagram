/*
 * Created by Remi.
 * Date: 25/06/2014
 * Time: 22:45
 */
 
using System;

namespace Anagram
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Boolean valeurRetour=Anagram.isAnagram("ab","ba");

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	
}