// See https://aka.ms/new-console-template for more information

/* Øvelse 5.1
 
Lav et program, som udskriver tallene fra 1 til 10.

🤔 Prøv at lave en ny udgave af det samme program, som gør det samme, men bruger en anden slags løkke.

Se vejledende løsning til 5.1 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=77fe4fa8-c359-401f-a21e-addc014defc7
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.1: Looping from 1 to 10 (For loop)");
//Console.ReadLine();
//for (int i = 1; i < 11; i++)
//			{
//			Console.WriteLine("i = " + i);
//			Console.ReadLine();
//			}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.1: Looping from 1 to 10 (While loop)");
//Console.ReadLine();
//int i = 1;
//while (i >= 1 && i <= 10)
//{
//	Console.WriteLine("i = " + i);
//	Console.ReadLine();
//	i++;
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.1: Looping from 1 to 10 (Do While loop)");
//Console.ReadLine();
//int i = 1;
//do
//{
//	Console.WriteLine("i = " + i);
//	Console.ReadLine();
//	i++;
//} while (i >= 1 && i <= 10);
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.1: Looping from 1 to 10 (For loop, printing array)");
//Console.ReadLine();
//int[] numArray = {1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};
//for (int i = 0; i < numArray.Length; i++)
//{
//    Console.WriteLine("i = " + numArray[i]);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.1: Looping from 1 to 10 (Foreach loop, printing array, applying continue and break)");
//Console.ReadLine();
//int[] numArray = { 1, 33, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//foreach (int i in numArray)
//{
//    if (i == 33) continue; //Skip 33
//    if (i == 11) break; //Stop loop at 11 and does not print out 11.
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;



/* Øvelse 5.2
Lav et program, som udskriver tallene fra 10 til 1.


Se vejledende løsning til 5.2 her.
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.2: Looping from 10 to 1 (For loop)");
//Console.ReadLine();
//for (int i = 10; i < 11; i--)
//{
//    if (i < 1) break;
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.2: Looping from 10 to 1 (While loop)");
//Console.ReadLine();
//int i = 10;
//while (i <= 10 && i >= 1)
//{
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//    i--;
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.2: Looping from 10 to 1 (Do While loop)");
//Console.ReadLine();
//int i = 10;
//do
//{
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//    i--;
//} while (i >= 1 && i <= 10);
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.2: Looping from 10 to 1 (For loop, printing array)");
//Console.ReadLine();
//int[] numArray = {1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};
//for (int i = 9; i < numArray.Length; i--)
//{
//    if (i < 0) break;
//    Console.WriteLine("i = " + numArray[i]);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.2: Looping from 10 to 1 (Foreach loop, printing array, applying continue and break)");
//Console.ReadLine();
//int[] num_Array = { 1, 33, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//Array.Reverse(num_Array);
//foreach (int i in num_Array)
//{
//    if (i == 33) continue; //Skip 33
//    if (i == 11) continue; //Stop loop at 11 and does not print out 11.
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;


/*Øvelse 5.3
Lav et program, som udskriver 3-tabellen til og med 30 (altså 3, 9, 12 osv)


Se vejledende løsning til 5.3 her.
*/

/*Øvelse 5.4
Lav et program som beder brugeren om en adgangskode. Den korrekte adgangskode er "password". Programmet skal blive ved med at spørge om adgangskoden, indtil den rigtige adgangskode skrives.

💡 Det er en rigtig dårlig ide at bruge password som adgangskode (selvom mange gør det)

Se vejledende løsning til 5.4 her.
*/

/*Øvelse 5.5

Lav et program, hvor brugeren skal gætte et tal mellem 1 og 10. Programmet skal spørge efter et nyt gæt, så længe brugeren taster forkert.

💡 Det er kedeligt, at computeren altid tænker på det samme tal. Du kan bruge et af kodeeksemplerne på siden Generate Random Numbers til at få computeren til at tænke på et tilfældigt tal.


Se vejledende løsning til 5.5 her.
*/

/*Øvelse 5.6
Lav et program, hvor brugeren kan kan indtaste navnene på de personer, der deltager i et arrangement. Hver gang brugeren indtaster et navn, skal han spørges om endnu et navn. 

Når der ikke er flere deltagere, skal brugeren bare trykke enter (dvs indtaste et tomt navn). Så skal programmet stoppe med at spørge og udskrive antallet af deltagere.


Se vejledende løsning til 5.6 her.
*/

/*Øvelse 5.7
Lav et program, der kan skrive teksten til den klassiske sang 99 bottles of beer on the wall.

Se vejledende løsning til 5.7 her.
*/

/*Øvelse 5.8

Lav et program, som udskriver Den lille tabel.  

💡 Start med at lave et-tabellen og tænk så over, hvordan du får programmet til at lave de øvrige

🤔 Ligner din udskrift en tabel? Hvis ikke, så kig på siden Escape sequences for at se, hvordan du kan formattere din tekst, så den ser (lidt) mere overskuelig ud.

Se vejledende løsning til 5.8 her.
*/

/*Øvelse 5.9
Lav et program, hvor brugeren kan indtaste et tal, hvorefter programmet udskriver den tabel. Dvs., hvis brugeren indtaster 4 skriver programmet "4 8 12 … 40"

🤔 Virker dit program også, hvis brugeren indtaster et decimaltal? Hvis ikke, hvad skal der så ændres for at det gør?


Se vejledende løsning til 5.9 her.
*/

/*Øvelse 5.10
Lav et program hvor brugeren kan indtaste sin adgangskode. Hvis adgangskoden er forkert, må brugeren indtaste igen - dog højst tre gange i alt. Efter det skal brugeren have at vide, at hans konto er spærret.

Adgangskoden i dette program er også "password".

🤔 Programmet kan laves med eller uden brug af break/continue. Kan du lave begge udgaver?

💡 Det er en dårlig ide at bruge den samme adgangskode i flere forskellige systemer.

Se vejledende løsning til 5.10 her.
 */
