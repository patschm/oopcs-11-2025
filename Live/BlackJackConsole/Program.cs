
using BlackJack;
using BlackJackConsole;


var speler = new ConsolePlayer();
Tafel tafel = new Tafel(new ConsoleGame(), speler);
Speler p1 = new Speler(tafel, speler){Naam = "Patrick"};
Speler p2 = new Speler(tafel, speler) {Naam = "Gerben"};

tafel.DoeMee(p1);
tafel.DoeMee(p2);

tafel.Start();
