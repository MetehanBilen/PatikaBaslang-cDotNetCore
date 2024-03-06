
static void Question1()
{
    Console.WriteLine("Pozitif bir sayı giriniz ");
    int inputInt = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < inputInt; i++)
    {
        Console.WriteLine("{0}. sayıyı giriniz : ", i+1);
        int readedNo = Convert.ToInt32(Console.ReadLine());
        if(readedNo%2 == 0)
        Console.WriteLine("{0} çift sayısı giriş yapıldı.", readedNo);
    }
}
//Question1();

static void Question2()
{
    Console.WriteLine("Pozitif bir sayı giriniz ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Pozitif bir sayı giriniz ");
    int m = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("{0}. sayıyı giriniz : ", i+1);
        int readedNo = Convert.ToInt32(Console.ReadLine());
        if (readedNo % m == 0)
            Console.WriteLine("{0} sayısı {1} sayısına tam bölünür.", readedNo,m);
    }
}
//Question2();

static void Question3()
{

}