﻿namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ WELCOME TO HASHTABLE ========================");

            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");

            string hash0 = hash.Get(0);
            Console.WriteLine("0th index value: " + hash0);

            string hash1 = hash.Get(1);
            Console.WriteLine("1st index value: " + hash1);

            string hash2 = hash.Get(2);
            Console.WriteLine("2nd index value: " + hash2);

            string hash3 = hash.Get(3);
            Console.WriteLine("3rd index value: " + hash3);

            string hash4 = hash.Get(4);
            Console.WriteLine("4th index value: " + hash4);

            string hash5 = hash.Get(5);
            Console.WriteLine("5th index value: " + hash5);

            Console.WriteLine("\nFrequency of Words ==> ");

            string[] arr = new string[hash.size];
            for (int i = 0; i < hash.size; i++)
            {
                arr[i] = hash.Get(i);
            }

            hash.FreqOfWords(arr, arr.Length);

            Console.ReadLine();
        }
    }
}