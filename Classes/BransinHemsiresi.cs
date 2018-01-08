using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastahaneRandevuSistemi.Classes
{
    public static class BransinHemsiresi
    {
        public static List<Hemsire> hemsireSecimi(List<Hemsire> hemsireler, string brans)
        {
            List<Hemsire> bosHemsireler = hemsireler.Where(x => Convert.ToString(x.Brans) == brans).ToList();

            return bosHemsireler;
        }
    }
}
