using Ispit.Model;
using Ispit.Model.Models;
namespace Ispit.Konzola;
internal class Program
{
    static void Main(string[] args)
    {
        Podaci podaci = new Podaci();
        Console.WriteLine("\n Grupiranje milijunaša.");
        var GrupirajPremaBanci = podaci.ListaKlijenata
                 .Where(k => k.Stanje >= 1000000)
                 .GroupBy(k => k.Banka)
                 .Select(g => new GrupiraniMilijunasi
                 {
                     Banka = g.Key,
                     Milijunasi = g.Select(x => x.ImePrezime)
                 });
        foreach (var grupa in GrupirajPremaBanci)
        {
            Console.WriteLine($"Banka {grupa.Banka}: " +string.Join(" i ", grupa.Milijunasi) +".");
        }
        Console.WriteLine("\n \n Izvještaj milijunaša.");
        var IzvjestajMilijunasa = from p in podaci.ListaKlijenata
                                  where p.Stanje >= 1000000
                                  join b in podaci.ListaBanki
                                  on p.Banka equals b.Simbol
                                  select new
                                  {
                                      p.ImePrezime,
                                      BankaNaziv = b.Naziv
                                  };
        foreach(var milijunas in IzvjestajMilijunasa)
        {
            Console.WriteLine($"{milijunas.ImePrezime} je u {milijunas.BankaNaziv} banci." );
        }
    }
}
