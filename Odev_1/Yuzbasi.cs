using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        public override void HaraketEt(Ermeydani em, Random r)
        {
            int secim = r.Next(8);
            try
            {
                //Yukarı
                if (secim == 0)
                {
                    if (Koordinat.y < 15 && em.Harita[Koordinat.x, Koordinat.y + 1] == null)
                    {
                        Koordinat.y += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 1)//Aşağı
                {
                    if (Koordinat.y > 0 && em.Harita[Koordinat.x, Koordinat.y - 1] == null)
                    {
                        Koordinat.y -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 2) // sağ
                {
                    if (Koordinat.x < 15 && em.Harita[Koordinat.x + 1, Koordinat.y] == null)
                    {
                        Koordinat.x += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 3)// sol
                {
                    if (Koordinat.x > 0 && em.Harita[Koordinat.x - 1, Koordinat.y] == null)
                    {
                        Koordinat.x -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 4) // sağ üst
                {
                    if (Koordinat.x < 15 && Koordinat.y < 15 && em.Harita[Koordinat.x + 1, Koordinat.y + 1] == null)
                    {
                        Koordinat.x += 1;
                        Koordinat.y += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 5) //sağ alt
                {
                    if (Koordinat.x < 15 && Koordinat.y > 0 && em.Harita[Koordinat.x + 1, Koordinat.y - 1] == null)
                    {
                        Koordinat.x += 1;
                        Koordinat.y -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if (secim == 6) //sol üst
                {
                    if (Koordinat.x > 0 && Koordinat.y < 15 && em.Harita[Koordinat.x - 1, Koordinat.y + 1] == null)
                    {
                        Koordinat.x -= 1;
                        Koordinat.y += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else //sol alt
                {
                    if (Koordinat.x > 0 && Koordinat.y > 0 && em.Harita[Koordinat.x - 1, Koordinat.y - 1] == null)
                    {
                        Koordinat.x -= 1;
                        Koordinat.y -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

        }

        public override void Bekle()
        {
            try
            {

            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        public override void AtesEt(Ermeydani em, Random r, Takim tk1, Takim tk2)
        {
            try
            {
                if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x + 3, Koordinat.y].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x - 3, Koordinat.y].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y + 3].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y - 3].takım)
                {

                }
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
