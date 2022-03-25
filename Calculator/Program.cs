// See https://aka.ms/new-console-template for more information
using Calculator;
using System;



double nr1;
double nr2;
string firstNumStr;
string op;


while (true) { 



    Console.WriteLine("Welcome to the calculator");
    Console.WriteLine("Press x to exit");


    Console.WriteLine();
    Console.WriteLine("Skriv in ett nummer, och tryck Ener");
    firstNumStr = Console.ReadLine();
    if (firstNumStr == "x") break;
    nr1=Convert.ToDouble(firstNumStr);
    

    Console.WriteLine("Skriv in ett annat nummer, och tryck Enter");
    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Välj ett av följande val");
    Console.WriteLine("+   addition");
    Console.WriteLine("-   subraktion");
    Console.WriteLine("/   division");
    Console.WriteLine("*   multiplikation");
 
    op = Console.ReadLine();


    CalculationMethod m = new CalculationMethod(nr1,nr2, op );



}


Console.WriteLine("GoodBye");
Console.ReadLine();

double a = 4.5;
double b = 7.5;
double c = a + b;
Console.WriteLine("$hej," +c);

