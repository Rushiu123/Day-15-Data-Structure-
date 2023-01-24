using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Data_Structure
{
    public class INode      //Creating node class
    {
        public int value;
        public INode left;
        public INode right;

        public INode(int value)         //Creating node constructor
        {
            this.value = value;
        }
    }
}
