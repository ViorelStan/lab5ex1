/*
 * Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom
*/



using Microsoft.Win32.SafeHandles;

Console.WriteLine("Introduceti sirul de caractere");
string original = Console.ReadLine();


Panlindrom(original);
Checking(Panlindrom(original));


bool Panlindrom(string x)
{
    
    string reversed = new string(original.Reverse().ToArray());
    var check = original.ToLower() == reversed.ToLower();
    return check;
}

void Checking(bool x)
{
    if (x == true)
    {
        Console.WriteLine("Sirul de caractere este palindrom");
    }
    else
    {
        Console.WriteLine("Sirul de caractere nu este palindrom");
    }
}
