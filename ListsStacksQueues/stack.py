# Write a program to implement queue using 2 stacks


class Node:
    def __init__(self, value):
        self.value = value
        self.next = None
    def __str__(self):
        return str(self.value)


class Stack():
    def __init__(self):
        self.size = 0
        self.head = Node("head")
    
    def get_size(self):
        return self.size

    def is_empty(self):
        return self.size == 0

    def __str__(self):
        cur = self.head.next
        out = ""
        while cur:
            out += str(cur.value) + "->"
            cur = cur.next
        return out[:-3]  

    def peek(self):
        if self.is_empty():
            raise Exception("Stack is empty!")
        return self.head.next.value

    def push(self, elem):
        node = Node(elem)
        node.next = self.head.next
        self.head.next = node
        self.size += 1

    def pop(self):
        if self.is_empty():
            raise Exception("Stack is empty")
        elem = self.head.next
        self.head.next = self.head.next.next
        self.size -= 1
        return elem

s = Stack()
s.push(11)
s.push(3)
s.push(35)
s.push(16)
s.push(9)

class CustomQueue:
    def __init__(self):
        self.s1 = Stack()
        self.s2 = Stack()
    
    def get_size(self):
        return self.s1.get_size() + self.s2.get_size()

    def add(self, elem):
        self.s1.push(elem)
    
    def peek(self):
        if(not self.s2.is_empty()):
            return self.s2.peek()
        while(not self.s1.is_empty()):
            self.s2.push(self.s1.pop())
        return self.s2.peek()

    def remove(self):
        if (not self.s2.is_empty()):
            return self.s2.pop()
        while(not self.s1.is_empty()):
            self.s2.push(self.s1.pop())
        return self.s2.pop()


q = CustomQueue()

q.add(1)
q.add(2)
q.add(3)

print(q.remove())

q.add(4)

print(q.remove())

print(q.get_size())