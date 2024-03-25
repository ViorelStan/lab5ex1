/*
 *Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit de la tastatura, ignorand caseing-ul literelor.
*/

using Microsoft.VisualBasic;
using System.Reflection.Metadata;

Console.WriteLine("Introduceti informatia pe care doriti sa o cautati");
string subs = Console.ReadLine();



maxOccurrences(subs);
void maxOccurrences(string x)
{ 
int maxOccurrences = 0;
string rezultat= "";
    foreach (var myString in x)
{
        var occurrences = x.ToLower().Count(x => x == myString);
    if (occurrences > maxOccurrences)
    {
        maxOccurrences = occurrences;
        char character = myString;
         rezultat = $"Caracterul {character} apare de {maxOccurrences} ori";
        }
    }
Console.WriteLine(rezultat);
}

