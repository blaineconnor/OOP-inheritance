public abstract class IPersonel
{
    #region Ortak özellikler ve metotlar
    private int SicilNo { get; set; }

    private string Ad { get; set; }
    private string Soyad { get; set; }
    public virtual string AdSoyadGetir()
    {
        return $"{Ad} {Soyad}";
    }
    public virtual double AylikHesapla()
    {
        return 0;
    }
    public IPersonel(int sicilno, string ad, string soyad)
    {
        SicilNo = sicilno;
        Ad = ad;
        Soyad = soyad;
    }
    #endregion
}
