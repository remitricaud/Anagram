/*
 * Created by SharpDevelop.
 * User: Aurélie
 * Date: 25/06/2014
 * Time: 22:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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