namespace TheFirm;

class Program
{
    static void Main(string[] args)
    {
        IACMEContract patrick = new Patrick();
        patrick.DoWork();

        Gerben gerben = new Gerben();
        Bokito bokito = new Bokito();
        ACME acme = new ACME();

        //acme.Hire(patrick);
        acme.Hire(gerben);
        acme.Hire(bokito);
        acme.Start();
    }
}
