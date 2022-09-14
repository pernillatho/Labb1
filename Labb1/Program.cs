
using System.Xml.Schema;

Console.WriteLine("Skriv in valfri sträng:");
//string input = Console.ReadLine();  
string input = "29535123p48723487597645723645";

    
    for (int i = 0; i < input.Length; i++)
    {
        //Om.. char är en siffra
        if (char.IsDigit(input[i]))
        {
            string delsträng = input[i].ToString();
           
            for (int j = i + 1; j < input.Length; j++)
            {
                //Om.. Char är en bokstav, bryt. 
                if (char.IsLetter(input[j]))
                {
                    break;
                }
                // Om.. dom är skilda.
                if (input[j] != input[i])
                {
                   delsträng += input[j];
                }
                else
                {
                    delsträng += input[j];

                    string startsträng = input.Substring(0, i);
                    string slutsträng = input.Substring(startsträng.Length + delsträng.Length);

                    Console.Write(startsträng);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(delsträng);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(slutsträng);

                    Console.WriteLine();
                    break;
                }
            }
        }
    }