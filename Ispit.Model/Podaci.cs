using Ispit.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit.Model;

public class Podaci
{
    public List<Banka> ListaBanki = new List<Banka>()
        {
            new Banka { Simbol = "FNB", Naziv = "First Nova Bank" },
            new Banka { Simbol = "UBX", Naziv = "Unity Bank X" },
            new Banka { Simbol = "CRB", Naziv = "Crown River Bank" }
        };
    public List<Klijent> ListaKlijenata = new List<Klijent>()
        {
            new Klijent { ImePrezime = "Marko Vuk", Stanje = 2500000, Banka = "FNB" },
            new Klijent { ImePrezime = "Iva Vozab", Stanje = 999999999999999, Banka = "FNB" },
            new Klijent { ImePrezime = "Ivana Kralj", Stanje = 1200000000, Banka = "FNB" },
            new Klijent { ImePrezime = "Petar Lonar", Stanje = 8000, Banka = "FNB" },
            new Klijent { ImePrezime = "Ana Radić", Stanje = 3100000, Banka = "UBX" },
            new Klijent { ImePrezime = "Tamara Babić", Stanje = 7100000, Banka = "UBX" },
            new Klijent { ImePrezime = "Maja Šarić", Stanje = 9200, Banka = "UBX" },
            new Klijent { ImePrezime = "Ivan Horvat", Stanje = 1800000, Banka = "CRB" },
            new Klijent { ImePrezime = "Sara Novak", Stanje = 6000, Banka = "CRB" },
            new Klijent { ImePrezime = "Tomislav Perić", Stanje = 15000, Banka = "CRB" }
        };

    public Podaci()
    {
        ProvjeriMilijunase();
    }

    private void ProvjeriMilijunase()
    {
        if (ListaBanki.Any(b =>!ListaKlijenata.Any(k => k.Stanje >= 1000000 && k.Banka == b.Simbol)))
        {
            throw new Exception("Greška: neka banka nema milijunaša!");
        }
    }
}
