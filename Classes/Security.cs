using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CALCULATR.Classes
{
    public class Security
    {
        public void CheckPassword()
        {
            string password ="";
            do
            {
                System.Console.WriteLine("Enter the Password:");
                password = Console.ReadLine();
                
            } while (password!="12344321");
        }

    }
}