using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7];
        int indis = 0;
        Random r;
        public Takim(Random _r)
        {
            r = _r;
        }

        public Asker[] Birlik
        {
            get
            {
                return birlik;
            }
            set
            {
                birlik = value;
            }
        }

        public void Olustur(Ermeydani em,int tk)
        {
            int secim,rand=0;
            Yuzbasi yb = new Yuzbasi();
            Tegmen tgm = new Tegmen();
            Er er=new Er();

            if (tk == 1)
            {
                rand = 0;               
            }
            else if(tk == 2)
            {
                rand = 11;
            }

            Ekle(em, yb, 1, rand);
            secim = r.Next(2) + 2;
            Ekle(em, tgm, secim, rand);
            Ekle(em, er, 7, rand);
        }

        void Ekle(Ermeydani em, Yuzbasi a,int dongu,int tk)
        {
            Bolge b;
            while(indis<dongu)
            {
                a = new Yuzbasi();
                b = new Bolge();
                do
                {
                    b.x = r.Next(5)+tk;
                    b.y = r.Next(5)+tk;
                    b.takım = tk;
                    a.Koordinat = b;
                }
                while (em.Harita[b.x, b.y] != null);

                em.Harita[b.x, b.y] = a.Koordinat;
                birlik[indis] = a;
                indis++;
            }
        }

        void Ekle(Ermeydani em, Tegmen a, int dongu,int tk)
        {
            Bolge b;
            while(indis<dongu)
            {
                a = new Tegmen();
                b = new Bolge();
                do
                {
                    b.x = r.Next(5)+tk;
                    b.y = r.Next(5)+tk;
                    b.takım = tk;
                    a.Koordinat = b;
                }
                while (em.Harita[b.x, b.y] != null);

                em.Harita[b.x, b.y] = a.Koordinat;
                birlik[indis] = a;
                indis++;
            }
        }

        void Ekle(Ermeydani em, Er a, int dongu,int tk)
        {
            Bolge b;
            while(indis<dongu)
            {
                a = new Er();
                b = new Bolge();
                do
                {
                    b.x = r.Next(5)+tk;
                    b.y = r.Next(5)+tk;
                    b.takım = tk;
                    a.Koordinat = b;
                }
                while (em.Harita[b.x, b.y] != null);

                em.Harita[b.x, b.y] = a.Koordinat;
                birlik[indis] = a;
                indis++;
            }
        }
    }
}
