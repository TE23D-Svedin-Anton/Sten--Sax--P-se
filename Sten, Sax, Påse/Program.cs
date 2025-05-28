string[] val = { "sten", "sax", "påse" }; //Skapa listan av val dator kan göra
Random slump = new Random();
bool spelaIgen = true;

Console.WriteLine("Välkommen till mitt Sten Sax Påse!");

while (spelaIgen)
{

    string spelarensval = "";
    string svar = "";
    bool giltigtSvar = false;
    bool SpelaIgenSvar = false;

    while (!giltigtSvar)
    {
        Console.Write("Välj (sten/sax/påse): ");
        spelarensval = Console.ReadLine().ToLower(); //Läser in det spelaren skrive

        if (spelarensval == "sten" || spelarensval == "sax" || spelarensval == "påse") //Checkar om det är Sten, sax eller påse
        {
            giltigtSvar = true; //Svaret är gilltigt
        }
        else
        {
            Console.WriteLine($"Hörre du, du det är sten, sax eller påse inte {spelarensval}!"); //Säger till spelaren att svaret är ej gilltigt
        }
    }

    string datornsval = val[slump.Next(0, 3)]; //Dator slumpar ett random tal och tar då den sak i listan som numret motsvarar
    Console.WriteLine($"Dator valde: {datornsval}");

    string resultat = AvgörVinnare(spelarensval, datornsval); //Anropar metoden och lägger in två värden
    Console.WriteLine(resultat);

    while (!SpelaIgenSvar)
    {
        Console.Write("\nVill du spela igen? (ja/nej): ");
        svar = Console.ReadLine().ToLower();

        if (svar == "ja" || svar == "nej") // Checkar så svaren är giltiga
        {
            SpelaIgenSvar = true;
            if (svar == "nej") // om svaret är nej
            {
                spelaIgen = false; // avsluta spelet
            }
        }
        else
        {
            Console.WriteLine($"Hörre du, du det är ett ja eller nej inte {spelarensval}!"); // Säger till spelaren att svaret ej är gilltigt
        }
    }
    Console.Clear(); // Ta bort allt från förra rundan så blir det mer cleant

}

    string AvgörVinnare(string spelare, string dator) 
    {
        if (spelare == dator) // checkar om värdena är lika
            return "Oavgjort!";

        if ((spelare == "sten" && dator == "sax") ||
           (spelare == "sax" && dator == "påse") ||
           (spelare == "påse" && dator == "sten")) // checkar om spelaren vinner
            return "Du vann!";

        return "Datorn vann!"; // annars vinner dator
    }
