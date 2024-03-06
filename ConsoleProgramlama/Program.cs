
using ConsoleProgramlama;

//!!! Değişkenler, Yazdırma , Okuma
static void Chapter1Notes()
{
    string name = Console.ReadLine();

    int degisken = 5;

    string degisken2 = "merhaba";

    Console.WriteLine(degisken);
}
//Chapter1Notes();

//!!! Tip dönüşümleri
static void Chapter2Notes()
{

    //Implicit Conversion || Bilinçsiz Dönüşüm : Düşük kapisteli -> Daha büyük kapisteliye aktarılması

    byte a = 5;
    sbyte b = 30;
    short c = 10;

    int d = a + b + c;
    Console.WriteLine("d: " + d);

    long h = d;
    Console.WriteLine("h: " + h);
    float f = h;
    Console.WriteLine("f: " + f);


    string e = "asdasd";
    char ch = 't';
    object g = e + ch + d;
    Console.WriteLine("g: " + g);


    //Explicit Conversion || Bilinçsiz Dönüşüm
    Console.WriteLine("***** Explicit Conversion *****");

    int x = 100;
    byte y = (byte)x;
    Console.WriteLine("y: " + y);

    float w = 10.3f;
    byte v = (byte)w;
    Console.WriteLine("v: " + v);

    string zz = 12.5f.ToString();
    Console.WriteLine("zz: " + zz);

    string s1 = "1000";
    int s1i = Convert.ToInt32(s1);
    Console.WriteLine(s1i);

    int i1 = 1000;
    string i1s = Convert.ToString(i1);
    Console.WriteLine(i1s);

    string word = "Hello";
    Char[] letters = i1s.ToCharArray();
    foreach (var item in letters)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("***** Parse ***");

    ParseMethod();
    static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";



        int rakam1 = Int32.Parse(metin1);
        Console.WriteLine("rakam1: " + rakam1);
        double double1 = Double.Parse(metin2);
        Console.WriteLine("double1: " + double1);
    }
}
//Chapter2Notes();

//!!! Hata Yönetimi || Exception Handling
static void Chapter3Notes()
{
    try
    {
        Console.WriteLine("Bir sayı giriniz");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girilen sayi: " + sayi);
    }

    catch(Exception e) 
    {
        Console.WriteLine("Hata: "+ e.Message.ToString());
    }
    finally //Hata alsın almasın çalışacak kod bloğu
    {
        Console.WriteLine("İşlem Tamamlandı.");
    }

    try
    {
        //int a = int.Parse(null);
        //int a = int.Parse("test");
        int a = int.Parse("-20000000000000000000000");
    }
    catch( ArgumentNullException ex )
    {
        Console.WriteLine("Boş değer girdiniz.");
        Console.WriteLine(ex);
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Veri tipi uygun değil");
        Console.WriteLine(ex);
    }
    catch(OverflowException ex)
    {
        Console.WriteLine("Overflow exception");
        Console.WriteLine(ex);
    }
}
//Chapter3Notes();

//!!! Karar Yapıları
static void Chapter4_1Notes()
{
    int time = DateTime.Now.Hour;
    if (time >= 6 && time < 11)
        Console.WriteLine("Günaydın");
    else if (time <= 18)
        Console.WriteLine("İyi günler.");
    else
        Console.WriteLine("İyi geceler");

    string sonuc = time <= 18 ? "İyi günler" : "İyi Geceler";

    sonuc = time >= 6 && time < 11 ? "Günaydın" :
                        time <= 18 ? "İyi günler" :
                                     "İyi geceler";

    Console.WriteLine(sonuc);
    
}
//Chapter4_1Notes();
static void Chapter4_2Notes()
{
    int month = DateTime.Now.Month;
    switch (month)
    {
        case 1:
            Console.WriteLine("Ocak ayındasınız.");
            break;
        case 2:
            Console.WriteLine("Şubat ayındasınız.");
            break;
        case 4:
            Console.WriteLine("Nisan ayındasınız.");
            break;
        case 3:
            Console.WriteLine("Mart ayındasınız.");
            break ;
        default:
            Console.WriteLine("Yanlış veri girişi");
            break;

    }
}
//Chapter4_2Notes();


