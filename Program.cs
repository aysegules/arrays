internal class Program
{
    public static void Main(string[] args)
    {
        //Dizi tanimlama
        string[] renkler=new string[10];

        int[] dizi;
        dizi=new int[10];

        string[] hayvanlar={"kelebek","bukalemun","timsah","zebra","panter"};

        //Dizilere deger atama ve erisim
        renkler[0]="pembe";
        renkler[7]="turuncu";

        dizi[0]=8;
        dizi[3]=16;

        Console.WriteLine(renkler[7]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(hayvanlar[4]);

        //Dongulerle dizi kullanimi
        //Klavyeden girilen n tane sayinin ortalamasini hesaplayan program
        Console.WriteLine("Lutfen dizinin eleman sayisini giriniz:");
        int diziUzunlugu=int.Parse(Console.ReadLine());
        int[] sayiDizisi=new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.WriteLine("Lutfen dizinin {0}. elemanini giriniz:",i+1);
            sayiDizisi[i]=int.Parse(Console.ReadLine());
        }
        int toplam=0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }

        double ortalama=toplam/diziUzunlugu;
        Console.WriteLine("Dizinin ortalamasi :"+ortalama);

        
    }

}