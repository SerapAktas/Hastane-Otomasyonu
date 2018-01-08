using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
  public  class Hemsire : Person ,IMaas
    {
        private HBranslar _brans;
        public bool bosMu { get; set; }
        public HBranslar Brans
        {
            get { return _brans; }
            set { _brans = value; }
        }

        private decimal _maas;

            public decimal Maas
            {
                get { return _maas; }
                set { _maas = value; }
            }
    }
    public enum HBranslar
    {
        Ortopedi,
        Dahiliye,
        KBB,
        Nöroloji,
        Kardiyoloji,
        Cildiye,
        Gastroloji
    }
    

}
