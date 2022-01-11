maze = [[0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0], [0, 0, 0, 0, 0]]

def hasNeighborInDirection(arr, x, y, direction):

    if direction == NORTH:
        if (y - 1) >= 0:
            # return [x, y - 1]
            return [y - 1, x]
            
    elif direction == SOUTH:
        if (y + 1) < len(arr[x]):
            # return [x, y + 1]
            return [y + 1, x]
            
    elif direction == EAST:
        if (x + 1) < len(arr):
            # return [x + 1, y]
            return [y, x + 1]
            
    else:
        if (x - 1) >= 0:
            # return [x - 1, y]
            return [y, x - 1]

    return (-1, -1)

# This is hardcoded, should be randomised within the recursivePassage definition below
NORTH = 1
SOUTH = 2
EAST = 4
WEST = 8

directionsOrder = [NORTH, SOUTH, EAST, WEST]

def recursivePassage(arr, x, y):
    
    for direction in directionsOrder:
        
        neighbor = hasNeighborInDirection(arr, x, y, direction)

        if neighbor == (-1, -1):
            # Neighbor does not exist, so this direction is unviable
            continue
        
        print(direction)
        print("\n".join([str(row) for row in arr]))
        print(str(neighbor))

        currentNeighborValue = arr[neighbor[0]][neighbor[1]]

        if currentNeighborValue > 0:
            print("Neighbor has already been visited")
            continue

        arr[x][y] += direction
        arr[neighbor[0]][neighbor[1]] += direction
        
        # print("\n".join([str(x) for x in arr]))
        
        recursivePassage(arr, neighbor[0], neighbor[1])

recursivePassage(maze, 0, 0)

print("\n".join([str(x) for x in maze]))
