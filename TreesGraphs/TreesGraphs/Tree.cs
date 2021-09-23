using System;
using System.Collections.Generic;

namespace TreesGraphs
{
    public class BinaryTreeNode
    {
        private readonly int _value;
        public BinaryTreeNode _left
        {
            private set;
            get;
        }
        public BinaryTreeNode _right
        {
            private set;
            get;
        }

        public BinaryTreeNode(int value)
        {
            _value = value;
            _left = null;
            _right = null;
        }

        public int Value()
        {
            return _value;
        }

        public BinaryTreeNode Parent
        {
            get;
            private set;
        }

        public void Insert(int v)
        {
            if (v >= _value)
            {
                if(_right == null)
                {
                    AddChild(v);
                } else
                {
                    _right.Insert(v);
                }
            } else
            {
                if (_left == null)
                {
                    AddChild(v);
                } else
                {
                    _left.Insert(v);
                }
            }
        }

        private void AddChild(int v)
        {
            var child = new BinaryTreeNode(v) { Parent = this };
            if (v > _value)
            {
                _right = child;
            }
            else
            {
                _left = child;
            }
        }

        public void Display()
        {
            if (_left != null)
            {
                _left.Display();
            }
            Console.WriteLine(_value);
            if (_right != null)
            {
                _right.Display();
            }
        }
    }
}
