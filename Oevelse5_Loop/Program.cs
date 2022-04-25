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
