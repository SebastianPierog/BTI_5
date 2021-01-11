using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BTI_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DES des = new DES();
            StreamReader textFromStream = new StreamReader(@"C:\Users\Sebastian\Desktop\text.txt"); 
            StreamReader keyFromStream = new StreamReader(@"C:\Users\Sebastian\Desktop\key.txt");
            List<int> text = textFromStream.ReadLine().ToIntList().ToList();
            List<int> key = keyFromStream.ReadLine().ToIntList().ToList();
            Console.WriteLine($"Text (64-bit): {text.ListToString()}");
            Console.WriteLine($"Key (64-bit): {key.ListToString()}");
            var encrypted = des.Encrypt(text, key);
            Console.WriteLine($"Coded: {encrypted.ListToString()}");
            Console.WriteLine($"Encoded: {des.Decrypt(encrypted, key).ListToString()}");
            Console.ReadLine();
        }
    }
}