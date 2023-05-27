// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(char.ToUpper('c'));             // C
Console.WriteLine(char.IsWhiteSpace('\t'));       // True
Console.WriteLine(char.IsLetter('x'));            // True
Console.WriteLine(char.GetUnicodeCategory('x'));  // LowercaseLetter

Console.WriteLine(new string('*', 10));    // **********

char[] ca = "Hello".ToCharArray();
string s = new string(ca);                 // Reconstrução de string a partir de vetor de chars
Console.WriteLine(s);                      // "Hello"

string empty = "";
Console.WriteLine(empty == "");                        // True
Console.WriteLine(empty == string.Empty);              // True
Console.WriteLine(empty.Length == 0);                  // True

string nullString = null;
Console.WriteLine(nullString == null);                 // True
Console.WriteLine(nullString == "");                   // False
Console.WriteLine(string.IsNullOrEmpty (nullString));  // True
Console.WriteLine(nullString.Length == 0);             // NullReferenceException
