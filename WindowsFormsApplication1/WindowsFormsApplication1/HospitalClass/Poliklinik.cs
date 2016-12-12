using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HospitalClass
{
    class Poliklinik
    {
        private int poliklinikID;
        private string poliklinikAdi;
        private string poliklinikBolumu;

        public Poliklinik(int poliklinikID, string poliklinikAdi, string poliklinikBolumu)
        {
            this.poliklinikID = poliklinikID;
            this.poliklinikAdi = poliklinikAdi;
            this.poliklinikBolumu = poliklinikBolumu;
        }
    }
}
