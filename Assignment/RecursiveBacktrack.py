import sys
import random

width = 10 #int(input("Width: "))
height = 10 #int(input("Height: "))
# seed = int(input("Seed: "))

grid = [ [0] * width ] * height

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
    global c
    c += 1
    directions = [N, S, E, W]
    # random.shuffle(directions)
    
    # print(directions)
    
    for direction in directions:
        
        nx = cx + DX[direction]
        ny = cy + DY[direction]
        
        print("nx " + str(nx))
        # print("dx " + str(DX[direction]))
        print("ny " + str(ny))
        # print("dy " + str(DY[direction]))
        print(len(grid[ny]))
        print(len(grid))
        
        print(0 <= ny < len(grid))
        print(0 <= nx < len(grid[ny]))
        # print(grid[ny][nx])
        
        #if ((0 <= ny < len(grid)) and (0 <= nx < len(grid[ny]))) and grid[ny][nx] == 0:
            
        if ny >= 0 and nx < len(grid):
            
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