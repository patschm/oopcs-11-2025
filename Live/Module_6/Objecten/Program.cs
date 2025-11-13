namespace Objecten;

class Program
{
    static void Main(string[] args)
    {
        // Big Bang. Hier begint ons virtuele universum.

        object x = new object();
        //Pen p11 = new Pen();
        //p11.Schrijf("Hallo, wereld!");

        // Dit is nu generaliseren
        Pen mijnVulpen = new VulPen();
        mijnVulpen.Kleur = ConsoleColor.Green;
        SchrijfMetPen(mijnVulpen, "Dit is een vulpen.");
        //mijnVulpen.Schrijf("Dit is een vulpen.");
        for (int i = 0; i < 7; i++)
        {
            mijnVulpen.Schrijf($"Hallo, wereld! {i}");
            if (i == 5) 
            {
                if (mijnVulpen is VulPen)
                    (mijnVulpen as VulPen)?.Vul();
            }
        }

        Pen mijnBalpen = new BalPen();
        mijnBalpen.Kleur = ConsoleColor.Yellow;
        //mijnBalpen.Schrijf("Dit is een balpen.");
        SchrijfMetPen(mijnBalpen, "Dit is een balpen.");
        // Big Crunch. Hier eindigt ons virtuele universum.
    }

    static void SchrijfMetPen(Pen pen, string tekst)
    {
        pen.Schrijf(tekst);
    }
   
}



