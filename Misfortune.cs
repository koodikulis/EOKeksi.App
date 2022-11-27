namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }


        //TODO: transfer text to .txt file and read with List<string> allLinesText = File.ReadAllLines(fileName).ToList()


        readonly List<string> MisfortunesFinPart1 = new()
        {
        "Kohtaat värittömän ", "Kohtaat mysteerisen ", "Kohtaat vesimelooneilta tuoksuvan ", "Ymmärrät ", "Näet unessa ", "Tunnet kosmisen, ", "Ennustajan hämärässä huoneessa tunnet ", "Haistat ", "Eksyneenä metsään kohtaat ", "Sienestämässä kohtaat ", "Synkimmän painajaisesi keskellä kohtaat ", "Kaivon pohjalla näet ", "Virittämättömän televisiokuvan kohinassa näet ",
        "Ostoskeskuksen vessassa vaihdat lyhyen katseen ", "Vanhassa saunamökissä järven rannalla ", "Sumuisen järven veden pinnassa näet "
        };
        readonly List<string> MisfortunesFinPart2 = new()
        {
         "henkilön ", "kuusi sormisen lapsen ", "varjon pimeässä ", "paaviksi pukeutuneen nuoren naisen ", "puolison menneestä elämästäsi ", "lapsesi toisesta elämästä ", "epätavallisen hyvältä haisevan alkoholistin, jonka housuihin on ommeltu nimikirjaimet JFK ",
            "eksyneen marjastajan ", 
            "kauan sitten kuolleen tunnnetun jazz-muusikon ", "riikinkukon ", "palomiehen ", "vieraan miehen ", "lastenhoitajasi lapsuudesta ", "isovanhempasi nuorena ", "pahaa energiaa säteilevän kassaneidin ", "olennon joka loistaa tuntemattomissa väreissä joita ei esiinny luonnossa maapallolla ", "amerikkailaisen vapaa-painijan ", "pienen sinisen olennon ",
            "valkoisen lampaan jonka otsaan on kaiverrettu epämiellyttävä kuvio ", "leimasinta pitelevä mieheltä näyttävä hahmo "
        };
        readonly List<string> MisfortunesFinPart3 = new()
        {
         "joka kuiskaa paikan josta löydät ", "jonka tatuointi alaselässä kertoo sijainnnin josta löydät ", "joka ojentaa sinulle ", "joka myöhemmin lähettää kirjeen kotiisi joka sisältää ", "joka ottaa taskustaan pienen tuntemattoman instrumentin jolla soittaa ", "joka pitelee pesäpallomailaa johon tiedät että on kaiverrettu ",
            "joka kohisee kuin epäviritetty radio. Kuuntelet tarkkaan ja erotat kohinasta  "
        };
        readonly List<string> MisfortunesFinPart4 = new()
        {
            "totuuden ", "valheen ", "tärkeän tiedon ", "epämääräistä tekstiä ", "haalistuneen lottotositteen vuosien takaa, jonka taakse on lyijykynällä piirretty kuva kissasta ", "lyhyen mutta kauniin melodian "
        };
        readonly List<string> MisfortunesFinPart5 = new()
        {
            ", älä unohda sitä.", ", tallenna se postikorttiin jonka lähetät etäiselle sukulaisellesi.", ", se ohjatkoon sinua matkallasi.", ", olet nyt varma ettemme ole yksin universumissa.", ", et ymmärrä miksi vietät seuraavan viikon onnellisena sängyssäsi.",
            ", muista se kun sinulta kysytään viimeisiä sanojasi.", ", tämä tietoo saattaa sinut pelastaa.", ", jos eksyt unessasi metsään vain tämä saattaa johdattaa sinut sieltä pois.", ", kuiskaa se läheisesi korvaan vuosien päästä."
        };


        public void GetMisfortune()
        {
            Random rnd = new();

            int RandomNumber = rnd.Next(MisfortunesFinPart1.Count);
            string FinMisFortune = MisfortunesFinPart1[RandomNumber];

            int RandomNumber2 = rnd.Next(MisfortunesFinPart2.Count);
            string FinMisFortune2 = MisfortunesFinPart2[RandomNumber2];

            int RandomNumber3 = rnd.Next(MisfortunesFinPart3.Count);
            string FinMisFortune3 = MisfortunesFinPart3[RandomNumber3];

            int RandomNumber4 = rnd.Next(MisfortunesFinPart4.Count);
            string FinMisFortune4 = MisfortunesFinPart4[RandomNumber4];

            int RandomNumber5 = rnd.Next(MisfortunesFinPart5.Count);
            string FinMisFortune5 = MisfortunesFinPart5[RandomNumber5];

           
            this.TextFin = FinMisFortune + FinMisFortune2 + FinMisFortune3 + FinMisFortune4 + FinMisFortune5;
            
            return;
        }
    }
}
