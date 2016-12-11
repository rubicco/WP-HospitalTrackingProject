using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Person
{
    class Doctor
    {
        private String doktorNo;
        private String ad;
        private String soyad;
        private String TC_kimlik;
        private String cinsiyet;
        private DateTime dogumTarihi;
        private String cepNo;
        private String isNo;
        private String adres;
        private String email;
        private String brans;
        private String unvan;
        private String poliklinikNo;

        public Doctor(String doktorNo, String ad, String soyad, String TC_kimlik, String cinsiyet, DateTime dogumTarihi
            ,String cepNo, String isNo, String adres, String email, String brans, String unvan, String poliklinikNo)
        {
            this.doktorNo = doktorNo;
            this.ad = ad;
            this.soyad = soyad;
            this.TC_kimlik = TC_kimlik;
            this.cinsiyet = cinsiyet;
            this.dogumTarihi = dogumTarihi;
            this.cepNo = cepNo;
            this.isNo = isNo;
            this.adres = adres;
            this.email = brans;
            this.unvan = unvan;
            this.poliklinikNo = poliklinikNo;
        }
    }
}
