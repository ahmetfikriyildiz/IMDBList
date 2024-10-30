IMDbList Uygulaması

IMDbList, kullanıcının bir film listesi oluşturmasına, IMDb puanı ve film adı bilgilerini ekleyerek bu listeyi yönetmesine olanak tanıyan basit bir C# uygulamasıdır. Uygulama, kullanıcıdan sınırsız sayıda film bilgisi alır ve belirli kriterlere göre film listesini filtreleyerek ekrana yazdırır.

Özellikler

Film Ekleme: Kullanıcı, film adı ve IMDb puanını girerek film listesini oluşturabilir.
IMDb Puanına Göre Filtreleme: IMDb puanı 4 ile 9 arasında olan filmler ekrana yazdırılır.
Harf ile Filtreleme: İsmi 'A' harfi ile başlayan filmler ekrana yazdırılır.
Tüm Filmleri Listeleme: Kullanıcının girdiği tüm filmler listelenir.
Kullanım

Film Ekleme:
Uygulama, kullanıcıdan bir film adı ve IMDb puanı ister.
Geçerli bir IMDb puanı girildiğinde film listeye eklenir.
Kullanıcıya başka bir film eklemek isteyip istemediği sorulur. "Evet" derse yeni film ekleme devam eder; "Hayır" derse program sona erer ve sonuçları ekrana yazdırır.
Filtreleme ve Listeleme:
Kullanıcı "hayır" dediğinde veya yanlış bir cevap verdiğinde, tüm liste sırasıyla filtrelere göre ekrana yazdırılır:
Tüm Filmler

IMDb puanı 4 ile 9 arasında olan filmler
İsmi 'A' ile başlayan filmler