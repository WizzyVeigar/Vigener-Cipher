using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigeneréCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Vigeneré vigeneré = new Vigeneré();

            vigeneré.FillArray();

            Console.WriteLine(vigeneré.Encrypt("HelloWorld", "Hi"));
            Console.WriteLine(vigeneré.Decrypt("omstvevzsl", "Hi"));
            Console.ReadKey();
        }
    }
}
