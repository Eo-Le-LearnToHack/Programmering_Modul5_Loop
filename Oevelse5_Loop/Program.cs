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
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=6b5cac34-ef2c-4787-8970-addc014dee39
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
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=64e6cd53-7466-45fb-9ddc-addc014de7f7
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.3: Looping '3 tabel' (For loop)");
//Console.ReadLine();
//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine("i = " + i*3);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.3: Looping '3 tabel' (While loop)");
//Console.ReadLine();
//int i = 1;
//while (i >0 && i <11)
//{
//    Console.WriteLine("i = " + i*3);
//    Console.ReadLine();
//    i++;
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.3: Looping '3 tabel' (Do While loop)");
//Console.ReadLine();
//int i = 3;
//do
//{
//    Console.WriteLine("i = " + i);
//    Console.ReadLine();
//    i=i+3;
//} while (i >= 3 && i <= 30);
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.3: Looping '3 tabel' (For loop, printing array)");
//Console.ReadLine();
//int j = 0;
//int k = 9;
//int[] numArray;
//numArray = new int[k+1];
//for (int i = j; i < numArray.Length; i++)
//{
//    numArray[i] = i + 1;
//    Console.WriteLine(numArray[i] + " = " + numArray[i] * 3);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.3: Looping '3 tabel' (Foreach loop, printing array)");
//Console.ReadLine();
//int j = 0;
//int k = 9;
//int[] numArray;
//numArray = new int[k + 1];
//for (int i = j; i < numArray.Length; i++)
//{
//    numArray[i] = i + 1;
//}
//foreach (int i in numArray)
//{
//    Console.WriteLine(numArray[i - 1] + " = " + i * 3);
//    Console.ReadLine();
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

