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
            //Inserting all the elements in the array
            int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };
            // iterating using for loop to add each element to the binary tree at a time
            for (int i = 0; i < arr.Length; i++)
            {
                binarytree.Insert(arr[i]);
            }
            // Displaying the elements of the Binary Search Tree
            binarytree.DisplayBST(binarytree.root);
            Console.WriteLine("\n\nSize of Binary Search Tree: " + binarytree.Size(binarytree.root));
        }
    }
}
