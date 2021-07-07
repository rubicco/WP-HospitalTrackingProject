using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HospitalClass
{
    class Patient
    {
        public int hastaNo;
        public String ad;
        public String soyad;
        public String TC_kimlik;
        public String cinsiyet;
        public String dogumTarihi;
        public String cepNo;
        public String isNo;
        public String meslek;
        public String adres;
        public String email;

        public Patient(int hastaNo, String ad, String soyad)
        {
            this.hastaNo = hastaNo;
            this.ad = ad;
            this.soyad = soyad;
        }

        public Patient(int hastaNo, String ad, String soyad, String TC_kimlik, String cinsiyet, String dogumTarihi
            , String cepNo, String isNo, String meslek, String adres, String email)
        {
            this.hastaNo = hastaNo;
            this.ad = ad;
            this.soyad = soyad;
            this.TC_kimlik = TC_kimlik;
            this.cinsiyet = cinsiyet;
            this.dogumTarihi = dogumTarihi;
            this.cepNo = cepNo;
            this.isNo = isNo;
            this.meslek = meslek;
            this.adres = adres;
            this.email = email;
        }
    }
}
