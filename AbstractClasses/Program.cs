using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Değerlendir();
            aMevzuat.Kaydet();
            BMevzuant bMevzuant = new BMevzuant();
            bMevzuant.Değerlendir();
            bMevzuant.Kaydet();
        }
    }
    abstract class MevzuatBase
    {
        public abstract void Değerlendir();

        public void Kaydet()
        {
            Console.WriteLine("kaydedildi");
        }
      
    }
    class AMevzuat : MevzuatBase
    {
        public override void Değerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendir");
        }
    }
    class BMevzuant : MevzuatBase
    {
        public override void Değerlendir()
        {
            Console.WriteLine("B Mevzuatına göre Değerlendir");
        }
    }
}
