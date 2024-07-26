using challenges_and_data_structures.DataStructures.LinkedList;

namespace challenges_and_data_structures
{
    public class Queue
    {
            LinkedList list;
            public Queue()
            {
                list = new LinkedList();
            }

            public bool IsEmpty()
            {
                return list.IsEmpty();
            }

            public void Enqueue(int data)
            {
               list.AddToTial(data);
            }

            public int Dequeue()
            {
                if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
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
