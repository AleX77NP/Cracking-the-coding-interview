# Graph with Beadth and Depth first search
from collections import defaultdict

class Graph:

    def __init__(self):
        self.graph = defaultdict(list)

    def addEdge(self, u,v):
        self.graph[u].append(v)
    
    def BFS(self, s):

        visited = [False] * (max(self.graph) + 1)

        queue = []

        queue.append(s)
        visited[s] = True

        while queue:
            s = queue.pop()
            print(s)

            for i in self.graph[s]:
                if visited[i] == False:
                    queue.append(i)
                    visited[i] = True

    def DFSUtil(self,s, visited): 
        visited.add(s)
        print(s)

        for n in self.graph[s]:
            if n not in visited:
                self.DFSUtil(n, visited)

    def DFS(self, s):
        visited = set()

        self.DFSUtil(s, visited)

    def search(self, a, b):
        visited = [False] * (max(self.graph) + 1)

        queue = []

        queue.append(a)
        visited[a] = True

        while queue:
            s = queue.pop()
            print(s)

            for i in self.graph[s]:
                if visited[i] == False:
                    if i == b:
                        return True
                    else:
                        queue.append(i)
                        visited[i] = True

        return False

g = Graph()
g.addEdge(0, 1)
g.addEdge(0, 2)
g.addEdge(1, 2)
g.addEdge(2, 0)
g.addEdge(2, 3)
g.addEdge(3, 3)

# g.BFS(2)
# print("\n")
# g.DFS(2)

print(g.search(1,2))
print(g.search(1,3))