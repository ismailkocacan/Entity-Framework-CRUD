using System;
using System.Collections.Generic;
using IsmailKocacan.EfOrnek.Core;
using IsmailKocacan.EfOrnek.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace IsmailKocacan.EfOrnek.UnitTest
{
    [TestClass]
    public class KullaniciTest
    {

        KullaniciManager kManager;

        [TestInitialize()]
        public void initTest()
        {
            kManager = KullaniciManager.create();
        }

        [TestCleanup]
        public void releaseTest()
        {
            kManager.Dispose();
        }


        [TestMethod]
        public void insertKullanici()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = "ismail";
            kullanici.Soyad = "Kocacan";
            kullanici.EMailAdres = "ismailkocacan@gmail.com";
            kManager.insert(kullanici);
        }

        [TestMethod]
        public void updateKullanici()
        {
            Kullanici kullanici = kManager.findKullanici(1);
            kullanici.Ad = "ismail";
            kullanici.Soyad = "ufakcan";
            kullanici.EMailAdres = "aaa@gmail.com";
            kManager.update(kullanici);
        }

        [TestMethod]
        public void deleteKullanici()
        {
            kManager.delete(1);
        }


        [TestMethod]
        public void listKullanici()
        {
            IList<Kullanici> kullaniciList = kManager.getKullaniciList();
            foreach (Kullanici kullanici in kullaniciList)
            {

            }
        }
    }
}
