using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplikat_2
{
    internal class Login
    {
        public static void login()
        {
            Console.WriteLine("==LOGIN==");
            Console.Write("USERNAME : ");
            string inputUser = Console.ReadLine();

            Console.Write("PASSWORD : ");
            string inputPass = Console.ReadLine();

            bool status = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (userName[i] == inputUser && password[i] == inputPass)
                {
                    status = true;
                    break;
                }
            }

            if (status == true)
            {
                Console.Write("Login Berhasil");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Login Gagal");
                Console.ReadKey();
            }
        }
    }
}
