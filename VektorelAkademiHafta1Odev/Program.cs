class Program
{
    static void Main(string[] args)
    {
        #region Kadrolu Personel
        IPersonel kadroluPersonel0 = new KadroluPersonel(1, "Fatih Emre", "Sarman", 30000, 10);

        Console.WriteLine("Kadrolu Personel: " + kadroluPersonel0.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + kadroluPersonel0.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");

        IPersonel kadroluPersonel1 = new KadroluPersonel(2, "Fikri", "Yıldız", 30000, 6);
        Console.WriteLine("Kadrolu Personel: " + kadroluPersonel1.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + kadroluPersonel1.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");

        IPersonel kadroluPersonel2 = new KadroluPersonel(3, "Resul", "Coşkun", 30000, 5);
        Console.WriteLine("Kadrolu Personel: " + kadroluPersonel2.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + kadroluPersonel2.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");
        #endregion

        #region Sözleşmeli Personel
        IPersonel sozlesmeliPersonel0 = new SozlesmeliPersonel(4, "Yunus Emre", "Yıldız", 380.08, 30);
        Console.WriteLine("Sözleşmeli Personel: " + sozlesmeliPersonel0.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + sozlesmeliPersonel0.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");

        IPersonel sozlesmeliPersonel1 = new SozlesmeliPersonel(5, "Berk Can", "Akkoç", 380.08, 25);
        Console.WriteLine("Sözleşmeli Personel: " + sozlesmeliPersonel1.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + sozlesmeliPersonel1.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");

        IPersonel sozlesmeliPersonel2 = new SozlesmeliPersonel(6, "Ayhan", "Buldu", 380.08, 20);
        Console.WriteLine("Sözleşmeli Personel: " + sozlesmeliPersonel2.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + sozlesmeliPersonel2.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");
        #endregion

        #region Stajyer Personel
        IPersonel stajyerPersonel0 = new StajyerPersonel(7, "Mustafa", "Arslan", 50.67, 80);

        Console.WriteLine("Stajyer Personel: " + stajyerPersonel0.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + stajyerPersonel0.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");

        IPersonel stajyerPersonel1 = new StajyerPersonel(8, "Bekir", "Yılmazer", 50.67, 86);
        Console.WriteLine("Stajyer Personel: " + stajyerPersonel1.AdSoyadGetir());
        Console.WriteLine("Aylık Ücret: " + stajyerPersonel1.AylikHesapla());
        Console.WriteLine("");
        Console.WriteLine("");
        #endregion
    }
}