/*
 * Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, 
 * restul literelor fiind transformate in litere mari
*/


using System.Globalization;

Console.WriteLine("Introduceti textul pe care doriti sa il transformati");
string subs = Console.ReadLine();



Console.WriteLine(ToTitleCase(subs));
string ToTitleCase(string subs)
{
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subs.ToLower());
}