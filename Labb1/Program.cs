
Console.WriteLine("Skriv in valfri sträng:");
string input = Console.ReadLine();  

long summa = 0;

for (int i = 0; i < input.Length; i++)
{
    //Om.. char är en siffra
    if (char.IsDigit(input[i]))
    {
        string delsträng = input[i].ToString();

        for (int j = i + 1; j < input.Length; j++)
        {
            //Om.. Char INTE är en siffra, bryt. 
            if (!char.IsDigit(input[j]))
            {
                break;
            }
            // Om.. talen är skilda. Lägg till tecken till delsträng.
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

                long.TryParse(delsträng, out long sum);
                summa += sum;
                break;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Total = " + summa);