/*Øvelse 5.4
Lav et program som beder brugeren om en adgangskode. Den korrekte adgangskode er "password". Programmet skal blive ved med at spørge om adgangskoden, indtil den rigtige adgangskode skrives.

💡 Det er en rigtig dårlig ide at bruge password som adgangskode (selvom mange gør det)

Se vejledende løsning til 5.4 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a9494b12-b94a-43d6-8748-addc014de863
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.4: Looping 'entering password' (For loop, Switch)");
//Console.ReadLine();
//const string psw = "password";
//int k = 2;
//Console.WriteLine("Enter the correct password {Case insensitive}");
//for (int i = 1; i < k; i++)
//{
//    string? input_psw = Convert.ToString(Console.ReadLine());
//    switch (input_psw.ToLower())
//    {
//        case psw:
//            Console.WriteLine("Det indtastede password er korrekt");
//            break;
//        default:
//            Console.WriteLine("Det indtastede password er forkert. Prøv igen");
//            k++;
//            break;
//    }
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.4: Looping 'entering password' (For loop, If var.Equals())");
//Console.ReadLine();
//const string psw = "password";
//int k = 2;
//Console.WriteLine("Enter the correct password {Case insensitive}");
//for (int i = 1; i < k; i++)
//{
//    string? input_psw = Convert.ToString(Console.ReadLine());
//    if (input_psw is not null)
//    {
//        if (input_psw.Equals(psw, StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Det indtastede password er korrekt");
//            k = i;
//        }
//        else
//        {
//            Console.WriteLine("Det indtastede password er forkert. Prøv igen");
//            k++;
//        }
//    }
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.4: Looping 'entering password' (While loop, !=)");
//Console.ReadLine();
//const string psw = "password";
//loop:
//Console.WriteLine("Enter the correct password {Case insensitive}");
//string? input_psw = Convert.ToString(Console.ReadLine());
//if (input_psw is not null)
//{
//    while (input_psw.ToLower() != psw)
//    {
//        Console.WriteLine("Det indtastede password er forkert. Tryk ENTER og Prøv igen");
//        Console.ReadLine();
//        goto loop;
//    }
//    Console.WriteLine("Det indtastede password er korrekt");
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.4: Looping 'entering password' (Do While loop, !=)");
//Console.ReadLine();
//const string psw = "password";
//loop:
//Console.WriteLine("Enter the correct password {Case insensitive}");
//string? input_psw = Convert.ToString(Console.ReadLine());
//if (input_psw is not null)
//{
//    do
//    {
//        if (input_psw.ToLower() == psw)
//        {
//            Console.WriteLine("Det indtastede password er korrekt");
//            Console.WriteLine("Press enter to try again");
//            Console.ReadLine();
//            goto start;
//        }
//        else {
//            Console.WriteLine("Det indtastede password er forkert. Tryk ENTER og Prøv igen");
//            Console.ReadLine();
//            goto loop;
//        }
//    } while (input_psw.ToLower() != psw);
//}

//using System;
//Console.Clear();
//Console.WriteLine("Øvelse 5.4: Looping 'entering password' (Do While loop, !=, short version)");
//Console.ReadLine();
//Console.WriteLine("Enter the correct password {Case insensitive}");
//string? input_psw;
//    do {
//    input_psw = Convert.ToString(Console.ReadLine());
//} while (input_psw.ToLower() != "password");


/*Øvelse 5.5
Lav et program, hvor brugeren skal gætte et tal mellem 1 og 10. Programmet skal spørge efter et nyt gæt, så længe brugeren taster forkert.
💡 Det er kedeligt, at computeren altid tænker på det samme tal. Du kan bruge et af kodeeksemplerne på siden Generate Random Numbers til at få computeren til at tænke på et tilfældigt tal.
https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
Se vejledende løsning til 5.5 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ce3930ff-ef0e-4e75-b6db-addc014de830
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.5: Looping 'guessing random number'");
//Random _random = new Random(); //Instantiate a random as the variable _random
//int randomNum = _random.Next(1, 11); //random number from 1-10
//int yourNum;
//do
//{
//    Console.WriteLine("Guess a number from 1-10. Please enter your choice below and press Enter:");
//    yourNum = Convert.ToInt32(Console.ReadLine()); //yourNum
//   // int randomNum = _random.Next(1, 11); //random number from 1-10
//} while (yourNum != randomNum);

//Console.WriteLine("Good guess");
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;



/*Øvelse 5.6
Lav et program, hvor brugeren kan kan indtaste navnene på de personer, der deltager i et arrangement. 
Hver gang brugeren indtaster et navn, skal han spørges om endnu et navn. 
Når der ikke er flere deltagere, skal brugeren bare trykke enter (dvs indtaste et tomt navn). 
Så skal programmet stoppe med at spørge og udskrive antallet af deltagere.
Se vejledende løsning til 5.6 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=202e4052-fda1-4024-a7d7-addc014de7c8
https://www.c-sharpcorner.com/UploadFile/mahesh/add-items-to-a-C-Sharp-list/
https://stackoverflow.com/questions/759133/how-to-display-list-items-on-console-window-in-c-sharp
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.6: Looping 'adding names'");
//string? yourName;
//int count = 0;
//Console.WriteLine("Add a name to your list:");
//List<string> GuestList = new List<string>();
//do
//{
//    yourName = Console.ReadLine();
//    if (yourName != "")
//    {
//        GuestList.Add(yourName);
//        count++;
//    }

//} while (yourName != "");
//if (count == 1)
//{
//    Console.WriteLine($"Der kommer {count} gæst:");
//}
//else
//{
//    Console.WriteLine($"Der kommer {count} gæster:");
//}
//GuestList.ForEach(Console.WriteLine);
//Console.WriteLine("");
//Console.WriteLine("List of names has been created.");
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;


/*Øvelse 5.7
Lav et program, der kan skrive teksten til den klassiske sang 99 bottles of beer on the wall.
Se vejledende løsning til 5.7 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=534a44be-2f16-4b0e-9e69-addc014df67a
http://www.99-bottles-of-beer.net/lyrics.html
NB! FEJL i underviserens eksempel, i det teksten ændrer sig når der er 1 øl tiltabge. Lige ledes når der ingen øl er tilbage.
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.7: Looping 'writing lyric to beer song'");
//for (int flasker = 99; flasker > -1; flasker--)
//{
//    if (flasker > 1)
//    {
//        Console.WriteLine($"{flasker} bottles of beer on the wall, {flasker} bottles of beer.");
//        Console.WriteLine($"Take one down and pass it around, {flasker - 1} bottles of beer on the wall.");
//        Console.WriteLine("");
//    }
//    else if (flasker == 1)
//    {
//        Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
//        Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
//        Console.WriteLine("");
//    }
//    else if (flasker == 0)
//    {
//        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
//        Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
//        Console.WriteLine("");
//    }
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;


/*Øvelse 5.8

Lav et program, som udskriver Den lille tabel.  
💡 Start med at lave et-tabellen og tænk så over, hvordan du får programmet til at lave de øvrige
🤔 Ligner din udskrift en tabel? Hvis ikke, så kig på siden Escape sequences for at se, hvordan du kan formattere din tekst, så den ser (lidt) mere overskuelig ud.

Se vejledende løsning til 5.8 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a69548b2-2c9d-43b5-9c26-addc014df48f
https://www.gangetabel.dk/lille-tabel/
https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//List<string> List0 = new List<string>();
//List<int> List1 = new List<int>();
//List<int> List2 = new List<int>();
//List<int> List3 = new List<int>();
//List<int> List4 = new List<int>();
//List<int> List5 = new List<int>();
//List<int> List6 = new List<int>();
//List<int> List7 = new List<int>();
//List<int> List8 = new List<int>();
//List<int> List9 = new List<int>();
//List<int> List10 = new List<int>();
//for (int i = 0; i < 11; i++)
//{
//    if (i == 0)
//    {
//        List0.Add(" ");
//        for (int j = 1; j < 11; j++)
//        {
//            List0.Add($"{j}");
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List0)));
//    }
//    if (i == 1)
//    {
//        List1.Add(1);
//        for (int j = 1; j < 11; j++)
//        {
//            List1.Add(j);
//        }
//     Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List1)));
//    }
//    if (i == 2)
//    {
//        List2.Add(2);
//        for (int j = 1; j < 11; j++)
//        {
//            List2.Add(j*2);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List2)));
//    }
//    if (i == 3)
//    {
//        List3.Add(3);
//        for (int j = 1; j < 11; j++)
//        {
//            List3.Add(j * 3);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List3)));
//    }
//    if (i == 4)
//    {
//        List4.Add(4);
//        for (int j = 1; j < 11; j++)
//        {
//            List4.Add(j * 4);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List4)));
//    }
//    if (i == 5)
//    {
//        List5.Add(5);
//        for (int j = 1; j < 11; j++)
//        {
//            List5.Add(j * 5);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List5)));
//    }
//    if (i == 6)
//    {
//        List6.Add(6);
//        for (int j = 1; j < 11; j++)
//        {
//            List6.Add(j * 6);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List6)));
//    }
//    if (i == 7)
//    {
//        List7.Add(7);
//        for (int j = 1; j < 11; j++)
//        {
//            List7.Add(j * 7);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List7)));
//    }
//    if (i == 8)
//    {
//        List8.Add(8);
//        for (int j = 1; j < 11; j++)
//        {
//            List8.Add(j * 8);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List8)));
//    }
//    if (i == 9)
//    {
//        List9.Add(9);
//        for (int j = 1; j < 11; j++)
//        {
//            List9.Add(j * 9);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List9)));
//    }
//    if (i == 10)
//    {
//        List10.Add(10);
//        for (int j = 1; j < 11; j++)
//        {
//            List10.Add(j * 10);
//        }
//        Console.WriteLine(string.Format("Here's the list: ({0}).", string.Join(", ", List10)));
//    }
//}

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.8: Looping 'writing 10-tabel'");
//Console.WriteLine();
//for (int linje = 0; linje < 11; linje++)
//{
//    if (linje == 0)
//    {
//        Console.Write(" \t");
//        for (int tal = linje+1; tal < linje + 11; tal = tal + 1)
//        {
//            Console.Write($"{tal}\t");
//        }
//        Console.WriteLine();
//        Console.WriteLine();
//    }
//    else
//    {
//        Console.Write($"{linje}\t");
//        for (int tal = linje; tal < linje * 10 + 1; tal = tal + linje)
//        {
//            Console.Write($"{tal}\t");
//        }
//        Console.WriteLine();
//        Console.WriteLine();
//    }
//}
//Console.WriteLine("Press enter to try again");
//Console.ReadLine();
//goto start;



/*Øvelse 5.9
Lav et program, hvor brugeren kan indtaste et tal, 
hvorefter programmet udskriver den tabel. 
Dvs., hvis brugeren indtaster 4 skriver programmet "4 8 12 … 40"
🤔 Virker dit program også, hvis brugeren indtaster et decimaltal? Hvis ikke, hvad skal der så ændres for at det gør?
Se vejledende løsning til 5.9 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=dadbd072-5ac3-4fd2-adf8-addc014df2d1
*/

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.9: Looping 'Input/Output tabel'");
//Console.WriteLine();
//Console.WriteLine("Indtast et tal fra 1 til 10 for at udskrive den ønskede tabel.");
//double linje;
//do
//{
//    linje = Math.Round(Convert.ToDouble(Console.ReadLine()), 0);
//    if (linje >= 1 && linje <= 10)
//    {
//        for (double tal = linje; tal < linje * 10 + 1; tal = tal + linje)
//        {
//            Console.Write($"{tal}\t");
//        }
//        Console.WriteLine();
//    }
//    else
//    {
//        Console.WriteLine("Invalidt tal. Tryk ENTER og prøv igen.");
//        Console.ReadLine();
//        goto start;
//    }
//} while (linje >= 1 && linje <= 10);