//!!! Diziler
static void Chapter5Notes()
{
    string[] renkler = new string[5];
    string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" };

    int[] dizi;
    dizi = new int[5];

    renkler[0] = "Mavi";
    Console.WriteLine(renkler[0]);
    Console.WriteLine(hayvanlar[1]);
    dizi[3] = 10;
    Console.WriteLine(dizi[3]);

    Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
    int diziElemanSayısı = int.Parse(Console.ReadLine());
    int[] sayiDizisi = new int[diziElemanSayısı];
    for (int i = 0; i < diziElemanSayısı; i++)
    {
        Console.Write("Lütfen {0}. eleman sayını giriniz: ", i + 1);
        sayiDizisi[i] = int.Parse(Console.ReadLine());
    }
    int toplam = 0;
    foreach (var item in sayiDizisi)
    {
        toplam += item;
    }
    Console.WriteLine("Ortalama : "+ toplam/diziElemanSayısı);



}
//Chapter5Notes();
static void Chapter6Notes()
{
    int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
    Console.WriteLine("Sırasız dizi");
    foreach (var sayi in sayiDizisi)
    {
        Console.Write(sayi + " ");
    }
    Console.Write("\n");
    Console.WriteLine("Sıralı dizi");

    Array.Sort(sayiDizisi);
    foreach (var sayi in sayiDizisi)
    {
        Console.Write(sayi + " ");
    }
    Console.Write("\n");
    Console.WriteLine("**** Array Clear ****");
    Array.Clear(sayiDizisi, 2, 2); //2. indexten 2 tane elemanı 0la
    foreach (var sayi in sayiDizisi)
    {
        Console.Write(sayi + " ");
    }
    Console.Write("\n");
    Console.WriteLine("**** Array Reverse ****");
    Array.Reverse(sayiDizisi);
    foreach (var sayi in sayiDizisi)
    {
        Console.Write(sayi + " ");
    }
    Console.Write("\n");
    Console.WriteLine("**** Array IndexOf ****");
    Console.WriteLine(Array.IndexOf(sayiDizisi, 86));

    Console.Write("\n");
    Console.WriteLine("**** Array Resize **** GÜZELMİŞ");
    Array.Resize<int>(ref sayiDizisi, 9);
    sayiDizisi[8] = 99;
    foreach (var sayi in sayiDizisi)
    {
        Console.Write(sayi + " ");
    }


}
//Chapter6Notes();

//!!! Methods
static void Chapter7Notes()
{
    int a = 2;
    int b = 3;

    Console.WriteLine(Topla(a,b));
    
    int sonuc = Topla(a,b);
   
    Metot1 metotlar = new Metot1();
    metotlar.EkranaYazdır(sonuc.ToString());

    metotlar.EkranaYazdır(metotlar.ArttırVeTopla(a, b).ToString());
    static int Topla(int a,int b)
    {
        return a + b;
    }
}
//Chapter7Notes();

static void Chapter8Notes()
{
    //out parametreler
    string sayi= "999";

    bool sonuc = int.TryParse(sayi, out int outSayi);
    if (sonuc)
        Console.WriteLine("Başarılı: " + outSayi);
    else
        Console.WriteLine("Başarısız.");

    /*
     * Metot Overloading
     * Metot Imzası -> metotAdı + parametre sayı + parametre
     */
      
}
//Chapter8Notes();

//Rekürsif ve Extension Metotlar
static void Chapter9Notes()
{

    Chapter9_Expo metot = new Chapter9_Expo();
    Console.WriteLine(metot.Expo(5,4));

    //Extation Metotlar

    string ifade = "mete mete mete";
    Console.WriteLine(ifade.CheckSpace());
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}
Chapter9Notes();