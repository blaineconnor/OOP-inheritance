public class StajyerPersonel : IPersonel
{
    #region Özellikler
    public double SaatlikUcret { get; private set; }
    public int CalismaSaati { get; private set; }
    #endregion
    
    #region constructor
    public StajyerPersonel(int sicilNo, string ad, string soyad, double saatlikUcret, int calismaSaati): base(sicilNo, ad, soyad)
    {
        SaatlikUcret = saatlikUcret;
        CalismaSaati = calismaSaati;
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
   
        return Math.Round(SaatlikUcret * CalismaSaati, 2);
    }
    #endregion
}