/*Øvelse 5.10
Lav et program hvor brugeren kan indtaste sin adgangskode. 
Hvis adgangskoden er forkert, må brugeren indtaste igen - dog højst tre gange i alt. 
Efter det skal brugeren have at vide, at hans konto er spærret.
Adgangskoden i dette program er også "password".
🤔 Programmet kan laves med eller uden brug af break/continue. Kan du lave begge udgaver?
💡 Det er en dårlig ide at bruge den samme adgangskode i flere forskellige systemer.
Se vejledende løsning til 5.10 her.
https://cphbusiness.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=aff6f410-1a19-44a2-8ab9-addc014df138
 */

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.10: Looping 'Check password _ max 3 times'");
//Console.WriteLine();
//string kode = "password";
//Console.WriteLine("Indtast dit kodeord");
//string? kodeIndtastet = "WrongPasswordPerDefault";
//int kodeIndtastninger = 1;
//do
//{
//    if (kodeIndtastninger < 4)
//    {
//        kodeIndtastet = Console.ReadLine();
//        Console.Clear();
//        if (kodeIndtastet.ToLower() == kode)
//        {
//            Console.WriteLine("Korrekt password. Tryk ENTER og prøv igen.");
//            Console.ReadLine();
//            goto start;
//        }
//        Console.WriteLine($"Forkert password. Antal forsøg brugt: {kodeIndtastninger}");
//        kodeIndtastninger++;
//    }
//    if (kodeIndtastninger > 3)
//    {
//        Console.Clear();
//        Console.WriteLine($"Max antal login forsøg brugt. Antal forsøg brugt: {kodeIndtastninger-1}");
//        Console.WriteLine("Tryk ENTER og prøv igen.");
//        Console.ReadLine();
//        goto start;
//    }
//} while (kodeIndtastet.ToLower() != kode);

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.10: Looping 'Check password _ max 3 times'");
//Console.WriteLine();
//string kode = "password";
//Console.WriteLine("Indtast dit kodeord");
//string? kodeIndtastet = "WrongPasswordPerDefault";
//int kodeIndtastninger = 0;
//do
//{
//    kodeIndtastet = Console.ReadLine();
//    kodeIndtastninger++;
//    if (kodeIndtastet.ToLower() == kode)
//    {
//        Console.WriteLine("Korrekt password. Tryk ENTER og prøv igen.");
//        Console.ReadLine();
//        goto start;
//    }
//} while (kodeIndtastet.ToLower() != kode && kodeIndtastninger < 3);
//Console.WriteLine($"Max antal login forsøg brugt. Antal forsøg brugt: {kodeIndtastninger }");
//Console.WriteLine("Tryk ENTER og prøv igen.");
//Console.ReadLine();
//goto start;

//using System;
//start:
//Console.Clear();
//Console.WriteLine("Øvelse 5.10: Looping 'Check password _ max 3 times'");
//Console.WriteLine();
//string kode = "password";
//Console.WriteLine("Indtast dit kodeord");
//string? kodeIndtastet = "WrongPasswordPerDefault";
//int kodeIndtastninger = 0;
//do
//{
//    kodeIndtastet = Console.ReadLine();
//    kodeIndtastninger++;
//    if (kodeIndtastet.ToLower() == kode)
//    {
//        break; //gør nøjgagtigt det samme hvis continue; var blevet anvendt
//    }
//    if (kodeIndtastninger > 2)
//    {
//        Console.WriteLine($"Max antal login forsøg brugt. Antal forsøg brugt: {kodeIndtastninger }");
//        Console.WriteLine("Tryk ENTER og prøv igen.");
//        Console.ReadLine();
//        goto start;
//    }
//} while (kodeIndtastet.ToLower() != kode && kodeIndtastninger < 3);
//Console.WriteLine($"Korrekt password");
//Console.WriteLine("Tryk ENTER og prøv igen.");
//Console.ReadLine();
//goto start;