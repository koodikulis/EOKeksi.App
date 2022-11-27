namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }
        //public string TextChinese { get; set; }

        readonly List<string> MisfortunesFinPart1 = new()
        {
        "Kohtaat värittömän ", "Kohtaat mysteerisen ", "Kohtaat vesimelooneilta haisevan ", "Ymmärrät ", "Näet unessa ", "Tunnet kosmisen, ", "Ennustajan hämärässä huoneessa tunnet ", "Haistat ", "Eksyneenä metsään kohtaat ", "Marjastamassa kohtaat "
        };
        readonly List<string> MisfortunesFinPart2 = new()
        {
         "henkilön ", "kuusi sorminen lapsen ", "varjon pimeässä ", "paaviksi pukeutuneen nuoren naisen ", "puolison menneestä elämästäsi ", "lapsesi tulevaisuudesta ", "haisevan alkoholistin, jonka housuihin on ommeltu nimikirjaimet JFK ", "eksyneen marjastajan", 
            "kauan sitten kuolleen tunnnetun jazz-muusikon "
        };
        readonly List<string> MisfortunesFinPart3 = new()
        {
         "joka kuiskaa paikan josta löydät ", "jonka tatuointi alaselässä kertoo sijainnnin josta löydät ", "joka ojentaa sinulle ", "joka myöhemmin lähettää kirjeen kotiisi joka sisältää ", "ottaa taskustaan pienen tuntemattoman instrumentit jolla soittaa "
        };
        readonly List<string> MisfortunesFinPart4 = new()
        {
            "totuuden ", "valheen ", "tärkeän tiedon ", "epämääräistä tekstiä", "haalistuneen lottotositteen vuosien takaa, jonka taakse on lyijykynällä piirretty kuva kissasta ", "lyhyen mutta kauniin melodian "
        };
        readonly List<string> MisfortunesFinPart5 = new()
        {
            ", älä unohda sitä.", ", kirjoita se postikorttiin jonka lähetät etäiselle sukulaisellesi.", ", se ohjaa sinua matkallasi.", ", olet nyt varma ettemme ole yksin universumissa.", "syystä jota et ymmärrä vietät seuraavan viikon itkien sängyssäsi.",
            "muista se kun sinulta kysytään viimeisiä sanojasi.", "tämä tietoo saattaa sinut pelastaa.", ", jos eksyt unessasi metsään vain tämä tieto saattaa johdattaa sinut sieltä pois.", "kuiskaa se lapsenlapsesi korvaan vuosien päästä."
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
