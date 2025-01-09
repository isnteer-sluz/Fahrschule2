namespace Fahrschule2;

public class Fahrschule
{
    public List<Fahrlehrer> FahrlehrerListe { get; set; }
    public List<Schüler> SchülerListe { get; set; }
    public List<Fahrzeug> FahrzeugListe { get; set; }

    public Fahrschule()
    {
        FahrlehrerListe = new List<Fahrlehrer>();
        SchülerListe = new List<Schüler>();
        FahrzeugListe = new List<Fahrzeug>();
    }

    public void AddFahrlehrer(Fahrlehrer fahrlehrer)
    {

    }

    public void AddSchüler(Schüler schüler)
    {

    }

    public void AddFahrzeug(Fahrzeug fahrzeug)
    {

    }
}