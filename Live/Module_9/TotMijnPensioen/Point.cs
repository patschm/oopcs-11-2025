namespace TotMijnPensioen;

public struct Point<T> where T: new()
{
    public T X { get; set; }
    public T Y { get; set; }
    
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public T Create()
    {
        return new T();
    }
}
