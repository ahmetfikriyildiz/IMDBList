using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    public class Program
    {
        // Film özelliklerini tutmak için FilmProp sınıfı tanımlanıyor
        class FilmProp
        {
            // Filmin adı
            public string Name { get; set; }
            // Filmin IMDb puanı
            public double ImdbPoint { get; set; }

            // Yapıcı metod: Film adı ve IMDb puanı alır ve özelliklere atar
            public FilmProp(string name, double imdbPoint)
            {
                Name = name;
                ImdbPoint = imdbPoint;
            }

            // ToString metodu, FilmProp nesnesinin ekrana yazdırıldığında gösterilecek formatı belirler
            public override string ToString()
            {
                return $"{Name} - IMDB Puanı {ImdbPoint}";
            }
        }

        static void Main(string[] args)
        {
            // FilmProp nesnelerinden oluşan bir liste tanımlanıyor
            List<FilmProp> films = new List<FilmProp>();

            // Film bilgilerini kullanıcıdan alma döngüsü
            while (true)
            {
                // Kullanıcıdan film adı isteniyor
                Console.Write("\nLütfen listenizde kullanılacak filmin adını giriniz: ");
                string name = Console.ReadLine();

                // Kullanıcıdan IMDb puanı isteniyor ve geçerliliği kontrol ediliyor
                Console.Write("\nLütfen IMDb puanını giriniz: ");
                if (double.TryParse(Console.ReadLine(), out double imdbPoint))
                {
                    // Geçerli bir puan girildiyse, yeni bir FilmProp nesnesi oluşturulup listeye ekleniyor
                    films.Add(new FilmProp(name, imdbPoint));
                }
                else
                {
                    // Geçersiz puan girildiğinde kullanıcı uyarılır
                    Console.WriteLine("\nGeçersiz puan, lütfen sayısal bir değer giriniz.");
                }

                // Kullanıcıya yeni bir film eklemek isteyip istemediği soruluyor
                Console.Write("\nYeni bir film eklemek istiyor musunuz? (evet/hayır): ");
                string condition = Console.ReadLine().ToLower();

                // Kullanıcı 'hayır' derse döngü sonlanır
                if (condition == "evet") continue;
                else if (condition == "hayır") break;
                else
                {
                    Console.WriteLine("\n*** Yanlış cevap verdiniz programdan çıkılıyor ***");
                    break;
                }
            }

            // Bütün filmleri listeleme
            Console.WriteLine("\nBütün Filmlerin Listesi\n");
            foreach (var film in films)
            {
                // Her bir film, ToString metoduna göre yazdırılıyor
                Console.WriteLine(film);
            }

            // IMDb puanı 4 ile 9 arasında olan filmleri listeleme
            Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler\n");
            foreach (var film in films)
            {
                // IMDb puanı 4 ile 9 arasında olan filmler kontrol edilir
                if (film.ImdbPoint >= 4 && film.ImdbPoint <= 9)
                {
                    Console.WriteLine(film); // Koşulu sağlayan filmler yazdırılır
                }
            }

            // İsmi 'A' ile başlayan filmleri listeleme
            Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler\n");
            foreach (var film in films)
            {
                // Filmin adı 'A' harfi ile başlıyor mu kontrol edilir
                if (film.Name.StartsWith("A"))
                {
                    Console.WriteLine(film); // Koşulu sağlayan filmler yazdırılır
                }
            }

            // Programın kapanmaması için tuşa basılmasını bekler
            Console.ReadKey();
        }
    }
}
