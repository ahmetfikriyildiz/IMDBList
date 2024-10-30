using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    public class Program
    {
        class FilmProp
        {
            public string Name {  get; set; }
            public double ImdbPoint { get; set; }
            public FilmProp(string name, double imdbPoint)
            {
                Name = name;
                ImdbPoint = imdbPoint;
            }
            public override string ToString()
            {
                return $"{Name} - IMDB Puanı {ImdbPoint} ";
            }
        }
       
        
        static void Main(string[] args)
        {
            List<FilmProp> films = new List<FilmProp>();
            while (true)
            {
                Console.Write("Lütfen listenizde kullanılcak filmin adını ve IMBD puanını giriniz :");
                string name = Console.ReadLine();

                Console.Write("Lütfen IMDb puanını giriniz:");
                if (double.TryParse(Console.ReadLine(), out double imdbPoint))
                {
                    films.Add(new FilmProp(name, imdbPoint));
                }
                else
                {
                    Console.WriteLine("Geçersiz puan, lütfen sayısal bir değer giriniz.");
                }
                Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
                string condition = Console.ReadLine().ToLower();

                if (condition == "hayır") break;
            }

            Console.WriteLine("\n    Bütün Filmlerin Listesi \n");
            foreach (var film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine("\n    IMDb Puanı 4 ile 9 Arasında Olan Filmler \n");

            foreach (var film in films)
            {
                if (film.ImdbPoint >= 4 && film.ImdbPoint <= 9)
                {
                    Console.WriteLine(film);
                }
            }

            Console.WriteLine("\n    İsmi 'A' ile Başlayan Filmler \n");

            foreach (var film in films)
            {
                if (film.Name.StartsWith("A"))
                {
                    Console.WriteLine(film);
                }
            }


            Console.ReadKey();
        }
    }
}
