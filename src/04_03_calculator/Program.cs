using System.Diagnostics;

int addition(int summand1, int summand2)
{
  return summand1 + summand2;
}

int result_addition = addition(-1,2);

Console.WriteLine("Ergebnis der Addition: " + result_addition);

int differenz(int minuend, int subtrahend)
{
  if (minuend < subtrahend)
  {
    return subtrahend - minuend;
  }
  else
  {
    return minuend - subtrahend;
  }
  
}
int result_differenz = differenz(15,8);

Console.WriteLine("Ergebnis der Differenz: " + result_differenz);

int multiplikation(int faktor1, int faktor2)
{
  int produkt_absolutwert = 0;
  for (int index = 0; index < Math.Abs(faktor1); index++)
  {
    produkt_absolutwert = produkt_absolutwert + Math.Abs(faktor2);
  }
  if (faktor1 <0 ^ faktor2 <0)
  {
    return -produkt_absolutwert;
  }
  else
  {
    return produkt_absolutwert;
  }
}

int result_multiplikation = multiplikation(10,5);

Console.WriteLine("Ergebnis der Multiplikation: " + result_multiplikation);

double division(double dividend, double divisor)
{
  if (divisor == 0)
  {
    return 0;
  } 
  else
  {
    return dividend/divisor;
  }
}

double result_division = division(-10,0);

Console.WriteLine("Ergebnis der Division: " + result_division);