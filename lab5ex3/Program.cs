/*
 * Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere.
 * Atat caracterul cat si sirul de caractere vor fi citite de la tastatura
*/

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Introduceti caracterul pe care doriti sa il cautati");
char ch = Console.ReadLine()[0];

Console.WriteLine("Introduceti sirul de caractere");
string str = Console.ReadLine();

ShowCharacter2(str, ch);

int CountCharacter2(string text, char c)
{
    int numberOfLetters = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (text.ToLower()[i] == char.ToLower(ch) )
        {
            numberOfLetters++;
        }
    }
    return numberOfLetters;
}

void ShowCharacter2(string text, char c)
{
    int numberCaracters = CountCharacter2(str, ch);
    //Console.WriteLine(numberCaracters);
    Console.WriteLine($"Caracterul '{ch}' apare de {numberCaracters} ori in sirul '{str}' ");
}