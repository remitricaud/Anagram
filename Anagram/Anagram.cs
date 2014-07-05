/*
 * Created by Remi.
 * Date: 25/06/2014
 * Time: 22:45
 */
using System;

namespace Anagram
{
	public class Anagram
	{
		//on présuppose que aCharacter est 1 string de taille 1, élément de la string
		private static string stringStrippedFromAnotherString(string aWord, string aCharacter)
		{
			string returnValue=string.Empty;
			if(aWord.IndexOf(aCharacter)==0)
			{
				returnValue=aWord.Substring(aCharacter.Length,aWord.Length-aCharacter.Length);
			}
			else {
				returnValue=aWord.Substring(0,aWord.IndexOf(aCharacter))+aWord.Substring(aWord.IndexOf(aCharacter)+aCharacter.Length);
			}
			return returnValue;
		}
		
		public static bool isAnagram(string aWord, string anotherWord) {


			if (aWord.Length!=anotherWord.Length)
			{
				return false;
			}

			if(aWord.Equals(anotherWord))
			{
				return true;
			}
			else
			{
				if (aWord.Length <= 1)
				{
					return false;
				}
			}
			
			
			string firstCharacterOfAnotherWord=anotherWord.Substring(0,1);
			
			if (!aWord.Contains(firstCharacterOfAnotherWord))
			{
				return false;
			}
			
			else
			{
				string endofAnotherWord=anotherWord.Substring(1, anotherWord.Length-1);
				string aWordWithoutFirstCharacterOfAnotherWord = stringStrippedFromAnotherString(aWord,firstCharacterOfAnotherWord);
				return isAnagram(aWordWithoutFirstCharacterOfAnotherWord,endofAnotherWord);
				
				
			}
		}
		
	}
}