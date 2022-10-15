using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    internal class Help
    {

        public static void CheakPalindrome(string x)
        {
            char[] palindrome = x.ToCharArray();
            Array.Reverse(palindrome);
            string b = new string(palindrome);
            if (x.ToLower().Equals(b.ToLower()))
            {
                Console.WriteLine("You enter the Palindrome");
            }
            else
            {
                Console.WriteLine("You enter the notPalindrome");
            }
        }


      

      
    }
}
