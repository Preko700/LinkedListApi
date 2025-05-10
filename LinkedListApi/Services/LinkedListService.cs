using LinkedListApi.Models;

namespace LinkedListApi.Services
{
    public class LinkedListService
    {
        private readonly LinkedList _linkedList = new LinkedList();

        public LinkedList GetLinkedList() => _linkedList;
    }
}