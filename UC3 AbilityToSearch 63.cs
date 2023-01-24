using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Data_Structure
{
    class MyBinaryNode      //Creating class
    {
        public static INode Search(INode root, int value)           //Creating search method
        {
            if (root.value == value)
            {
                return root;
            }
            else if (value < root.value)
            {
                root = Search(root.left, value);
            }
            else if (value > root.value)
            {
                root = Search(root.right, value);
            }
            return root;
        }

        public INode root;
        public virtual int size()       //creating size method 
        {
            return size(root);
        }
        public virtual int size(INode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.left) + 1 + size(node.right));
            }
        }
    }
}
