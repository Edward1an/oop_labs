using System;
using oops;

Console.WriteLine("Hello, World choose lab");
int labNumber = int.Parse(Console.ReadLine());

switch (labNumber)
{
    case 1:
        Lab1 lab1 = new Lab1();
        lab1.execute();
        break;

    case 2:

        Lab2 lab2 = new Lab2();
        lab2.execute();
        break;
    case 3:
        Lab3 lab3 = new Lab3();
        lab3.execute();
        break;
    case 4:
        Lab4 lab4 = new Lab4();
        lab4.execute();
        break;

}





