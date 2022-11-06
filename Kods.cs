using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbstractClass
{
    // Abstract Class ==> sınıfın sadece miras vermesi için işaretlenmesidir. Miras verebilir ancak yeni bir referans oluşturulmaz.
    

    public abstract class Personel
    {
        public string Adi { get; set; }

        // Abstract üyelerin gövdesi olamaz.
        public abstract string KimeBagli();
    }

    public class Yazilimci : Personel
    {
        public override string KimeBagli()
        {
            return "Bilişim Teknolojileri";
        }

    }
    public class Muhasebeci : Personel 
    {
        public override string KimeBagli()
        {
            return "Finans";
        }
    }

    public sealed class Departman // 'sealed' class ile işaretlenen sınıftan miras vermez
    {

    }


    //public class IK : Departman  // Departman  sınıfı sealed olduğu için miras veremez
    //{

    //}
}
