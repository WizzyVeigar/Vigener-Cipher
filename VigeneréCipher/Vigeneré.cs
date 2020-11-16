using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigeneréCipher
{
    class Vigeneré
    {
        char[,] cipherArr = new char[26, 26];
        int keycount = 0;
        string returnString = string.Empty;


        public string Encrypt(string message, string key)
        {
            message = message.ToLower();
            key = key.ToLower();
            for (int i = 0; i < message.Length; i++)
            {
                if (keycount >= key.Length)
                {
                    keycount = 0;
                }
                returnString += cipherArr[message[i] - 97, key[keycount] - 97];
                keycount++;
            }

            return returnString;
        }

        public string Decrypt(string message, string key)
        {
            message = message.ToLower();
            key = key.ToLower();

            for (int i = 0; i < message.Length; i++)
            {
                if (keycount >= key.Length)
                {
                    keycount = 0;
                }

                Console.WriteLine((message[i]) - key[keycount]);
                if ((message[i]) - key[keycount] < 0)
                {
                    returnString += cipherArr[0, (message[i] + 26) - (key[keycount])];
                }
                else
                {
                    returnString += cipherArr[0, (message[i] - 97) - (key[keycount] - 97)];
                }
                keycount++;
            }

            return returnString;
        }

        public void FillArray()
        {
            int counter = 97;

            for (int i = 0; i < cipherArr.GetLength(0); i++)
            {

                for (int j = 0; j < cipherArr.GetLength(1); j++)
                {
                    cipherArr[i, j] = (char)counter;
                    counter++;
                    if (counter > 122)
                    {
                        counter = 97;
                    }
                }
                counter += 1;
            }
        }
    }
}
