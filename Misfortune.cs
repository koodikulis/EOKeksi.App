namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }
        public string TextChinese { get; set; }

        readonly List<string> MisfortunesFin = new()
        {
         
        };

        readonly List<string> MisfortunesChinese = new()
        { 
        };

        public void GetMisfortune()
        {
            Random rnd = new();
            int RandomNumber = rnd.Next(MisfortunesFin.Count);
            string FinMisFortune = MisfortunesFin[RandomNumber];
            string ChineseMisFortune = MisfortunesChinese[RandomNumber];
            this.TextFin = FinMisFortune;
            this.TextChinese = ChineseMisFortune;
            return;
        }
    }
}
