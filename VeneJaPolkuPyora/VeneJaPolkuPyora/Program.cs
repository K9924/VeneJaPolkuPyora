using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ajoneuvo
{
    private string Nimi;
    private string Malli;
    private string Vari;
    private int MVuosi;
    public string nimi { get { return Nimi; } set { Nimi = value; } }
    public string malli { get { return Malli; } set { Malli = value; } }
    public string vari { get { return Vari; } set { Vari = value; } }
    public int mVuosi { get { return MVuosi; } set { MVuosi = value; } }

}
class Vene : Ajoneuvo
{
    private string moottorinMalli; 
    private bool OnMoottori { get; set; } 
     public string MoottorinMalli
    { get { return moottorinMalli; } set { if (onMoottori == true) { MoottorinMalli = value; } else { moottorinMalli = "n/a"; } } }
    public bool onMoottori { get; set; }
    public Vene(string nimi, string malli, string vari, int mVuosi, bool onMoottori, string moottorinMalli)
    {
        this.nimi = nimi;
        this.malli = malli;
        this.vari = vari;
        this.mVuosi = mVuosi;
        this.onMoottori = onMoottori;
        this.moottorinMalli = moottorinMalli;
    }
    public void veneenTiedot()
    {
        Console.WriteLine("nimi: " + nimi + " malli: " + malli + 
            " väri: " + vari + " mallin vuosi: " + mVuosi + " moottori: " +
                onMoottori + " moottorin malli: " + moottorinMalli);
    }
}
class Pyora : Ajoneuvo
{
    private string vaihteidenMalli;
    private bool onVaihteet { get; set; }
    public string VaihteidenMalli { get { return VaihteidenMalli; } set { VaihteidenMalli = value; } }
    public bool OnVaihteet { get; set; }

    public Pyora(string nimi, string malli, string vari, int mVuosi, bool onMoottori, string vaihteidenMalli)
    {
        this.nimi = nimi;
        this.malli = malli;
        this.vari = vari;
        this.mVuosi = mVuosi;
        this.onVaihteet = onVaihteet;
        this.vaihteidenMalli = vaihteidenMalli;
    }
    public void pyoranTiedot()
    {
        Console.WriteLine("nimi: " + nimi + " malli: " + malli +
           " väri: " + vari + " mallin vuosi: " + mVuosi + " vaihteet: " +
               onVaihteet + " vaihteiden malli: " + vaihteidenMalli);
    }
}

class Program
{
    
    static void Main(string[] args)
    {
       
        Vene vene1 = new Vene("Helga", "Järvi600", "Ruskea", 1985, false, "nakki");
        Vene vene2 = new Vene("Kojootti", "Buster705", "alumiini", 2007, true, "Kawasaki R-600 sk");
        vene1.veneenTiedot();
        vene2.veneenTiedot();

        Pyora pyora1 = new global::Pyora("Nakamura", "SuperX", "Vihreä", 1998, true, "Shimano X2");
        Pyora pyora2 = new global::Pyora("Tunturi", "Mankeli", "Punainen", 1932, false, "nakki");
        pyora1.pyoranTiedot();
        pyora2.pyoranTiedot();

        Console.Read();
       
    }
}

