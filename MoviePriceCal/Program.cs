
internal class Program
{
    private static void Main(string[] args)
    {
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Välkommen till huvudmenyn!");
                Console.WriteLine("Välj ett alternativ genom att skriva in en siffra:");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Räkna ut pris för ett helt sällskap");
                Console.WriteLine("3. Upprepa text tio gånger");
                Console.WriteLine("4. Visa tredje ordet");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Stänger ner programmet...");
                        isRunning = false;
                        break;
                    case "1":
                        Console.WriteLine("Ungdom eller pensionär");
                        CheckAgeForPrice();
                        break;
                    case "2":
                        Console.WriteLine("Räkna ut pris för ett helt sällskap");
                        CalculateGroupPrice();
                        break;
                    case "3":
                        Console.WriteLine("Upprepa text tio gånger");
                        WriteTextTenTimes();
                        break;
                    case "4":
                        Console.WriteLine("Visa tredje ordet");
                        ShowThirdWord();
                        break;

                    default:
                        Console.WriteLine("Felaktig input. Försök igen.");
                        break;
                }
            }

            Console.WriteLine("Programmet är avslutat.");
        }
        // Funktion för menyval 1: Kontrollera ungdom eller pensionär
        static void CheckAgeForPrice()
        {
            Console.Write("Ange din ålder: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age))
            {
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }
            }
            else
            {
                Console.WriteLine("Felaktig input, vänligen ange en siffra.");
            }
        }
    }
    // Funktion för menyval 2: Räkna ut pris
    static void CalculateGroupPrice()
    {
        Console.Write("Hur många personer är ni? ");
        string groupInput = Console.ReadLine();

        if (int.TryParse(groupInput, out int numberOfPeople))
        {
            int totalCost = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out int age))
                {
                    if (age < 20)
                    {
                        totalCost += 80;
                    }
                    else if (age > 64)
                    {
                        totalCost += 90;
                    }
                    else
                    {
                        totalCost += 120;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig input, vänligen ange en siffra.");
                    i--; // Be om ålder igen för samma person
                }
            }

            Console.WriteLine($"Antal personer: {numberOfPeople}");
            Console.WriteLine($"Totalkostnad för hela sällskapet: {totalCost}kr");
        }
        else
        {
            Console.WriteLine("Felaktig input, vänligen ange en siffra.");
        }
    }
    // Funktion för menyval 3: Upprepa text tio gånger
    static void WriteTextTenTimes()
    {
        Console.WriteLine("Skriv en text:");
        string text = Console.ReadLine();

        for (int i = 1; i <= 10; i++)
            Console.Write($"{i}. {text}" + (i < 10 ? ", " : ""));

        Console.WriteLine(); // För ny rad

    }
    // Funktion för menyval 4: Skriva ut tredje ordet
    static void ShowThirdWord()
    {
        Console.WriteLine("Skriv en mening med minst tre ord:");
        string mening = Console.ReadLine();
        string[] ord = mening.Split(' ');

        if (ord.Length >= 3)
            Console.WriteLine($"Det tredje ordet är: {ord[2]}");
        else
            Console.WriteLine("Fel: Du måste ange minst tre ord.");


    }

}