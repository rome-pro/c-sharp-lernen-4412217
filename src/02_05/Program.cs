/*----------- Aufgabe 1  Ausgabe einzelner Zeichen --------------------*/

// Anlegen und initialisieren der ersten Variable
char meine_erstes_Zeichen = 'T';

// Anlegen und initialisieren der zweiten Variable 
// durch zuweisung der ersten Variable
int meine_Variable = meine_erstes_Zeichen;

// Ausgeben der Variablen auf die Konsole
Console.WriteLine("Die char Variable: " + meine_erstes_Zeichen);
Console.WriteLine("Die int Variable: " + meine_Variable);


/*----------- Aufgabe 2 Zeichenkette -------------------------------*/

string string_eins = "The quick fox";
string string_zwei = " jumps over the lazy dog";
string string_drei = string_eins + string_zwei;

Console.WriteLine(string_drei);