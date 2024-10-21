/* ikisi sayi arasindaki fark */
int x = 44;
int y = 25;
int sonuc = x - y;
Console.WriteLine("iki sayinin farkı: " + sonuc);
Console.WriteLine("\n");


/* 5 sayisinin karesi */
int z = 5;
int karesi = 5 * 5;
Console.WriteLine("5 sayisinin karesi: " + karesi);
Console.WriteLine("\n");


/* 10 sayisinin 3'e bolumunden kalan */
double t = 10.0;
double r = 3.0;
double sonuc2 = t / r;
Console.WriteLine("10'un 3'e bolumunden kalan sayi: " + sonuc2);
Console.WriteLine("\n");


/* klavyeden girilen 4 sayinin toplami ve carpimi */

Console.WriteLine("Sayi_1 gir: ");
int Sayi_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayi_2 gir: ");
int Sayi_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayi_3 gir: ");
int Sayi_3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayi_4 gir: ");
int Sayi_4 = Convert.ToInt32(Console.ReadLine());

int sonuc_toplam = Sayi_1 + Sayi_2 + Sayi_3 + Sayi_4;
int sonuc_carpim = Sayi_1 * Sayi_2 * Sayi_3 * Sayi_4;

Console.WriteLine("toplam: " + sonuc_toplam);
Console.WriteLine("carpim: " + sonuc_carpim);
Console.WriteLine("\n");


/*  klavyeden girilen 2 sayinin bolumu */
Console.WriteLine("bolunen sayiyi gir: ");
double bolunen = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("bolen sayiyi gir: ");
double bolen = Convert.ToDouble(Console.ReadLine());
double sonuc_bolme = bolunen / bolen;
Console.WriteLine("2 sayinin bolumu: " + sonuc_bolme);
Console.WriteLine("\n");


/* klavyeden kenarları girilen dikdortgenler prizmasının hacmi */
Console.WriteLine("1. kenari gir: ");
int kenar_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. kenari gir: ");
int kenar_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. kenari gir: ");
int kenar_3 = Convert.ToInt32(Console.ReadLine());
int sonuc_prizma = kenar_1 * kenar_2 * kenar_3;
Console.WriteLine("dikdortgenler prizmasinin hacmi: " + sonuc_prizma);
Console.WriteLine("\n");
