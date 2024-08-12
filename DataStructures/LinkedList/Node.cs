using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }  
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value) 
        {
            Value = value;
            Next = null;
            Left = null;
            Right = null;
        }   
    }
}
