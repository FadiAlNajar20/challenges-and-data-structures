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

        public void ReverseStack()
        {
            if (IsEmpty()) return;

            Queue queue = new Queue();

            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }

        public int DeleteMiddleElement()
        {
            if (IsEmpty() || list.Length == 1)
            {
                throw new InvalidOperationException("Stack does not have a middle element");
            }

            int midPosition = list.Length / 2;
            Node current = list.head;
            Node previous = null;

            for (int i = 0; i < midPosition; i++)
            {
                previous = current;
                current = current.Next;
            }

            int removedValue = current.Value;

            if (previous != null)
            {
                previous.Next = current.Next;
            }
            else
            {
                list.head = current.Next;
            }

            list.Length--;

            return removedValue;
        }

    }
}
