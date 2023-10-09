using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPaindrome(string word)
        {

            //reverse the word // hello // olleh
            var reversed = "";   //racecar--> 7   --> 6
            
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                reversed += word[i]; 
            }
            //compare the original with the reversed


            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
            //return whether they are the same or not

        }
    }
}
