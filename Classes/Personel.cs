using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
    public class Personel : Person , IMaas
    {
        private decimal _maas;

        public decimal Maas
        {
            get { return _maas; }
            set { _maas = value; }
        }

        private Gorevler _gorev;

        public Gorevler Gorev
        {
            get { return _gorev; }
            set { _gorev = value; }
        }

    public enum Gorevler
        {
            Hasta_Bakıcı,
            Muhasebe,
            Güvenlik,
            Teknisyen
        }

    }
}
