int theNumber = new Random().Next(20);
int anzahl_versuche = 0;
bool suchen = true;

Console.WriteLine("Lass uns das Spiel 'Zahlen raten' spielen!");
Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 20 aus.");
Console.WriteLine("Versuche meine Zahl zu erraten, oder tippe -1 um das Spiel zu beenden.");



while (suchen == true)
{
  Console.WriteLine("Nenne mir eine Zahl");
  string eingabestring = Console.ReadLine();

  if (int.TryParse(eingabestring, out int input))
  {
    if (input == -1)
    {
      Console.WriteLine("Du hast das Spiel abgebrochen.");
      suchen = false;
    }
    else if (input < theNumber)
    {
      Console.WriteLine("Die gesuchte Zahl ist größer als die Eingabe");
    }
    else if (input > theNumber)
    {
      Console.WriteLine("Die gesuchte Zahl ist kleiner als die Eingabe");
    }
    else if (input == theNumber)
    {
      Console.WriteLine("Du hast das richtige Ergebnis gefunden.");
      suchen = false;
    }
  }
  else
  {
    Console.WriteLine("Die Eingabe ist keine gültige Zahl.");
  }
anzahl_versuche++;
}
Console.WriteLine("Die richtige Zahl war: " + theNumber);
Console.WriteLine("Du hast " + anzahl_versuche + " Werte eingegeben.");
Console.WriteLine("Das Spiel ist beendet.");
