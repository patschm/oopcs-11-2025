namespace DeRadio;

public delegate void OntvangsMethode(string message);

public class RadioStation
{
    // Verkorte (expaando) 
    //public event OntvangsMethode? Message;

    private OntvangsMethode? subscribers;

    public event OntvangsMethode Message
    {
        add
        {
            subscribers += value;
        }
        remove
        {
            subscribers -= value;
        }
    }

    public void Broardcast()
    {
        System.Console.WriteLine("Het radiostation begint met uitzenden...");
        if (subscribers != null)
            subscribers("Hallo luisteraars");

        //subscribers?.Invoke("Hallo luisteraard");
    
    } 
}
