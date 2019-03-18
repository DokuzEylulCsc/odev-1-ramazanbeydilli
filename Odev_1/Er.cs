using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker
    {
        public override void HaraketEt(Ermeydani em, Random r)
        {
            try
            {
                //Yukarı
                if (r.Next(2) == 0)
                {
                    if (Koordinat.y < 15 && em.Harita[Koordinat.x, Koordinat.y + 1] == null)
                    {
                        Koordinat.y += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                    else if (Koordinat.y == 15 && Koordinat.x < 15 && em.Harita[Koordinat.x + 1, Koordinat.y] == null)
                    {
                        Koordinat.x += 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                }
                else //Aşağı
                {
                    if (Koordinat.y > 0 && em.Harita[Koordinat.x, Koordinat.y - 1] == null)
                    {
                        Koordinat.y -= 1;
                        em.Harita[Koordinat.x, Koordinat.y] = null;
                    }
                    else if (Koordinat.y == 0 && Koordinat.x < 15 && em.Harita[Koordinat.x - 1, Koordinat.y] == null)
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

        public override void AtesEt(Ermeydani em, Random r,Takim tk1,Takim tk2)
        {
            try
            {

                if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x+1, Koordinat.y].takım)
                {
                    
                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x - 1, Koordinat.y].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y+1].takım)
                {

                }
                else if (em.Harita[Koordinat.x, Koordinat.y].takım != em.Harita[Koordinat.x, Koordinat.y-1].takım)
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
