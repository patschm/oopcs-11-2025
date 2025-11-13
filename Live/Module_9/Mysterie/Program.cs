namespace Mysterie;

class Program
{
    static void Main(string[] args)
    {
        StructVsClass();
    }



    

    static void StructVsClass()
    {
        Point p1 = new Point{X=10, Y=20};
        p1.builder.Append("P1 object");
        System.Console.WriteLine(p1);
        DoeIets(p1);
        System.Console.WriteLine(p1);

        //System.Console.WriteLine(p1.builder.ToString());

    }
    static void DoeIets(Point px)
    {
        px.X = 1000;
        px.Y = 2000;

        //px.builder.Append("PX object");
    }
}
