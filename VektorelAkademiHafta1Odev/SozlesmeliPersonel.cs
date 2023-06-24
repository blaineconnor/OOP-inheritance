public class SozlesmeliPersonel : IPersonel
{
    #region özellikler
    public double GunlukUcret { get; private set; }
    public int CalismaGunSayisi { get; private set; }
    #endregion
    
    # region constructor
    public SozlesmeliPersonel(int sicilNo, string ad, string soyad, double gunlukUcret, int calismaGunSayisi) : base(sicilNo, ad, soyad)
    {
        GunlukUcret = gunlukUcret;
        CalismaGunSayisi = calismaGunSayisi;
    }
    #endregion

    #region Ortak metotların uygulanması
    public override string AdSoyadGetir()
    {
        return base.AdSoyadGetir();
    }
    #endregion

    #region Aylık ücreti hesaplayan metot
    public override double AylikHesapla()
    {
        return Math.Round(GunlukUcret * CalismaGunSayisi, 2);
    }
    #endregion
}
