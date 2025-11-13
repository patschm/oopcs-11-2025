using System.Text;

namespace Mysterie;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    //public StringBuilder builder = new StringBuilder();

    public Point()
    {}
    
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
