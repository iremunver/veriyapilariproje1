using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    public class Araba
    {
        public string Plaka { get; set; }
        public int CikisSuresi { get; set; }

        public Araba(int sure)
        {
            CikisSuresi = sure;
        }
    }
}
