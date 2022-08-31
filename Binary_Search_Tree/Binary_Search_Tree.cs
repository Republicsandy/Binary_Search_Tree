using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Binary_Search_Tree<T> where T : IComparable
    {
        // Defining an Node root
        public Node<T> root;
        // Default Constructor for the class BinarySearchTree    
        public Binary_Search_Tree()
        {
            this.root = null;
        }
        // UC - 1 Insert the element in the specified node depending upon the value passed by user as data  
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                // Defining the current node as root
                Node<T> current = root;
                // Defining the parent node
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    // If data is less than root data then passing it to left node
                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //If data is Greater than root data then passing it to right node
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        // Displaying the Binary tree In the default in Order from left branch to node to right branch        
        public void DisplayBST(Node<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
            {
                Console.WriteLine("Right :" + parent.Right.data);
            }
            if (parent.Left != null)
            {
                DisplayBST(parent.Left);
            }
            if (parent.Right != null)
            {
                DisplayBST(parent.Right);
            }
        }
        public int Size(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                // Adding the all the left node, all the right nodes and the root node 
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
    }
}
