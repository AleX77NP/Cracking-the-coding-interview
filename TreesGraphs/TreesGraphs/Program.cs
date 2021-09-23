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

        public static bool IsBalanced(BinaryTreeNode t)
        {
            return (MaxDepth(t) - MinDepth(t) <= 1);
        }
    }
}
