using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        private bool yasam = true;
        private int can = 100;

        public int Can
        {
            get { return can; }
            set { can = value; }
        }

        public bool Yasam
        {
            get { return yasam; }
            set { yasam = value; }
        }

        public Bolge Koordinat
        {
            get
            {
                return koordinat;
            }
            set
            {
                koordinat = value;
            }
        }

        public abstract void HaraketEt(Ermeydani em, Random r);

        public abstract void Bekle();

        public abstract void AtesEt(Ermeydani em, Random r, Takim tk1, Takim tk2);
    }
}
