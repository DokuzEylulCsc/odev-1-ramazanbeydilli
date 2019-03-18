using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        public override void HaraketEt(Ermeydani em, Random r)
        {
            int secim = r.Next(4);
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
                else if(secim==1)//Aşağı
                {
                    if (Koordinat.y > 0 && em.Harita[Koordinat.x, Koordinat.y - 1] == null)
                    {
                        Koordinat.y -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else if(secim==2) // sağ
                {
                    if (Koordinat.x < 15 && em.Harita[Koordinat.x+1, Koordinat.y] == null)
                    {
                        Koordinat.x += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else // sol
                {
                    if (Koordinat.x > 0 && em.Harita[Koordinat.x - 1, Koordinat.y] == null)
                    {
                        Koordinat.x -= 1;
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
                if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x + 2, Koordinat.y].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x - 2, Koordinat.y].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y + 2].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y - 2].takım)
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
