using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeEmplementation
{
    class program
    {
        public class TreeNode<T>
        {
            public T Value { get; set; }

            public List<TreeNode<T>> Children { get; set; }
            public TreeNode(T value)
            {
                this.Value = value;
                Children = new List<TreeNode<T>>();
            }

            public void AddChild(TreeNode<T> Child)
            {
                Children.Add(Child);
            }

            public TreeNode<T> Find(T value)
            {
                if (EqualityComparer<T>.Default.Equals(Value, value))
                    return this;

                foreach(var child in Children)
                {
                    var found = child.Find(value);
                    if(found != null)
                        return found;
                }
                return null; //Not found
            }
        }

        public class Tree<T>
        {
            public TreeNode<T> Root { get; private set; }

            public Tree(T RootValue)
            {
                Root = new TreeNode<T>(RootValue);
            }

            public void PrintTree(string splite = " ")
            {
                PrintTree(this.Root, splite);
            }
            private void PrintTree(TreeNode<T> node, string splite = " ")
            {
                Console.WriteLine(splite + node.Value);
                foreach(var item in node.Children)
                {
                    PrintTree(item , splite + " ");
                }
            }

            public TreeNode<T> Find(T value)
            {
                return Root?.Find(value);
            }
        }

        static void Main(string[] args)
        {
            var CompanyTree = new Tree<string>("CEO");
            var Finance = new TreeNode<string>("CFO");
            var Tech = new TreeNode<string>("CTO");
            var MArketing = new TreeNode<string>("CMO");

            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(MArketing);

            Finance.AddChild(new TreeNode<string>("xxxxxx"));
            Finance.AddChild(new TreeNode<string>("xxxxxx"));
            Tech.AddChild(new TreeNode<string>("UUUUUUUUUU"));
            MArketing.AddChild(new TreeNode<string>("TTTTTTT"));
            MArketing.AddChild(new TreeNode<string>("KKKKKKKKKKK"));

            CompanyTree.PrintTree();

            if (CompanyTree.Find("xxxxxx1") == null)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("found");
            Console.ReadKey();
        }
    }
}