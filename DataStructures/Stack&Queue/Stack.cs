using challenges_and_data_structures.DataStructures.LinkedList;

namespace challenges_and_data_structures
{
    public class Stack
    {
        private LinkedList list;

        public Stack()
        {
            list = new LinkedList();    
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Push(int data)
        {
            list.AddToHead(data);
        }

        public int Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return list.RemoveHead();
        }

        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
            return list.head.Value;
        }

        public void PrintStack()
        {
            list.PrintList();
        }
    }
}
