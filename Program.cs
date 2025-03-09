// Code: Text Adventure Game

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start de game
            Game game = new Game();
            game.Start();
            Environment.Exit(0);
        }
    }

    class Game
    {
        private List<string> inventory = new List<string>(); // Dit is je inventory
        private List<string> notepad = new List<string>();  // Dit is je in-game notepad
        private List<string> gevondenClues = new List<string>(); // Dit zijn de gevonden aanwijzingen
        private bool clueDraakArm = false;
        private bool bloedigMes = false;
        private string partnerchoice1 = "";
        private bool Angela = false;
        private bool Jack = false;
        private bool Cam = false;
        private bool Zack = false;
        private string partner = "";

        public void Start()
        {
            // Begin bij de eerste scène
            Scene0();
            return;
        }

        private void Scene0()
        {
            Console.WriteLine("Welcome to this text adventure game!");
            Console.WriteLine("This story will be about a murder and You are Doctor Temprance Brennan and together with your friend and FBI agent Booth you will solve a murder!");
            Console.WriteLine("We recommend to use get a notepad and write your findings. But we will also give all the clues on a notepad for you in this console!!!");
            Console.WriteLine("Let's Start!");
            Console.ReadKey();
            Scene1();
            return;
        }

        private void Scene1() //partner kiezen
        {
            Console.Clear();
            Console.WriteLine("Je bevindt je in het Jeffersonian Institute, omringd door de geur van oud bot en conserveringsmiddelen. Het geluid van skeletten die tegen elkaar tikken bij het verplaatsen vult de ruimte. Agent Seeley Booth staat naast je, zijn gezicht strak. Hij vouwt zijn armen over elkaar en knikt richting een tafel bedekt met botten.\r\n\r\n\"We hebben een probleem,\" zegt hij met een zucht. \"Dr. Ethan White, een archeoloog, werd dood aangetroffen… hier, tussen de andere skeletten in het lab. Alsof hij er gewoon bij hoorde.\"\r\n\r\nHij wijst naar een gedeeltelijk gereconstrueerd skelet, zorgvuldig uitgestald, maar de botten zijn niet allemaal even oud. Tussen de eeuwenoude resten ligt iets nieuwer—te nieuw.\r\n\r\n\"Dit is geen opgraving. Dit is een moord.\"");
            Console.WriteLine("Wie neem je mee?");
            Console.WriteLine("1. Angela Montenegro - Expert in reconstructies en visualisaties.");
            Console.WriteLine("2. Dr. Jack Hodgins - Specialist in sporenonderzoek en entomologie.");
            Console.WriteLine("3. Dr. Camille 'Cam' Saroyan - Forensisch patholoog en hoofd van het lab.");
            Console.WriteLine("4. Dr. Zack Addy - Briljante maar sociaal ongemakkelijke forensisch antropoloog.");
            Console.Write("Maak een keuze: ");

            var choice = Console.ReadLine();

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
            Console.WriteLine("Press any key to continue...");        
            Console.ReadKey();        
            Scene1b();
            return;
        }
     
private void Scene1b() { // Plaats delict onderzoeken en aanwijzingen vinden
    bool vitrinePlek = false;
    
    Console.Clear();
    Console.WriteLine("Je zit in de auto met Booth en " + partnerchoice1 + ". Je stapt de SUV uit, de koude lucht bijt in je huid.");
    Console.WriteLine("Het Smithsonian National Museum of Natural History ligt voor je, zijn grote glazen gevel verlicht door de straatlantaarns, terwijl je voetstappen echoën op de marmeren trappen.");
    Console.WriteLine("Booth loopt snel naar de ingang, maar jij, als altijd, kan het niet helpen je gedachten te laten afdwalen naar de puzzel voor je.");
    Console.WriteLine("Het museum is stil, de sfeer zwaar van oude geschiedenis en wetenschap. De deuren schuiven open en je stapt de ruimte binnen, je ogen al zoekend naar de details—de barst in de vloer, de geuren van stof en oud papier. De ruimte is leeg, de hal immens.");
    Console.WriteLine("Booth werpt je een korte blik, maar het duurt niet lang voor je al je gedachten op de zaak richt. \"Het lichaam moet hier ergens zijn,\" zegt hij, maar je hebt je aandacht al verlegd naar de vitrines langs de muren.");
    Console.WriteLine("\"De temperatuur hier is laag, te laag voor een normale tentoonstelling,\" zeg je, je stem bijna zoals altijd analytisch. \"En de luchtvochtigheid... te hoog voor behoud van de mummies, dit zou de vervalprocessen versnellen. Wat moeten ze verborgen houden?\"");
    Console.WriteLine("Booth kijkt even op, maar haalt zijn schouders op. \"Je hebt gelijk, maar ik ben meer geïnteresseerd in het lichaam.\"");
    Console.WriteLine("Dat is wanneer je de figuur op de vloer ziet liggen. In het midden van de zaal ligt het lichaam van een onbekende man, het ligt op een vreemde, onnatuurlijke manier. De omgeving lijkt ook te wijzen op iets vreemds.");
    Console.WriteLine("Booth werpt zich onmiddellijk op het lichaam, maar jij loopt er snel achteraan, je blik al gefocust op de details. Terwijl je dichterbij komt, begin je de eerste aanwijzingen te verwerken.");
    Console.WriteLine("\"De kleding is modern, maar lijkt gescheurd. De positie van het lichaam suggereert dat het niet per ongeluk is neergelegd—het lijkt opzet,\" zeg je terwijl je naar het lichaam kijkt. Je ogen scannen de omgeving verder.");
    Console.WriteLine("\"Het bloed is vers, maar niet voldoende om het tijdstip van de dood te bepalen. We hebben het over een moord, geen ongeluk.\"");
    Console.WriteLine("Booth, die het lichaam nu inspecteert, kijkt op naar je. \"Ja, dat heb ik ook al opgemerkt. Maar we moeten weten wie dit is.\"");
    Console.WriteLine("Met een geconcentreerde blik begint Booth het lichaam verder te onderzoeken, terwijl jij in stilte verder kijkt, je gedachten al samenvallend tot een logische conclusie.");
    Console.WriteLine("\"Er is geen enkele reden waarom een archeoloog hier zou worden achtergelaten, tussen de mummies,\" mumel je, maar Booth kijkt je aan en zegt: \"We hebben een moord, Brennan. Laten we de identiteit achterhalen.\"");

    Console.ReadKey();

    List<string> opties = new List<string>
    {
        "Kijk naar het lichaam en vind kenmerken om het slachtoffer te identificeren.",
        "Gebruik UV-licht om sporen van bloed of andere vloeistoffen te vinden.",
        "Bel het lab om vragen te stellen over iets dat je gevonden hebt.",
        "Bestuur de andere mummies misschien omdat het leuk is. Maar ook om te kijken of er iets verdachts is. Vooral omdat je een beetje afgeleid bent...",
        "Praat met Booth"
    };



    while (opties.Count > 0) // Blijft doorgaan totdat list leeg is
    {
        Console.Clear();
        Console.WriteLine("Wat wil je doen?");

        for (int i = 0; i < opties.Count; i++)
        {
            if (bloedigMes == false && opties[i] == "Bel het lab om vragen te stellen over iets dat je gevonden hebt.")
            {
                Console.WriteLine($"{i + 1}. {opties[i]} [Locked]");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {opties[i]}");
            }
        }

        Console.Write("Maak een keuze: ");
        if (int.TryParse(Console.ReadLine(), out int keuze) && keuze > 0 && keuze <= opties.Count)
        {  
            Console.Clear();
            string gekozenOptie = opties[keuze - 1];

            Console.WriteLine($"\nJe hebt gekozen voor: {gekozenOptie}");

            // Simuleer het vinden van een aanwijzing of niet
         if (bloedigMes == false && gekozenOptie == "Bel het lab om vragen te stellen over iets dat je gevonden hebt.")
            {
                Console.WriteLine("Deze optie is vergrendeld. Kies een andere optie.");
            Console.WriteLine("Press any key to continue...");        
            Console.ReadKey();
                continue;
            }
    else if (gekozenOptie == "Kijk naar het lichaam en vind kenmerken om het slachtoffer te identificeren.") // Done 
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

                Console.WriteLine("\nBooth zucht. \"Dus we hebben een vergiftiging, een gevecht of val, een ontbrekend horloge, en nu ook een mysterieuze draak-tatoeage. Wat wil je nu doen, Bones?\"");
                opties.Remove(gekozenOptie);
                Console.WriteLine("Press any key to continue...");        
                Console.ReadKey();

            }
    else if (gekozenOptie == "Gebruik UV-licht om sporen van bloed of andere vloeistoffen te vinden.")
            {
                gevondenClues.Add("Aanwijzing: Er zijn sporen van bloed op de vloer die leiden naar een vitrine.");
                Console.WriteLine("Je hebt een belangrijke aanwijzing gevonden: Er zijn sporen van bloed op de vloer die leiden naar een vitrine.");
                Console.WriteLine("\nJe pakt je UV-licht en schijnt het over de vloer. De paarse gloed onthult sporen van bloed die leiden naar een vitrine aan de andere kant van de kamer waar de mummies worden tentoongesteld.");
                vitrinePlek = true;
                opties.Remove(gekozenOptie);
            Console.WriteLine("Press any key to continue...");        
            Console.ReadKey();
            }
    else if (gekozenOptie == "Bestuur de andere mummies misschien omdat het leuk is. Maar ook om te kijken of er iets verdachts is. Vooral omdat je een beetje afgeleid bent...")
            {
                Console.WriteLine("Je loopt naar de andere mummies en begint ze te bestuderen. Ze zijn allemaal zorgvuldig geconserveerd en tentoongesteld, elk met hun eigen verhaal van het verleden.");
                Console.WriteLine("Je leert over de oude beschavingen, de rituelen en de gebruiken die hen definieerden. Het is fascinerend, maar je beseft al snel dat dit niet de tijd is om afgeleid te worden.");
                Console.WriteLine("Je keert je terug naar het lichaam.");
                opties.Remove(gekozenOptie);
            Console.WriteLine("Press any key to continue...");        
            Console.ReadKey();

            }
    else if (bloedigMes && gekozenOptie == "Bel het lab om vragen te stellen over iets dat je gevonden hebt.")
            {   
                string labpartner = "";
                string labpartnerHijZij = "";
                if (partnerchoice1 == "Dr. Camille 'Cam' Saroyan"){
                 labpartner = "Dr. Zack Addy";
                 labpartnerHijZij = "Hij";
                }
                else if (partnerchoice1 == "Dr. Zack Addy"){
                 labpartner = "Dr. Camille 'Cam' Saroyan";
                 labpartnerHijZij = "Zij";
                }
                Console.WriteLine("Je pakt je telefoon en belt het lab.");
            Console.WriteLine(labpartner + " neemt op en je legt uit wat je hebt gevonden.");
            Console.WriteLine(labpartnerHijZij+" zegt dat ze het mes zal onderzoeken op vingerafdrukken en andere sporen zodra ze bij het lab aankomen.");
            Console.WriteLine(labpartnerHijZij+" zal je laten weten zodra ze meer informatie heeft.");
            opties.Remove(gekozenOptie);
            Console.WriteLine("Press any key to continue...");        
            Console.ReadKey();

        }  

    else if(vitrinePlek && gekozenOptie == "Kijk rond de vitrine om te zien waar de bloedsporen naartoe leiden.")
    {
        
        gevondenClues.Add("Aanwijzing: Er ligt een bloedig mes onder een vitrine.");
        Console.WriteLine("Je kijkt rond en ziet de vitrine waar de bloedsporen naartoe leiden. Je loopt ernaartoe en ziet iets onder de vitrine liggen.");
        Console.WriteLine("Je bukt en pakt het op. Het is een bloedig mes, scherp en gevaarlijk. Er zitten geen vingerafdrukken op.");
        Console.WriteLine("Wel zit er een vreemd symbool op het handvat.");
        Console.WriteLine("Je bewaart het mes voor verder onderzoek.");
        bloedigMes = true;
        vitrinePlek = false;
        opties.Remove(gekozenOptie);
        Console.WriteLine("Press any key to continue...");        
        Console.ReadKey();

    }
        
    else if (gekozenOptie == "Praat met Booth"){
        Console.WriteLine("Je belt Booth op en vraagt of hij al iets heeft gevonden.");
        Console.WriteLine("Booth zegt dat hij de verdachtes heeft gevonden en wacht op jouw om samen in FBI HQ ze te ondervragen.");
        Console.WriteLine("Je zegt dat je samen met " + partnerchoice1 +  "er aan komt en hangt op.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Scene2();
        return;
        // Environment.Exit(0);
    }
        if (opties.Count == 1) // Alleen de optie "Praat met Booth" is over //Dus automatisch Booth bellen
    {
        Console.Clear();
        Console.WriteLine("\nJe hebt alle onderzoeken gedaan. Tijd om Booth te bellen.");
        Console.WriteLine("Je belt Booth op en vraagt of hij al iets heeft gevonden.");
        Console.WriteLine("Booth zegt dat hij de verdachtes heeft gevonden en wacht op jouw om samen in FBI HQ ze te ondervragen.");
        Console.WriteLine("Je zegt dat je samen met " + partnerchoice1 +  "er aan komt en hangt op.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Scene2();
        // Environment.Exit(0);
        return;
    }  
        if (vitrinePlek && !opties.Contains("Kijk rond de vitrine om te zien waar de bloedsporen naartoe leiden.")){
            opties.Add("Kijk rond de vitrine om te zien waar de bloedsporen naartoe leiden.");
        }
        }

    else
    {
        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
        Console.WriteLine("Press any key to continue...");        
        Console.ReadKey();

        }



        

    // Als de speler ALLE onderzoeken heeft voltooid, wordt Booth automatisch gebeld.
    //laat dit niet zien als optie kiest met booth spreken want dat gaat automatisch door naar de volgende scene
 
    }
}

    private static void Scene2()
    {
        Console.Clear();
        Console.WriteLine("Je stapt de FBI HQ binnen, de geur van koffie en papier vult de lucht. Booth wacht op je bij de ingang, zijn blik ernstig.");
        Console.WriteLine("Hij knikt naar je en leidt je naar een van de verhoorkamers, waar de verdachten al zitten te wachten.");
    Console.WriteLine("\"Booth: Oké, Bones, laten we een weddenschap doen. Als deze verdachte binnen de eerste vijf minuten ‘Ik zweer het, ik heb niets gedaan’ zegt, koop jij koffie. Als hij huilt, koop ik koffie.");  
    Console.WriteLine("\"Brennan: Statistisch gezien vertonen verdachten in 73% van de gevallen verdedigend gedrag binnen de eerste minuut, dus je weddenschap is nogal bevooroordeeld.\"");  
    Console.WriteLine("\"Booth: Precies. Dus… ik wil een grote met extra suiker.\"");
    Console.WriteLine("Jullie arriveren bij de verhoorkamers en Booth zegt: Oke Bones  we hebben 9 verdachtes en getuigen die we moeten ondervragen. Wie wil je als eerste ondervragen?");

     List<string> personen = new List<string> 
    {
        "Dr. Edward 'Eddie' Langford (Verdachte)",
        "Derek 'The Knife' Thompson (Verdachte)",
        "Professor James 'Prof' Smith (Verdachte)",
        "Jessica 'Jess' Taylor (Getuige)",
        "Stop met ondervragen en bel met het lab om dan uiteindelijk de moordenaar te beschuldigen."	
        
    };

    
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    while(personen.Count > 0)
    {
    Console.WriteLine("Kies een persoon om te ondervragen: ");
    for (int i = 0; i < personen.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {personen[i]}");
    }
    Console.Write("Maak een keuze: ");
   
    if(int.TryParse(Console.ReadLine(), out int keuze) && keuze > 0 && keuze <= personen.Count)
    {
        Console.Clear();
        string gekozenPersoon = personen[keuze - 1];
        Console.WriteLine($"\nJe hebt gekozen voor: {gekozenPersoon}");

        if(gekozenPersoon == "Dr. Edward 'Eddie' Langford (Verdachte)")
        {
            Edward();
            personen.Remove(gekozenPersoon);
        }
        else if(gekozenPersoon == "Derek 'The Knife' Thompson (Verdachte)")
        {
            Derek();
            personen.Remove(gekozenPersoon);
        }
        else if(gekozenPersoon == "Professor James 'Prof' Smith (Verdachte)")
        {
            Prof();
            personen.Remove(gekozenPersoon);
        }
        else if(gekozenPersoon == "Jessica 'Jess' Taylor (Getuige)")
        {
            Jessica();
            personen.Remove(gekozenPersoon);
            
        }
        else if(gekozenPersoon == "Stop met ondervragen en bel met het lab om dan uiteindelijk de moordenaar te beschuldigen." || personen.Count == 1)
        {
            Scene3();
        }
        else
        {
            Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
            Console.ReadKey();
        }

    }
    }

    }

    private static void Edward() {
        Console.WriteLine("Je ondervraagt Dr. Edward 'Eddie' Langford, een archeoloog die in het museum werkte.");
        Console.WriteLine("Hij beweert dat hij die avond niet aanwezig was, maar bewakingsbeelden laten iets anders zien.");
    
        Console.WriteLine("\nEdward: \"Ik was er niet! Ik zweer het!\"");
    
        Console.WriteLine("\nBooth: \"De bewakingsbeelden zeggen iets anders, Edward. Wat deed je daar echt?\"");
    
        Console.WriteLine("\nEdward zucht en kijkt naar de grond.");
        Console.WriteLine("Edward: \"Oké, oké... Ik was er wel. Ik was het museum zelf aan het bestuderen voor een boek dat ik aan het schrijven was.\"");
    
        Console.WriteLine("\nBrennan: \"En waarom loog je daarover?\"");
    
        Console.WriteLine("\nEdward: \"Omdat ik wist dat het er verdacht uit zou zien. Maar ik heb niets met de moord te maken!\"");
    
        Console.WriteLine("\nJe hebt genoeg gehoord. Edward lijkt niet de moordenaar te zijn.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
private static void Derek() {
    Console.WriteLine("Je ondervraagt Derek 'The Knife' Thompson, een bekende kunstsmokkelaar met een verleden in het verkopen van gestolen museumstukken.");
    Console.WriteLine("Zijn bijnaam komt van zijn voorliefde voor messen... en er lag een bloedig mes bij het lichaam.");

    Console.WriteLine("\nDerek: \"Ik heb niets te zeggen.\"");

    Console.WriteLine("\nBooth: \"We weten dat het jouw mes was, Derek. Waarom lag het bij het lichaam?\"");

    Console.WriteLine("\nDerek: \"Ja, het is mijn mes. Maar ik was het niet. Ik heb een alibi.\"");

    Console.WriteLine("\nBrennan: \"En wie zou jouw mes kunnen hebben gestolen?\"");

    Console.WriteLine("\nDerek: \"Alleen iemand uit het museum zou toegang hebben tot mijn mes.\"");

    Console.WriteLine("\nJe hebt genoeg gehoord. Derek lijkt niet de moordenaar te zijn, maar zijn mes werd wel gebruikt.");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}
        private static void Prof() {
            Console.WriteLine("Je ondervraagt Professor James 'Prof' Smith, een expert in oude culturen.");
            Console.WriteLine("Hij lijkt nerveus en vermijdt oogcontact.");
        
            Console.WriteLine("\nProf: \"Ik was in slaap gevallen in mijn kantoor. Ik werd pas wakker toen het alarm afging en het lichaam werd gevonden.\"");
        
            Console.WriteLine("\nBooth: \"Waarom zou iemand je kantoor binnengaan en je niet wakker maken?\"");
        
            Console.WriteLine("\nJe merkt dat de professor een lichte trilling in zijn handen heeft.");
            Console.WriteLine("Brennan: \"Professor, we hebben bewijs gevonden dat het slachtoffer een waardevol artefact vasthield. Kunt u uitleggen waarom er zand- of kleiachtig materiaal onder zijn nagels zat?\"");
        
            Console.WriteLine("\nProf: \"Ik... ik weet het niet. Misschien was hij bezig met een opgraving.\"");
            Console.WriteLine("Booth: \"Of misschien betrapte hij je op het stelen van dat artefact en probeerde je hem het zwijgen op te leggen.\"");
        
            Console.WriteLine("\nDe professor begint te zweten en kijkt nerveus om zich heen.");
            Console.WriteLine("Brennan: \"We hebben ook een mes gevonden met een symbool dat overeenkomt met de tatoeage op de arm van het slachtoffer. Wat kunt u ons daarover vertellen?\"");
        
            Console.WriteLine("\nProf: \"Dat... dat mes is van Derek. Hij heeft een voorliefde voor messen.\"");
            Console.WriteLine("Booth: \"Maar alleen iemand uit het museum zou toegang hebben tot dat mes. En jij had een motief om het slachtoffer te vermoorden.\"");
        
            Console.WriteLine("\nDe professor zucht diep en sluit zijn ogen.");
            Console.WriteLine("Prof: \"Oké, oké... Ik had schulden. Ik wilde het artefact verkopen om mijn schulden af te lossen. Maar hij betrapte me en ik... ik pakte het mes en...\"");
        
            Console.WriteLine("\nJe hebt genoeg gehoord. De professor is de moordenaar.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
                private static void Jessica() {
            Console.WriteLine("Je ondervraagt Jessica 'Jess' Taylor, een jonge onderzoekster die pas net bij het museum werkt.");
            Console.WriteLine("Ze heeft het lichaam gevonden en is in shock.");
        
            Console.WriteLine("\nJessica: \"Ik... ik vond hem daar. Ik wist niet wat ik moest doen.\"");
        
            Console.WriteLine("\nBooth: \"Had je een relatie met het slachtoffer?\"");
        
            Console.WriteLine("\nJessica knikt langzaam.");
            Console.WriteLine("Jessica: \"Ja, we waren samen. Maar ik zou hem nooit iets aandoen!\"");
        
            Console.WriteLine("\nBrennan: \"Wat deed je die avond in het museum?\"");
        
            Console.WriteLine("\nJessica: \"Ik was aan het werk aan een project. Ik hoorde een geluid en ging kijken. Toen vond ik hem.\"");
        
            Console.WriteLine("\nJe hebt genoeg gehoord. Jessica lijkt niet de moordenaar te zijn.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void Scene3() {
            List<string> personen = new List<string>
            {
                "Dr. Edward 'Eddie' Langford",
                "Derek 'The Knife' Thompson",
                "Professor James 'Prof' Smith",
                "Jessica 'Jess' Taylor",
                "Vraag Booth om hulp."
            };
        Console.Clear();

        Console.WriteLine("Je belt het lab en krijgt te horen dat het mes geen vingerafdrukken bevatte, maar wel een vreemd symbool op het handvat. Hetzelfde symbool dat je op de draak-tatoeage hebt gezien.");
        Console.WriteLine("Je kijkt vanuit het raam naar de verdachten en getuigen die je zojuist hebt ondervraagd. Wie is de moordenaar? En dan zie je het opeens...");
        Console.ReadKey();
        Console.Clear();
        while(personen.Count > 0){
            Console.Clear();
            Console.WriteLine("Wie heeft het gedaan?");
            for (int i = 0; i < personen.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {personen[i]}");
            }
            if(int.TryParse(Console.ReadLine(), out int keuze) && keuze > 0 && keuze <= personen.Count)
            {
                Console.Clear();
                string gekozenPersoon = personen[keuze - 1];
                Console.WriteLine($"\nJe hebt gekozen voor: {gekozenPersoon}");
                if(gekozenPersoon == "Dr. Edward 'Eddie' Langford")
                {
                    Console.WriteLine("Booth zegt dat Edward niet de moordenaar is. Je kijkt naar de andere verdachten en getuigen.");
                    personen.Remove(gekozenPersoon);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if(gekozenPersoon == "Derek 'The Knife' Thompson")
                {
                    Console.WriteLine("Booth zegt dat Derek niet de moordenaar is. Je kijkt naar de andere verdachten en getuigen.");
                    personen.Remove(gekozenPersoon);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if(gekozenPersoon == "Professor James 'Prof' Smith")
                {
                    Console.WriteLine("Booth zegt dat de professor schulden had en een motief om een waardevol artefact te verkopen.");
                    Console.WriteLine("Je kijkt naar hem en op zijn nek zie je een deel van het symbool dat je op het mes en de tatoeage hebt gezien.");
                    Console.WriteLine("Hij is het, schreeuw je.");
                    Console.WriteLine("Booth knikt en loopt naar de verhoorkamer om de professor te arresteren.");
                    Console.WriteLine("Booth: \"Goed werk, Bones. We hebben de moordenaar.\"");
                    Console.WriteLine("Je hebt de zaak opgelost. Gefeliciteerd!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Scene4();
                    return;
                }
                else if(gekozenPersoon == "Jessica 'Jess' Taylor")
                {
                    Console.WriteLine("Booth zegt dat Jessica niet de moordenaar is. Je kijkt naar de andere verdachten en getuigen.");
                    personen.Remove(gekozenPersoon);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if(gekozenPersoon == "Vraag Booth om hulp.")
                {
                    Console.WriteLine("Je besluit Booth te vragen om hulp.");
                    Console.WriteLine("Hij merkt op dat de professor schulden had en een motief om een waardevol artefact te verkopen.");
                    Console.WriteLine("Je kijkt naar hem en op zijn nek zie je een deel van het symbool dat je op het mes en de tatoeage hebt gezien.");
                    Console.WriteLine("Hij is het, schreeuw je.");
                    Console.WriteLine("Booth knikt en loopt naar de verhoorkamer om de professor te arresteren.");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Scene4(); // Scene 4: Feliciteren en einde
                    return;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                    Console.ReadKey();
                }
            }
        
            else
            {
                Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                Console.ReadKey();
            }
        }
    }
    
    private static void Scene4() 
    {
        Console.Clear();
        Console.WriteLine("Je hebt de zaak opgelost en de moordenaar gearresteerd. Gefeliciteerd!");
        Console.WriteLine("Jij en Booth gaan samen naar de Bar: The Founding Fathers om te vieren.");
        Console.WriteLine("Je bestelt een glas wijn en Booth bestelt een biertje.");
        Console.WriteLine("Booth: \"Goed werk, Bones. Je hebt het weer voor elkaar gekregen.\"");
        Console.WriteLine("Brennan: \"Je had gelijk over de weddenschap. Ik zal voor je een koffie betalen.\"");
        Console.WriteLine("Booth: \"Wat dacht je van een biertje?\"");
        Console.WriteLine("Jullie lachen samen");
        Console.ReadKey();
        Console.WriteLine("Press any key to continue...");

        Console.Clear();
        Console.WriteLine("Gefeliciteerd speler je hebt de moord opgelost! ");
        Console.WriteLine("Dank je wel voor het spelen van mijn spel!");

        Console.WriteLine("Het is bedacht en gemaakt door mij: Emre Kadir Tiren");
        Console.WriteLine("Press any key to exit the game...");
        Console.ReadKey();
        Environment.Exit(0);
        return;
    }
        }
            }