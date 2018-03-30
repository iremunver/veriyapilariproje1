using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyon
{
    public interface IAraba
    {
        void Ekle(Araba a);
        void Cikar(Araba a);
        string Listele();
    }
}
