﻿//Lav et spil hvor man kan gætte et, af computeren, random genereret tal.






//Random random = new Random();
//int Resultat = random.Next(0, 6); //Generere et random tal imellem 0 og 5. (0 er med, men 6 er ikke)
//Console.WriteLine(Resultat);






using System.ComponentModel.Design;

Console.WriteLine("Indtast et tal mellem 1 og 5");

Random random = new Random();

int Resultat = random.Next(1, 6); 
int input = Convert.ToInt32(Console.ReadLine());

if (input == Resultat) 
{
    Console.WriteLine("RIGTIGT");
}
else if (input > Resultat)
{
    Console.WriteLine("hehehehehe du gættede forkert");
}
else 
{
    Console.WriteLine("du gættede forkert");
}

Console.ReadLine();




//int a = 1;
//int b = 2;
////Dette er if statements og bruges til at sammenligne værdier, det skal bruges til spillet.
//if(a > b)
//{
//	Console.WriteLine("A er større end B");
//}
//else if(a < b)
//{
//	Console.WriteLine("A er mindre end B");
//}
//else
//{
//	Console.WriteLine("A og B er ens!");
//}


////En Console.ReadLine() returnere altid en streng, hvis vi skal lave den om til en int er vi nødt til at pakke det ind i Convert.ToInt()
//Console.WriteLine("Indtast et tal:");
//int input = Convert.ToInt32(Console.ReadLine()); //Det giver altså en fejl hvis vi taster noget ind som IKKE er et tal!
//Console.WriteLine(input); //Udskriv inputtet.


//Console.ReadKey();