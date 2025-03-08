using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start de game
            Game game = new Game();
            game.Start();
        }
    }

    class Game
    {
        private List<string> notepad = new List<string>();  // Dit is je in-game notepad

        public void Start()
        {
            // Begin bij de eerste scène
            Scene0();
        }

        private void Scene0()
        {
            Console.WriteLine("Welcome to this text adventure game!");
            Console.WriteLine("This story will be about a murder and You are Doctor Temprance Brennan and together with your friend and FBI agent Booth you will solve a murder!");
            Console.WriteLine("We recommend to use get a notepad and write your findings. But we will also give all the clues on a notepad for you in this console!!!");
            Console.WriteLine("Let's Start!");
            Console.ReadKey();
            Scene1();
        }

        private void Scene1()
        {
            bool Angela = false;
            bool Jack = false;
            bool Cam = false;
            bool Zack = false;
            Console.Clear();
            Console.WriteLine("Je bevindt je in het Jeffersonian Institute, omringd door de geur van oud bot en conserveringsmiddelen. Het geluid van skeletten die tegen elkaar tikken bij het verplaatsen vult de ruimte. Agent Seeley Booth staat naast je, zijn gezicht strak. Hij vouwt zijn armen over elkaar en knikt richting een tafel bedekt met botten.\r\n\r\n\"We hebben een probleem,\" zegt hij met een zucht. \"Dr. Ethan White, een archeoloog, werd dood aangetroffen… hier, tussen de andere skeletten in het lab. Alsof hij er gewoon bij hoorde.\"\r\n\r\nHij wijst naar een gedeeltelijk gereconstrueerd skelet, zorgvuldig uitgestald, maar de botten zijn niet allemaal even oud. Tussen de eeuwenoude resten ligt iets nieuwer—te nieuw.\r\n\r\n\"Dit is geen opgraving. Dit is een moord.\"");
            Console.WriteLine("Wie neem je mee?");
            Console.WriteLine("1. Angela Montenegro - Expert in reconstructies en visualisaties.");
            Console.WriteLine("2. Dr. Jack Hodgins - Specialist in sporenonderzoek en entomologie.");
            Console.WriteLine("3. Dr. Camille 'Cam' Saroyan - Forensisch patholoog en hoofd van het lab.");
            Console.WriteLine("4. Dr. Zack Addy - Briljante maar sociaal ongemakkelijke forensisch antropoloog.");
            Console.Write("Maak een keuze: ");

            var choice = Console.ReadLine();
            string partner = "";

            switch (choice)
            {
                case "1":
                    partner = "Angela Montenegro";
                    Angela = true;
                    Console.WriteLine("\nJe kiest Angela. Tijd om het slachtoffer een gezicht te geven.");
                    break;
                case "2":
                    partner = "Dr. Jack Hodgins";
                    Jack = true;
                    Console.WriteLine("\nJe kiest Hodgins. Misschien kan hij microscopische aanwijzingen vinden.");
                    break;
                case "3":
                    partner = "Dr. Camille 'Cam' Saroyan";
                    Cam = true;
                    Console.WriteLine("\nJe kiest Cam. Zij kan alles over de doodsoorzaak achterhalen.");
                    break;
                case "4":
                    partner = "Dr. Zack Addy";
                    Zack = true;
                    Console.WriteLine("\nJe kiest Zack. Zijn analytische brein zal zeker van pas komen.");
                    break;
                default:
                    Console.WriteLine("\nOngeldige keuze, probeer opnieuw.");
                    Console.ReadKey();
                    Scene1();
                    return; // Stop de huidige scene en ga terug naar het begin van Scene 1
                    }
            Scene1b(partner);
        }
     
private void Scene1b(string partnerchoice1) {
    bool clueDraakArm = false;
    Console.Clear();
    Console.WriteLine("Je zit in de auto met Booth en " + partnerchoice1 + ". Je stapt de SUV uit, de koude lucht bijt in je huid. Het Smithsonian National Museum of Natural History ligt voor je, zijn grote glazen gevel verlicht door de straatlantaarns, terwijl je voetstappen echoën op de marmeren trappen. Booth loopt snel naar de ingang, maar jij, als altijd, kan het niet helpen je gedachten te laten afdwalen naar de puzzel voor je.\r\n\r\nHet museum is stil, de sfeer zwaar van oude geschiedenis en wetenschap. De deuren schuiven open en je stapt de ruimte binnen, je ogen al zoekend naar de details—de barst in de vloer, de geuren van stof en oud papier. De ruimte is leeg, de hal immens.\r\n\r\nBooth werpt je een korte blik, maar het duurt niet lang voor je al je gedachten op de zaak richt. \"Het lichaam moet hier ergens zijn,\" zegt hij, maar je hebt je aandacht al verlegd naar de vitrines langs de muren.\r\n\r\n\"De temperatuur hier is laag, te laag voor een normale tentoonstelling,\" zeg je, je stem bijna zoals altijd analytisch. \"En de luchtvochtigheid... te hoog voor behoud van de mummies, dit zou de vervalprocessen versnellen. Wat moeten ze verborgen houden?\"\r\n\r\nBooth kijkt even op, maar haalt zijn schouders op. \"Je hebt gelijk, maar ik ben meer geïnteresseerd in het lichaam.\"\r\n\r\nDat is wanneer je de figuur op de vloer ziet liggen. In het midden van de zaal ligt het lichaam van een onbekende man, het ligt op een vreemde, onnatuurlijke manier. De omgeving lijkt ook te wijzen op iets vreemds.\r\n\r\nBooth werpt zich onmiddellijk op het lichaam, maar jij loopt er snel achteraan, je blik al gefocust op de details. Terwijl je dichterbij komt, begin je de eerste aanwijzingen te verwerken. \"De kleding is modern, maar lijkt gescheurd. De positie van het lichaam suggereert dat het niet per ongeluk is neergelegd—het lijkt opzet,\" zeg je terwijl je naar het lichaam kijkt. Je ogen scannen de omgeving verder. \"Het bloed is vers, maar niet voldoende om het tijdstip van de dood te bepalen. We hebben het over een moord, geen ongeluk.\"\r\n\r\nBooth, die het lichaam nu inspecteert, kijkt op naar je. \"Ja, dat heb ik ook al opgemerkt. Maar we moeten weten wie dit is.\"\r\n\r\nMet een geconcentreerde blik begint Booth het lichaam verder te onderzoeken, terwijl jij in stilte verder kijkt, je gedachten al samenvallend tot een logische conclusie. \"Er is geen enkele reden waarom een archeoloog hier zou worden achtergelaten, tussen de mummies,\" mumel je, maar Booth kijkt je aan en zegt: \"We hebben een moord, Brennan. Laten we de identiteit achterhalen.\" ");
    Console.WriteLine("Je hebt " + partnerchoice1 + " gekozen om je te helpen bij het onderzoek.");
    // Console.ReadKey(); //for debug reden 

    List<string> opties = new List<string>
    {
        "Kijk naar het lichaam en vind kenmerken om het slachtoffer te identificeren.",
        "Onderzoek de omgeving en vind aanwijzingen over de moord.",
        "Bestuur de andere mummies misschien omdat het leuk is. Maar ook om te kijken of er iets verdachts is. Vooral omdat je een beetje afgeleid bent...",
        "Praat met Booth"
    };

    List<string> gevondenClues = new List<string>();

    while (opties.Count > 0) // Blijft doorgaan totdat list leeg is
    {
        Console.Clear();
        Console.WriteLine("Wat wil je doen?");

        for (int i = 0; i < opties.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {opties[i]}");
        }

        Console.Write("Maak een keuze: ");
        if (int.TryParse(Console.ReadLine(), out int keuze) && keuze > 0 && keuze <= opties.Count)
        {
            string gekozenOptie = opties[keuze - 1];
            opties.RemoveAt(keuze - 1); // Verwijder de gekozen optie

            Console.WriteLine($"\nJe hebt gekozen voor: {gekozenOptie}");

            // Simuleer het vinden van een aanwijzing of niet
            if (gekozenOptie == "Kijk naar het lichaam en vind kenmerken om het slachtoffer te identificeren.")
            {
                gevondenClues.Add("Aanwijzing: Het slachtoffer heeft een tatoeage van een draak op zijn arm.");
                Console.WriteLine("Je hebt een belangrijke aanwijzing gevonden: Het slachtoffer heeft een tatoeage van een draak op zijn arm.");
                // Variabele om bij te houden of de clue gevonden is
                Console.WriteLine("\nBrennan knielt bij het lichaam en begint direct te observeren, terwijl Booth met zijn gebruikelijke ongeduld toekijkt.");

                Console.WriteLine("\n\"Het slachtoffer draagt een net pak, maar er zitten lichte stofdeeltjes op. Dit wijst op contact met een vitrine of een oud voorwerp. Mogelijk een artefact.\"");

                Console.WriteLine("\nZe pakt voorzichtig een van de handen op en bekijkt de nagels.");
                Console.WriteLine("\"Er zijn sporen van een oud zand- of kleiachtig materiaal onder de nagels. Dit is consistent met archeologische vondsten. Het suggereert dat hij recent een artefact heeft vastgehouden.\"");

                Console.WriteLine("\nHaar blik verschuift naar het gezicht van het slachtoffer.");
                Console.WriteLine("\"De lippen hebben een blauwe tint. Cyanose... Dit kan wijzen op vergiftiging. We moeten een tox-screen laten uitvoeren.\"");

                Console.WriteLine("\nZe tikt even met haar handschoen op een plek op het hoofd.");
                Console.WriteLine("\"Er is een lichte hoofdwond. Niet dodelijk, maar het kan duiden op een gevecht of een val. Dit is mogelijk niet de doodsoorzaak, maar het moet worden onderzocht.\"");

                Console.WriteLine("\nDan laat ze haar ogen langs de pols glijden en knikt.");
                Console.WriteLine("\"Hier, zie je dit? Een ingedrukte plek waar normaal een horloge zou zitten. Maar het horloge is verdwenen. Als dit een waardevol object was, kan diefstal een motief zijn.\"");

                Console.WriteLine("\nBrennan rolt de mouw van het slachtoffer iets omhoog en merkt iets op.");
                Console.WriteLine("\"Hmm... Interessant. Hier op de onderarm is een tatoeage van een draak. Gedetailleerd, niet recent. Mogelijk een symbool, een lidmaatschap...\"");
                Console.WriteLine("\"Booth, dit zou nuttig kunnen zijn bij de ondervraging. Iemand kent deze draak misschien.\"");

                // Markeer de clue als gevonden
                clueDraakArm = true;
6
                Console.WriteLine("\nBooth zucht. \"Dus we hebben een vergiftiging, een gevecht of val, een ontbrekend horloge, en nu ook een mysterieuze draak-tatoeage. Wat wil je nu doen, Bones?\"");

            }
            else if (gekozenOptie == "Onderzoek de omgeving en vind aanwijzingen over de moord.")
            {
                gevondenClues.Add("Aanwijzing: Er ligt een bloedig mes onder een vitrine.");
                Console.WriteLine("Je hebt een belangrijke aanwijzing gevonden: Er ligt een bloedig mes onder een vitrine.");
            }
            else if (gekozenOptie == "Bestuur de andere mummies misschien omdat het leuk is. Maar ook om te kijken of er iets verdachts is. Vooral omdat je een beetje afgeleid bent...")
            {
                Console.WriteLine("Je hebt niets verdachts gevonden bij de andere mummies.");
            }
            else if (gekozenOptie == "Praat met Booth")
            {
                Console.WriteLine("Booth vertelt je dat hij een verdachte heeft gezien die het museum verliet.");
                // exits console after waiting for key press
                Console.ReadKey();
                //Scene2();
                Console.ReadKey();
                Environment.Exit(0); // Exit the program
                
            }

            Console.WriteLine("\nDruk op Enter om verder te gaan...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
        }
    }

    // Als de speler ALLE onderzoeken heeft voltooid, wordt Booth automatisch gebeld.
    //laat dit niet zien als optie kiest met booth spreken want dat gaat automatisch door naar de volgende scene
    Console.WriteLine("\nJe hebt alle onderzoeken gedaan. Tijd om Booth te bellen.");
    //Scene2();
    Console.ReadKey();
}
    }
}
