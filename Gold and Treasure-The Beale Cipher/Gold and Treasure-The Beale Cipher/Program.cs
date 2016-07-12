using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherLogic;


//The challeng information had some erorrs in it. 
//As a result the output is  a little messed up. 
//proof of concept is there but, its a little off. 


namespace Gold_and_Treasure_The_Beale_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipher = new Cipher(); 
            cipher.DeCodeMessage(cipher.textString, cipher.keyString);
            Console.ReadLine();
        }
    }
}
