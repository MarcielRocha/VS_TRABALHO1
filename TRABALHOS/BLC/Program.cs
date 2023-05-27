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


string str = "abcde";
char letter = str[1];         // 'b'

foreach (char c in "123") 
  Console.Write (c + ",");    // 1,2,3,

