namespace EOKeksi
{
    internal class Misfortune
    {
        public string TextFin { get; set; }
        public string TextChinese { get; set; }

        readonly List<string> MisfortunesFin = new()
        {"Soittamalla Metallican kill em all -levyä keskellä yötä saa naapurisi tuomaan sinulle epäonnea aamulla.",
            "Pelaamasi rivit lottoa johtavat rahan menetykseen.",
            "Kissanruoka loppuu, josta suuttuneena kissa raapii pilalle lempi tapettisi",
        "Olet vuosia tervehtinyt Naapuriasi nimellä Pasi. Tänään sinulle selviää, että Pasin oikea nimi onkin Sami.",
        "Astut legoon olohuoneessa. Omituiseksi asian tekee se ettei sinulla ole lapsia ja viimeksi olet leikkinyt tai omistanut legoja kymmeniä vuosia sitten. Et saa tätä asiaa mielestäsi viikkoihin.",
         "Ostat väärää ketsuppia. Jälleen kerran! Vaimosi syö vain Heinz-ketsuppia ei Feliz. Vaimosi mököttää seuraavan päivän."
        };

        readonly List<string> MisfortunesChinese = new()
        { "半夜玩Metallica的全杀会让你的邻居早上给你带来厄运.",
            "玩排乐透会导致金钱损失",
            "由于猫粮用完了，猫会抓你最喜欢的壁纸",
            "多年来，您一直以 Pasi 称呼您的邻居。今天你会发现帕西的真名是萨米",
            "你走进客厅里的乐高积木。奇怪的是，你没有孩子，上一次玩或拥有乐高积木是几十年前的事了。你不会在几周内忘记这件事",
            "你买错了番茄酱。再次！你的妻子只吃亨氏番茄酱，不吃菲利斯。你的妻子第二天会留下来"
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
