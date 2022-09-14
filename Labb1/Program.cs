
using System.Xml.Schema;

Console.WriteLine("Skriv in valfri sträng:");
//string input = Console.ReadLine();  
string input = "29535123p48723487597645723645";

    for (int i = 0; i < input.Length; i++)
    {
        char tecken = input[i];

        if (char.IsDigit(tecken))
        {
            //char startNumber = tecken;
            //string delsträng = startNumber.ToString();
            string delsträng = tecken.ToString();
           
            for (int j = i + 1; j < input.Length; j++)
            {
                char deltecken = input[j];
                
                if (char.IsLetter(deltecken))
                {
                    break;
                }

            if (deltecken != tecken/*startNumber*/)
            {
                delsträng += deltecken;
            }

            else
            {
                    delsträng += deltecken;

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