using System;

namespace BSTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST code!");
            Binary<int> binarySearch = new Binary<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}
