﻿/*
 * Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura
*/



Console.WriteLine("Introduceti informatia pe care doriti sa o cautati");
string subs = Console.ReadLine();

Console.WriteLine("Introduceti sirul de caractere");
string str = Console.ReadLine();


CountNumber(subs, str);

void CountNumber (string x, string y)

{
    Console.WriteLine(str.IndexOf(subs, 5, StringComparison.CurrentCultureIgnoreCase));
}
