namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }
        //public string TextChinese { get; set; }

        readonly List<string> MisfortunesFinPart1 = new()
        {
        "Tapaat värittömän ", "Kohtaat mysteerisen ", "Ymmärrät ", "Näet unessa ", "Tunnet kosmisen "
        };
        readonly List<string> MisfortunesFinPart2 = new()
        {
         "henkilön ", "kuusi sorminen lapsen ", "varjon pimeässä ", "paaviksi pukeutuneen nuoren naisen"
        };
        readonly List<string> MisfortunesFinPart3 = new()
        {
         " joka kuiskaa ", " jonka tatuointi alaselässä kertoo ", "joka ojentaa sinulle "
        };
        readonly List<string> MisfortunesFinPart4 = new()
        {
            "totuuden ", "valheen ", "tärkeän tiedon ", "epämääräistä tekstiä", "haalistuneen lottotositteen vuosien takaa "
        };
        readonly List<string> MisfortunesFinPart5 = new()
        {
            ", älä unohda sitä.", ", kirjoita se postikorttiin jonka lähetät etäiselle sukulaisellesi.", ", se ohjaa sinua matkallasi.", ", olet nyt varma ettemme ole yksin universumissa"
        };
        readonly List<string> MisfortunesChineseP1 = new()
        { 
            "fdlkslkfdlk"
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

            //string ChineseMisFortune = MisfortunesChinese[RandomNumber];
            this.TextFin = FinMisFortune + FinMisFortune2 + FinMisFortune3 + FinMisFortune4 + FinMisFortune5;
            //this.TextChinese = ChineseMisFortune;
            return;
        }
    }
}
