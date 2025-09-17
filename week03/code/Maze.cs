public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        var currentLocation = (_currX, _currY);
        
        // Get the direction array for current location
        if (_mazeMap.ContainsKey(currentLocation))
        {
            bool[] directions = _mazeMap[currentLocation];
            
            // Check if we can move left (index 0)
            if (directions[0])
            {
                _currX -= 1; // Move left (decrease x)
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        var currentLocation = (_currX, _currY);
        
        if (_mazeMap.ContainsKey(currentLocation))
        {
            bool[] directions = _mazeMap[currentLocation];
            
            // Check if we can move right (index 1)
            if (directions[1])
            {
                _currX += 1; // Move right (increase x)
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        var currentLocation = (_currX, _currY);
        
        if (_mazeMap.ContainsKey(currentLocation))
        {
            bool[] directions = _mazeMap[currentLocation];
            
            // Check if we can move up (index 2)
            if (directions[2])
            {
                _currY -= 1; // Move up (decrease y)
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        var currentLocation = (_currX, _currY);
        
        if (_mazeMap.ContainsKey(currentLocation))
        {
            bool[] directions = _mazeMap[currentLocation];
            
            // Check if we can move down (index 3)
            if (directions[3])
            {
                _currY += 1; // Move down (increase y)
            }
            else
            {
                throw new InvalidOperationException("Can't go that way!");
            }
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}