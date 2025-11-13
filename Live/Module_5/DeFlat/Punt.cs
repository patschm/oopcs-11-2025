namespace DeFlat;

public class Punt
{
    public int X { get; set; }
    public int Y { get; set; }

    public int this[string index]
    {
        get
        {
            if (index == "x") return X;
            else if (index == "y") return Y;
            else throw new IndexOutOfRangeException();
        }
        set
        {
            if (index == "x") X = value;
            else if (index == "y") Y = value;
            else throw new IndexOutOfRangeException();
        }
    }

    public static Punt operator+(Punt a, Punt b)
    {
        Punt result = new Punt();
        result.X = a.X + b.X;
        result.Y = a.Y + b.Y;
        return result;
    }   

    public static bool operator==(Punt a, Punt b)
    {
        return a.X == b.X && a.Y == b.Y;
    }
    public static bool operator!=(Punt a, Punt b)
    {
        return !(a == b);
    }   

    public static explicit operator double(Punt p)
    {
        return Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2));
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
