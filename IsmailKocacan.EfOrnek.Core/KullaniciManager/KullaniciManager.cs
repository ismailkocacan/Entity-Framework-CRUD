using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using IsmailKocacan.EfOrnek.Data.DatabaseContext;
using IsmailKocacan.EfOrnek.Domain;


namespace IsmailKocacan.EfOrnek.Core
{
    public class KullaniciManager : IDisposable
    {
        private MyDbContext db;

        public KullaniciManager()
        {
            this.db = new MyDbContext();
        }


        public Boolean insert(Kullanici kullanici)
        {
            try
            {
                db.kullanici.Add(kullanici);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public Boolean update(Kullanici kullanici)
        {
            try
            {
                db.Entry(kullanici).State = EntityState.Modified; 
                db.SaveChanges();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public Boolean delete(int id)
        {
            try
            {
                Kullanici kullanici = db.kullanici.SingleOrDefault(x => x.Id == id);
                db.kullanici.Remove(kullanici);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Boolean delete(Kullanici kullanici)
        {
            try
            {
                db.kullanici.Remove(kullanici);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public Kullanici findKullanici(int id)
        {
            Kullanici kullanici = db.kullanici.SingleOrDefault(x => x.Id == id);
            return kullanici;
        }

        public IList<Kullanici> getKullaniciList()
        {
            return db.kullanici.ToList();
        }

        public static KullaniciManager create()
        {
            KullaniciManager kManager = new KullaniciManager();
            return kManager;
        }


        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
