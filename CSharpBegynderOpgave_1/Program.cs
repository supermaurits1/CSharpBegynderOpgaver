﻿//Lav et "visitkort" Hvor du skriver dit navn, alder, Interesser, Yndlingsdyr og så videre.
//Udsmyk visitkortet med farver og evt ASCII art.


using System;

Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("==============================================================");
Console.WriteLine("                      hej                                     ");
Console.WriteLine("==============================================================");
Console.ReadKey(); // Venter på brugerinput, før programmet lukker 

string input = Console.ReadLine();



// Eksempler på kommandoer


// Dette er en kommentar og læses ikke at programmet.

// Ændrer baggrunds- og tekstfarve i konsollen
//Console.BackgroundColor = ConsoleColor.DarkBlue;
//Console.Clear(); // Opdaterer konsolbaggrunden
//Console.ForegroundColor = ConsoleColor.Yellow;
//
//// Laver en overskrift med centrering
//Console.WriteLine("========================================");
//Console.WriteLine("             MIT VISITKORT              ");
//Console.WriteLine("========================================");
//
//// Resetter farverne for det næste indhold
//Console.ResetColor();
//Console.ForegroundColor = ConsoleColor.Cyan;
//
//// Skriver personlig information
//Console.WriteLine("\nNavn: John Doe");
//Console.WriteLine("Alder: 10 år");
//Console.WriteLine("Hobbyer: Spille spil, programmere, fodbold");
//Console.WriteLine("Yndlingsfarve: Grøn");
//
//// Tilføjer lidt mellemrum og prompt for at afslutte programmet
//Console.ResetColor();
//Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
//Console.ReadKey(); // Venter på brugerinput, før programmet lukker