/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

Console.WriteLine("Welcometo Knight vs Goblin!");
Console.WriteLine("---------------------------");

Console.WriteLine("Enter Knight Health between 1 and 100: ");
string inputKnightHealth = Console.ReadLine();

Random randomNumberGenerator = new Random();
int goblinHealth = randomNumberGenerator.Next(1, 101);
int knightHealth;
if (int.TryParse(inputKnightHealth, out knightHealth))
{
    if (knightHealth <= 0 || knightHealth >= 100)
    {
        Console.WriteLine("Invalid number. Default value 100 is used");
        knightHealth = 100;
    }
}
else
{
    //Ongeldig getal
    Console.WriteLine("Invalid number. Default value 100 is used");
    knightHealth = 100;
}

Console.WriteLine($"Knight health:{knightHealth}");
Console.WriteLine($"Goblin health: {goblinHealth}");

do
{

    int attackKnight = 10;
    int attackGoblin = randomNumberGenerator.Next(5, 16);

    Console.WriteLine("To attack press 1 or A and to heal press 2 or H: ");
    string selectedAction = Console.ReadLine();

    switch (selectedAction)
    {
        case "A":
        case "1":
            goblinHealth -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You attacked the Goblin for {attackKnight}");
            Console.ResetColor();
            break;
        case "H":
        case "2":
            knightHealth += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You healed yourself for 10 points");
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Invalid Move, please choose a valid move");
            Console.ResetColor();
            break;
    }

    if (goblinHealth > 0)
    {
        knightHealth -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The Goblin attacked you for {attackGoblin}");
        Console.ResetColor();
    }


    if (knightHealth <= 0)
    {
        Console.WriteLine("You have died!");
    }
    else
    {
        Console.WriteLine("Knight Health: " + knightHealth);
    }

    if (goblinHealth <= 0)
    {
        Console.WriteLine("Goblin has died");
    }

    else
    {
        Console.WriteLine($"Goblin Health : {goblinHealth}");
    }
} while ( knightHealth > 0 && goblinHealth > 0 );






/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
