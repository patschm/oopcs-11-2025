namespace MoreInteraction;

class Program
{
    static void Main(string[] args)
    {
        Patrick patrick=new Patrick();
        //patrick.DoeIets();

        Gerben gerben = new Gerben();
        gerben.DoeJijMaar(patrick.DoeIets);


        gerben.DoeJijMaar(DraaiRondjes);

        Naam n1 = DraaiRondjes;
        n1(9);
    }

    static void DraaiRondjes(int aantal)
    {
        System.Console.WriteLine($"Draai {aantal} keer in de ronde");
    }
}
