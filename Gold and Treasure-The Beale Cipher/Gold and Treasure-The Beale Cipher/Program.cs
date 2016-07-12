using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherLogic;

namespace Gold_and_Treasure_The_Beale_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipher = new Cipher(); 
            Console.WriteLine("Please enter the cypher Text");
            var text = Console.ReadLine();
            Console.WriteLine("Please enter the cypher");
            var key = Console.ReadLine();

            cipher.DeCodeMessage(text, key);
        }
    }
}
