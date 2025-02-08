int Var1 = 10;
int Var2 = 2;
int index = 0;

while (Var2 <= Var1)
{
  Var1++;
  Var2 = Var2 + 2;
  index++;
}
Console.WriteLine("Anzahl der Schleifendurchläufe: " + index);
Console.WriteLine("Var 1 = " + Var1 + " und Var2 = " + Var2);