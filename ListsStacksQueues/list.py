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
