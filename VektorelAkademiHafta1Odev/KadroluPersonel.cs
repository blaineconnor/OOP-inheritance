public class KadroluPersonel : IPersonel
{
    #region Fields
    public double AylikUcret { get; private set; }
    public int RaporGunSayisi { get; private set; }
    public int Max_Rapor_Gün_Sayısı { get; private set; }
    #endregion

    #region constructor
    public KadroluPersonel(int sicilNo, string ad, string soyad, double aylikUcret, int raporGunSayisi):base(sicilNo, ad, soyad)
    {
        AylikUcret = aylikUcret;
        RaporGunSayisi = raporGunSayisi;

    }
    #endregion

    #region Ortak metotların uygulanması
    public override string AdSoyadGetir()
    {
        return base.AdSoyadGetir();
    }
    #endregion

    #region Rapor gün sayısına göre aylık ücreti hesabı
    public override double AylikHesapla()
    {
        Max_Rapor_Gün_Sayısı = 5;
        
        if (RaporGunSayisi <= Max_Rapor_Gün_Sayısı)
        {
            return AylikUcret;
        }
        else
        {

            double kesintiMiktari = Math.Round((AylikUcret / 30) * (RaporGunSayisi - Max_Rapor_Gün_Sayısı), 2); //ondalık kısım iki sayıyla sınırlandırıldı
            return AylikUcret - kesintiMiktari; 
        }
    }
    #endregion
}
