using System;

namespace LinkedListApi.Models
{
    public class LinkedListNode
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public LinkedListNode? Next { get; set; }

        public LinkedListNode(string value)
        {
            Id = Guid.NewGuid().ToString();
            Value = value;
            Next = null;
        }
    }
}