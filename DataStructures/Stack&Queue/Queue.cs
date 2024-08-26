using challenges_and_data_structures.DataStructures.LinkedList;

namespace challenges_and_data_structures
{
    public class Queue
    {
        LinkedList list;
        public int Count { get; private set; }
        public Queue()
        {
            list = new LinkedList();
            Count = 0;
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Enqueue(int data)
        {
            list.AddToTial(data);
            Count++;
        }

        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            Count--;
            return list.RemoveHead();
        }

        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            return list.head.Value;
        }

        public void PrintQueue()
        {
            list.PrintList();
        }
    }
}
