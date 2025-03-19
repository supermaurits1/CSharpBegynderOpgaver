//Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert


Console.WriteLine("Indtast et tal mellem 1 og 5");

Random random = new Random();




int Resultat = random.Next(1, 10);
while (Resultat < 3);
{
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == Resultat)
    {
        Console.WriteLine("RIGTIGT");
        break;
    }
    else if (input > Resultat)
    {
        Console.WriteLine("hehehehehe du gættede forkert");
    }
    else
    {
        Console.WriteLine("du gættede forkert");
    }
} 
   




Console.WriteLine(Resultat);
Console.ReadLine();



//Eksempel på while loop

//While loop der tæller til 10
//int counter = 0;
//while(counter < 10)

//	Console.WriteLine(counter);
//counter++;


//Console.ReadKey();
//Console.WriteLine("");

//Eksempel på for loop
//for(int i = 0; i < 10; i += 2)

//	Console.WriteLine(i);

//Console.ReadKey();


