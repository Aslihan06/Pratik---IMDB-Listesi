using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

class Film
{
    // Film özellikleri
    public string Adi { get; set; }
    public double ImdbPuani { get; set; }

    // Film bilgilerini yazdırmak için metot
    public override string ToString()
    {
        return $"{Adi} - IMDb: {ImdbPuani}";
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devam;

        // Film ekleme döngüsü
        do
        {
            Film film = new Film();

            // Kullanıcıdan film adı ve IMDb puanı al
            Console.Write("Film Adı: ");
            film.Adi = Console.ReadLine();

            Console.Write("IMDb Puanı: ");
            film.ImdbPuani = Convert.ToDouble(Console.ReadLine());

            // Listeye film ekle
            filmListesi.Add(film);

            // Yeni film eklemek isteyip istemediğini sor
            Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
            devam = Console.ReadLine().ToLower();
        } while (devam == "evet");

        // Tüm filmleri listele
        Console.WriteLine("\nTüm Filmler:");
        foreach (Film film in filmListesi)
        {
            Console.WriteLine(film);
        }

        // IMDb puanı 4 ile 9 arasında olan filmleri listele
        Console.WriteLine("\nIMDb Puanı 4 ile 9 arasında olan Filmler:");
        var imdbFiltre = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
        foreach (Film film in imdbFiltre)
        {
            Console.WriteLine(film);
        }

        // İsmi 'A' ile başlayan filmleri listele
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        var aIleBaslayanFilmler = filmListesi.Where(f => f.Adi.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (Film film in aIleBaslayanFilmler)
        {
            Console.WriteLine(film);
        }
    }
}

