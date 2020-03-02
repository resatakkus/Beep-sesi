using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bip_Sesi
{//Kullanıcıya Kaç yaşında olduğunu sorun
    //En güzel yaşın kullanıcının yaşı olduğunu belirtin
    //Bip sesiyle programı sonlandırın
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç yaşındasınız");
            var yaş = Console.ReadLine();
            Console.WriteLine("En güzel yaş: " + yaş);
            Console.ReadLine();
            Console.Beep();

        }
    }
}
