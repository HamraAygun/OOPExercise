using OOPExercise;


    internal class Program
{

    //İnsan isimli bir sınıf içinde, ad, soyad, boy, kilo, yaş alanlarını tanımlayıp, bir kurucu metot içinde bu alanlar için varsayılan değer atamalarını yapacağız. Son olarak da class için "Tanis" isimli metod ile girilen bilgileri kullancıya belli, açıklayıcı bir şekilde görüntüleyen bir programcık yazınız.

    // Örnek : Ben Hamra AYGÜN... Boyum 165cm, Kilom 55kg, yaşım 27'dir.

    private static void Main(string[] args)
    {

        clsInsan clsInsan = new clsInsan("Hamra", "Aygün");

        clsInsan.Tanis();

        Console.ReadKey();


    }
}