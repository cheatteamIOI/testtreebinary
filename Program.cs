using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;

namespace ConsoleApplication2
{
    public class Program
    {
    

        public class Node
        {
            public int key;
            public Node left, right;
            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        public class BinaryTree
        {
        
            public Node root;
            public BinaryTree() { root = null; }

            public void printPreorder(Node node)
            {
                if (node == null)
                return;
            
                Console.Write(node.key + " ");
            
                printPreorder(node.left);
           
                printPreorder(node.right);
            }
        
        
            public void printPreorder() { printPreorder(root); }

            public void width(Node node)
            {
                Queue<Node> q = new Queue<Node>();

                if (node == null) return;

                q.Enqueue(root);        
                while (q.Count > 0)
                {
                    var x = q.Dequeue();
                    Console.Write(x.key + " ");              
                    if (x.left != null)   
                        q.Enqueue(x.left);
                    if (x.right != null)  
                        q.Enqueue(x.right);
                }
            }

            public void width() { width(root); }


            public void add(int val, Node node)
            {
         
                if (val.CompareTo(node.key) < 0)
                {
                    if (node.left == null)
                    {
                        node.left = new Node(val);
                    }
                    else if (node.left != null)
                        add(val,node.left);
                }
                else
                {
                    if (node.right == null)
                    {
                        node.right = new Node(val);
                    }
                    else if (node.right != null)
                            add(val, node.right);
                }
            }
            public void add(int val) { add(val, root); }

            
        }
        static public void Main(String[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.add(7);

            Console.WriteLine("Preorder traversal "
            + "of binary tree is ");
            tree.printPreorder();

            Console.WriteLine("\n Width traversal "
            + "of binary tree is ");
            tree.width();

            Thread.Sleep(50000);
        }




    }
}