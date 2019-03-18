using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Program
    {
        
        static void Main()
        {
            Program p = new Program();
            Random r = new Random();
            Ermeydani em = new Ermeydani();
            Takim tk1 = new Takim(r);
            tk1.Olustur(em, 1);
            Takim tk2 = new Takim(r);
            tk2.Olustur(em, 2);
            
            p.Savas(em, tk1, tk2,r);
        }

        void Savas(Ermeydani em,Takim tk1,Takim tk2,Random r)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    tk1.Birlik[j].HaraketEt(em, r);
                    tk2.Birlik[j].HaraketEt(em, r);
                }
            }
        }
    }
}
