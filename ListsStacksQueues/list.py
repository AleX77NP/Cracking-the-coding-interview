class Node:
    def __init__(self, data, next):
        self.data =  data
        self.next = next

class LinkedList:
    def __init__(self):
        self.head = None

    def display(self):
        temp = self.head
        while temp is not None:
            print(temp.data)
            temp = temp.next


node1 = Node(12, None)
node12 = Node(12, None)
node2 = Node(24, None)
node22 = Node(24, None)
node3 = Node(36, None)
node1.next = node12
node12.next = node2
node2.next = node22
node22.next = node3
node4 = Node(12, None)
node3.next = node4

list = LinkedList()
list.head = node1

# list.display()

def remove_duplicates(list):
    prev  = list.head
    temp = prev.next
    track = [prev.data]
    while temp is not None:
        if temp.data in track:
            prev.next = temp.next
        else:
            track.append(temp.data)
        prev = temp
        temp = temp.next

remove_duplicates(list)
list.display()

# find nth latest

def nth_latest(list, n):
    temp = list.head
    p = list.head
    for i in range(0, n):
        temp = temp.next
        if temp is None:
            return None
    while temp is not None:
        temp = temp.next
        p = p.next
    return p.data

print(nth_latest(list, 2))


a = Node(1, None)
b = Node(2, None)
c = Node(3, None)
d = Node(4, None)

a.next = b
b.next = c
c.next = d
d.next = b

clist = LinkedList()
clist.head = a

# circula list - return node at the start of loop

def find_start(list):
    n1 = list.head
    n2 = list.head 

    while n2.next is not None:
        n1.next = n2.next
        n2.next = n2.next.next
        if (n1 == n2):
            break
    
    if n2 is None:
        return None
    
    n1 = list.head
    while n1 != n2:
        n1 = n1.next
        n2 = n2.next
    return n1.data

print(find_start(clist))
