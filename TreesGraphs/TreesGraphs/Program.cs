using System;

namespace TreesGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeNode root = new BinaryTreeNode(10);
            root.Insert(12);
            root.Insert(5);
            root.Insert(56);
            root.Insert(112);
            root.Insert(167);
            root.Display();

            Console.WriteLine(IsBalanced(root));

            Console.WriteLine("Max elem: " + MaxElem(root));
            Console.WriteLine("Min elem: " + MinElem(root));


        }

        public static int MaxDepth(BinaryTreeNode t)
        {
            if(t == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxDepth(t._left), MaxDepth(t._right));
        }

        public static int MinDepth(BinaryTreeNode t)
        {
            if (t == null)
            {
                return 0;
            }

            return 1 + Math.Min(MaxDepth(t._left), MaxDepth(t._right));
        }

        // Implement a function to check if a tree is balanced For the purposes of this question,
        // a balanced tree is defined to be a tree such that no two leaf nodes differ in distance from the root by more than one

        public static bool IsBalanced(BinaryTreeNode t)
        {
            return (MaxDepth(t) - MinDepth(t) <= 1);
        }

        // Maximum value

        public static int MaxElem(BinaryTreeNode t)
        {
            BinaryTreeNode temp = t;
            while (temp._right != null)
                temp = temp._right;

            return temp.Value();
            
        }

        public static int MinElem(BinaryTreeNode t)
        {
            BinaryTreeNode temp = t;
            while (temp._left!= null)
                temp = temp._left;

            return temp.Value();

        }

    }
}
