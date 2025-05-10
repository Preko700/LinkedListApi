using System.Collections.Generic;

namespace LinkedListApi.Models
{
    public class LinkedList
    {
        private LinkedListNode? head;

        public LinkedListNode? Head => head;

        public LinkedListNode Add(string value)
        {
            var newNode = new LinkedListNode(value);

            if (head == null)
            {
                head = newNode;
                return newNode;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            return newNode;
        }

        public bool Remove(string id)
        {
            if (head == null)
                return false;

            if (head.Id == id)
            {
                head = head.Next;
                return true;
            }

            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public List<object> ToList()
        {
            var result = new List<object>();
            var current = head;

            while (current != null)
            {
                result.Add(new { current.Id, current.Value });
                current = current.Next;
            }

            return result;
        }
    }
}