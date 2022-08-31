using System;

namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Binary Search Tree!");
            //Creating an object of bst
            Binary_Search_Tree<int> binarytree = new Binary_Search_Tree<int>();
            binarytree.Insert(56);
            binarytree.Insert(30);
            binarytree.Insert(70);
            binarytree.DisplayBST(binarytree.root);
        }
    }
}
