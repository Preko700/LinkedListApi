const { v4: uuidv4 } = require('uuid');

class Node {
  constructor(value) {
    this.id = uuidv4();
    this.value = value;
    this.next = null;
  }
}

class LinkedList {
  constructor() {
    this.head = null;
  }

  add(value) {
    const newNode = new Node(value);

    if (!this.head) {
      this.head = newNode;
      return newNode;
    }

    let current = this.head;
    while (current.next) {
      current = current.next;
    }

    current.next = newNode;
    return newNode;
  }

  remove(id) {
    if (!this.head) {
      return false;
    }

    if (this.head.id === id) {
      this.head = this.head.next;
      return true;
    }

    let current = this.head;
    while (current.next) {
      if (current.next.id === id) {
        current.next = current.next.next;
        return true;
      }
      current = current.next;
    }

    return false;
  }

  toList() {
    const result = [];
    let current = this.head;

    while (current) {
      result.push({
        id: current.id,
        value: current.value
      });
      current = current.next;
    }

    return result;
  }
}

module.exports = LinkedList;