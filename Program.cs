namespace _6_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazilimci yz = new Yazilimci();
            yz.Adi = "Ekrem";

            Yazilimci yz1 = new Yazilimci();
            yz.Adi = "İsmail";

            Muhasebeci mh = new Muhasebeci();
            mh.Adi = "Büşra";

            Personel p1 = mh; // p1 mh'nin referansını tutuyor..

            // Personel p = new Personel(); // Personel sınıfımız Abstract olduğu için bu sınıftan instance alınamaz.

            Console.WriteLine(yz.KimeBagli());
            Console.WriteLine(yz1.KimeBagli());
            Console.WriteLine(mh.KimeBagli());

            Departman dep =new Departman();

            OdemeYap(mh);
            OdemeYap(yz1);
            OdemeYap(yz);


            Console.ReadKey();
        }
        static void OdemeYap(Personel p) 
        {
        }
    }
}