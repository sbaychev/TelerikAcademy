using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodDecodStringByAgivenKey
{
    class EncodDecodStringByAgivenKey
    {
        static void Main(string[] args)
        {
        //Write a program that encodes and decodes a string using given encryption 
        //key (cipher). The key consists of a sequence of characters. 
        //The encoding/decoding is done by performing XOR (exclusive or) operation over
        //the first letter of the string with the first of the key, the second – with 
        //the second, etc. When the last key character is reached, the next is the first.
            //nt index = 0;
            //StringBuilder encode = new StringBuilder();
            //StringBuilder decode = new StringBuilder();
            //string text = "This is a text to be encrypted by the key";
            //string key = "dfgdfghdhsr";
            //int[] ch = new int[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (index == key.Length)
            //    {
            //        index = 0;
            //    }
            //    if (index < key.Length)
            //    {
            //        ch[i] = text[i] ^ key[index];
            //        encode.Append(ch[i]);
            //    }

            //    index++;
            //}
            //Console.WriteLine("The encrypted text:{0}", encode);
            //index = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (index == key.Length)
            //    {
            //        index = 0;
            //    }
            //    if (index < key.Length)
            //    {
            //        ch[i] = ch[i] ^ key[index];
            //        decode.Append((char)ch[i]);
            //    }

            //    index++;
            //}
            //Console.WriteLine("The decrypted text:{0}", decode);


        }
    }
}
