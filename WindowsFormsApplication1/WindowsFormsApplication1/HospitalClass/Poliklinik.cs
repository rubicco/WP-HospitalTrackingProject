using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HospitalClass
{
    class Poliklinik
    {
        public int poliklinikID;
        public string poliklinikAdi;

        public Poliklinik(int poliklinikID, string poliklinikAdi)
        {
            this.poliklinikID = poliklinikID;
            this.poliklinikAdi = poliklinikAdi;
        }
    }
}
