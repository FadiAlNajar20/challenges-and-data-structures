﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }  

        public Node(int value) 
        {
            Value = value;
            Next = null;
        }   
    }
}
