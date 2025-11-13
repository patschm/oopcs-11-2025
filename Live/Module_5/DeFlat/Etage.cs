namespace DeFlat;

public class Etage(int nummer)
{
    // _lift is ne een gedeeld (static) object voor alle Etage-instanties
    // Geen enkele Etage kan dit object claimen.
    public static readonly Lift _lift;// = new();

    static Etage()
    {
        System.Console.WriteLine("Static constructor Etage");
        Etage._lift = new Lift();
    }
    public void CallLift()
    {
        // this._lift kan niet. Lift is niet van mij.
        // static members kan ik alleen aanroepen via de class-naam.
        // Vandaar dat static member ook wel class members worden genoemd.
        // Members die via this (of een instantie-naam) worden aangeroepen 
        // heten instance members.
        _lift.Call(nummer);
    }
    public static void ShowLiftPosition()
    {
        Console.WriteLine($"Der Lift ist auf Etage {_lift.CurrentEtage}.");
    }
}
