using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.HospitalClass
{
    class Doctor
    {
        public int doktorNo;
        public String ad;
        public String soyad;
        public String TC_kimlik;
        public String cinsiyet;
        public String dogumTarihi;
        public String cepNo;
        public String isNo;
        public String adres;
        public String brans;
        public String unvan;
        public int poliklinikNo;

        public Doctor(int doktorNo, String ad, String soyad, int poliklinikNo)
        {
            this.doktorNo = doktorNo;
            this.ad = ad;
            this.soyad = soyad;
            this.poliklinikNo = poliklinikNo;
        }

        public Doctor(int doktorNo, String TC_kimlik, String ad, String soyad, String cinsiyet
            ,String cepNo, String isNo, String adres, String brans, String unvan, int poliklinikNo, String dogumTarihi)
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
            this.brans = brans;
            this.unvan = unvan;
            this.poliklinikNo = poliklinikNo;
        }
    }
}
