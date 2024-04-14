using WebApplication1.Models;

namespace WebApplication1.DB;

public static class Db
{
    public static List<Zwierze> Schronisko = new()
    {
        new Zwierze { Id = 1, Imie = "John", Kategoria = "kot", Masa = 20, Kolor_siersci = "biały"},
        new Zwierze { Id = 2, Imie = "Max", Kategoria = "kot", Masa = 15, Kolor_siersci = "czarny"},
        new Zwierze { Id = 3, Imie = "Mia", Kategoria = "kot", Masa = 18, Kolor_siersci = "szary"},
        new Zwierze { Id = 4, Imie = "Charlie", Kategoria = "kot", Masa = 22, Kolor_siersci = "pomarańczowy"},
        new Zwierze { Id = 5, Imie = "Luna", Kategoria = "kot", Masa = 17, Kolor_siersci = "brązowy"},
        new Zwierze { Id = 6, Imie = "Tiger", Kategoria = "kot", Masa = 19, Kolor_siersci = "pręgowany"},
        new Zwierze { Id = 7, Imie = "Bella", Kategoria = "kot", Masa = 16, Kolor_siersci = "rudy"},
        new Zwierze { Id = 8, Imie = "Simba", Kategoria = "kot", Masa = 21, Kolor_siersci = "pstry"},
        new Zwierze { Id = 9, Imie = "Oreo", Kategoria = "kot", Masa = 14, Kolor_siersci = "czarno-biały"},
        new Zwierze { Id = 10, Imie = "Milo", Kategoria = "kot", Masa = 20, Kolor_siersci = "jasnobrązowy"},
        new Zwierze { Id = 11, Imie = "Coco", Kategoria = "kot", Masa = 18, Kolor_siersci = "ciemnobrązowy"},
        new Zwierze { Id = 12, Imie = "Whiskers", Kategoria = "kot", Masa = 23, Kolor_siersci = "szaro-biały"},
        new Zwierze { Id = 13, Imie = "Smokey", Kategoria = "kot", Masa = 17, Kolor_siersci = "dymny"},
        new Zwierze { Id = 14, Imie = "Gizmo", Kategoria = "kot", Masa = 19, Kolor_siersci = "szylkretowy"},
        new Zwierze { Id = 15, Imie = "Mittens", Kategoria = "kot", Masa = 16, Kolor_siersci = "biało-czarny"},
        new Zwierze { Id = 16, Imie = "Oliver", Kategoria = "kot", Masa = 22, Kolor_siersci = "pomarańczowy i biały"},
        new Zwierze { Id = 17, Imie = "Shadow", Kategoria = "kot", Masa = 18, Kolor_siersci = "ciemnoszary"},
        new Zwierze { Id = 18, Imie = "Socks", Kategoria = "kot", Masa = 20, Kolor_siersci = "biały z czarnymi łatkami"},
        new Zwierze { Id = 19, Imie = "Boots", Kategoria = "kot", Masa = 15, Kolor_siersci = "biały z brązowymi plamami"},
        new Zwierze { Id = 20, Imie = "Whiskers", Kategoria = "kot", Masa = 21, Kolor_siersci = "szary z białymi paskami"},
        new Zwierze { Id = 21, Imie = "Lucky", Kategoria = "kot", Masa = 19, Kolor_siersci = "szaro-biały i czarny"}
    };

    public static List<Appointment> Wizyty = new()
    {
        new Appointment { id=1,data = 2024.12, zwierze = Schronisko.FirstOrDefault(st => st.Id == 1), opis = "kastrowanie", ocena = 8 },
        new Appointment { id=2,data = 2024.11, zwierze = Schronisko.FirstOrDefault(st => st.Id == 2), opis = "kastrowanie", ocena = 6 },
        new Appointment { id=3,data = 2024.8, zwierze = Schronisko.FirstOrDefault(st => st.Id == 3), opis = "kastrowanie", ocena = 7 },
        new Appointment { id=4,data = 2024.6, zwierze = Schronisko.FirstOrDefault(st => st.Id == 1), opis = "kastrowanie", ocena = 4 },
        new Appointment { id=5,data = 2024.1, zwierze = Schronisko.FirstOrDefault(st => st.Id == 1), opis = "kastrowanie", ocena = 2 }
    };
}