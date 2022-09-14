// See https://aka.ms/new-console-template for more information


using Class_Math2;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

int x = 10;
int y = 20;

int min = Math2.Min(x, y);
int max = Math2.Max(x, y);
bool equal = Math2.AreEqual(x, y);
int sum = Math2.Sum(x, y);



Console.WriteLine(" O valor inteiro mínimo é: " + min);
Console.WriteLine(" O valor inteiro máximo é: " + max);
Console.WriteLine(" Os valores são iguais ? " + equal);
Console.WriteLine(" O valor da soma é: " + sum);
Math2.Swap(x, y);


Console.Read();