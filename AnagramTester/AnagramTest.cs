/*
 * Created by SharpDevelop.
 * User: Aurélie
 * Date: 25/06/2014
 * Time: 22:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * renommer répertoires
 * Mettre sous git
 * Revoir coding standards
 * Revoir pour tests non verbeux : lister cas de tests ?
 * Exposer les méthodes anagrammes sous forme de services.
 * Refactoring code.
 * Corriger build pour commencer par le projet Anagram
 * Lier Jenkins, etc.
 */
using System;
using NUnit.Framework;
using Anagram;

namespace AnagramTester
{
	[TestFixture]
	public class AnagramTest 
	{
		[Test]
		public void astring_is_anagram_of_itself()
		{
			string aWord=string.Empty;
			Assert.IsTrue(Anagram.Anagram.isAnagram(aWord, aWord));
		}
		
		[Test]
		public void twostring_of_different_length_are_no_anagram()
		{
			string aWord=string.Empty;
			string anotherWord="a";
			
			Assert.IsFalse(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
		[Test]
		public void a_and_b_are_not_anagram()
		{
			string aWord="a";
			string anotherWord="b";
			
			Assert.IsFalse(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
		[Test]
		public void ab_and_ba_are_anagram()
		{
			string aWord="ab";
			string anotherWord="ba";
			
			Assert.IsTrue(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
		[Test]
		public void abc_and_cba_are_anagram()
		{
			string aWord="abc";
			string anotherWord="cba";
			
			Assert.IsTrue(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
		[Test]
		public void aac_and_cca_are_no_anagram()
		{
			string aWord="aac";
			string anotherWord="cca";
			
			Assert.IsFalse(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
		[Test]
		public void remiaimeaurelie_and_miauleraieeeimr_are_anagram()
		{
			string aWord="remiaimeaurelie";
			string anotherWord="miauleraieeeimr";
			
			Assert.IsTrue(Anagram.Anagram.isAnagram(aWord,anotherWord));
		}
		
	}
}