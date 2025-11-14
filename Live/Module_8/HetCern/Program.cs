using System.Xml.Schema;

namespace HetCern;

class Program
{
    static void Main(string[] args)
    {
        WillemKlein willem = new WillemKlein();
        SimonVdMeer simon = new SimonVdMeer();

        //willem.Bereken(simon.Add, 5, 6);

        MathDel<int> m1 = simon.Add;
        m1 += simon.Add;
        m1 += simon.Subtract;
        m1 += simon.Add;
        m1 += simon.Add;
        m1 -= simon.Subtract;

        foreach(var fun in m1.GetInvocationList())
        {
            System.Console.WriteLine(fun.Method.Name);
        }

        int result = m1(1,2);


        System.Console.WriteLine(result);
    }
}
