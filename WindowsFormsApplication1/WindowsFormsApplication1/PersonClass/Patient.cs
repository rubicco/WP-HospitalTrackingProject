using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Person
{
    class Patient
    {
        private String hastaNo;
        private String ad;
        private String soyad;
        private String TC_kimlik;
        private String cinsiyet;
        private DateTime dogumTarihi;
        private String cepNo;
        private String isNo;
        private String meslek;
        private String adres;
        private String email;

        public Patient(String hastaNo, String ad, String soyad, String TC_kimlik, String cinsiyet, DateTime dogumTarihi
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
