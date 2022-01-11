import sys
import random

width = 10 #int(input("Width: "))
height = 10 #int(input("Height: "))
# seed = int(input("Seed: "))

grid = [[0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]]

N = 1
S = 2
E = 4
W = 8

DX = {}
DX[E] = 1
DX[W] = -1
DX[N] = 0
DX[S] = 0

DY = {}
DY[E] = 0
DY[W] = 0
DY[N] = -1
DY[S] = 1

OP = {}
OP[E] = W
OP[W] = E
OP[N] = S
OP[S] = N

c = 0

def carve(cx, cy):
    directions = [N, S, E, W]
    
    random.shuffle(directions)
    
    for direction in directions:
        
        nx = cx + DX[direction]
        ny = cy + DY[direction]
            
        if ny >= 0 and ny < len(grid):
            
            if nx >= 0 and nx < len(grid[ny]):
                
                if grid[ny][nx] == 0:
            
                    grid[cy][cx] |= direction
                    grid[ny][nx] |= OP[direction]
                    print("recurse")
                    carve(nx, ny)
            
carve(0, 0)

print(str(grid))

print(" " + ("_" * (width * 2 - 1)))
for y in range(height):
    s = ""
    s += "|"
    for x in range(width):
        if grid[y][x] & S != 0:
            s += " "
        else:
            s += "_"
        if grid[y][x] & E != 0:
            if (grid[y][x] | grid[y][x + 1]) & S != 0:
                s += " "
            else:
                s += "_"
        else:
            s += "|"
            
    print(s)
    
print(c)