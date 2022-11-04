namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }
        public string TextChinese { get; set; }

        List<string> MisfortunesFin = new List<string>() {"Soittamalla Metallican kill em all -levyä keskellä yötä saa naapurisi tuomaan sinulle epäonnea aamulla.", "Pelaamasi rivit lottoa johtavat rahan menetykseen." };
        List<string> MisfortunesChinese = new List<string>() { "半夜玩Metallica的全杀会让你的邻居早上给你带来厄运.", "玩排乐透会导致金钱损失" };

        public void GetMisfortune()
        {
            Random rnd = new();
            int RandomNumber = rnd.Next(MisfortunesFin.Count);
            string FinMisFortune = MisfortunesFin[RandomNumber];
            string ChineseMisFortune = MisfortunesChinese[RandomNumber];
            this.TextFin = FinMisFortune;
            this.TextChinese = ChineseMisFortune;
            return ;
        }
    }
}
