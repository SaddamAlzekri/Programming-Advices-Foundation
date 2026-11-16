using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
    class program
    {
        public class BinaryTreeNode<T>
        {
            public T Value { set; get; }
            public BinaryTreeNode<T> Left { get; set; }
            public BinaryTreeNode<T> Right { get; set; }

            public BinaryTreeNode(T Value)
            {
                this.Value = Value;
                this.Left = null;
                this.Right = null;
            }
        }

        public class BinaryTree<T>
        {
            public BinaryTreeNode<T> Root { get;private set; }

            public BinaryTree ()
            {
                Root = null;
            }

            public void Insert(T value)
            {
                var NewNode = new BinaryTreeNode<T>(value);

                if(Root == null)
                {
                    Root = NewNode;
                    return;
                }

                Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>> ();
                queue.Enqueue(Root);

                while (queue.Count > 0) 
                {
                    var current = queue.Dequeue ();

                    if(current.Left == null)
                    {
                        current.Left = NewNode;
                        break;
                    }else
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right == null)
                    {
                        current.Right = NewNode;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(current.Right);
                    }
                }

            }

            public void PrintTree()
            {
                PrintTree(this.Root, 0);
            }
            private void PrintTree(BinaryTreeNode<T> Root, int Space)
            {
                int Count = 10;
                
                if(Root == null)
                {
                    return;
                }

                Space += Count;

                PrintTree(Root.Right, Space);

                Console.WriteLine();
                for (int i = Count; i < Space; i++)
                    Console.Write(" ");
                Console.WriteLine(Root.Value);

                PrintTree(Root.Left, Space);
            }

            public void PreOrder()
            {
                Console.WriteLine("The PreOrder (Current - Left - Right). ");
                PreOrder(this.Root);
            }
            private void PreOrder(BinaryTreeNode<T> Root)
            {

                if(Root != null)
                {
                    Console.Write(Root.Value + " ");
                    PreOrder(Root.Left);
                    PreOrder(Root.Right);
                }
            }

            public void PostOrder()
            {
                Console.WriteLine("\n\nThe PostOrder (Left - Right - Current). ");
                PostOrder(this.Root);
            }
            private void PostOrder(BinaryTreeNode<T> Root)
            {

                if (Root != null)
                {
                    PostOrder(Root.Left);
                    PostOrder(Root.Right);
                    Console.Write(Root.Value + " ");
                }
            }

            public void InOrder()
            {
                Console.WriteLine("\n\nThe InOrder (Left - Current - Right ). ");
                InOrder(this.Root);
            }
            private void InOrder(BinaryTreeNode<T> Root)
            {

                if (Root != null)
                {
                    InOrder(Root.Left);
                    Console.Write(Root.Value + " ");
                    InOrder(Root.Right);
                }
            }
        }

        static void Main()
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Insert(1);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(5);
            binaryTree.Insert(6);

            binaryTree.PrintTree();

            binaryTree.PreOrder();
            
            binaryTree.PostOrder();

            binaryTree.InOrder();


            Console.ReadKey();
        }
    }
}