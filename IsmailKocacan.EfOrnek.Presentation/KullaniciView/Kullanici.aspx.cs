using IsmailKocacan.EfOrnek.Core;
using IsmailKocacan.EfOrnek.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsmailKocacan.EfOrnek.Presentation.KullaniciView
{
    public partial class KullaniciPage : System.Web.UI.Page
    {
        private KullaniciManager kManager = KullaniciManager.create();
        private static Kullanici kullanici ;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                kullaniciListele();

        }


        public void btnSave_Click(object sender, EventArgs e)
        {
            if (kullanici == null)
                kullaniciKaydet();

            if (kullanici != null)
                kullaniciGuncelle();
        }


        public void kullaniciKaydet()
        {
            Kullanici kullanici = Kullanici.create();
            kullanici.Ad = txtAdi.Text;
            kullanici.Soyad = txtSoyadi.Text;
            kullanici.EMailAdres = txtMail.Text;
            kManager.insert(kullanici);
        }


        public void kullaniciGuncelle()
        {
            kullanici.Ad = txtAdi.Text;
            kullanici.Soyad = txtSoyadi.Text;
            kullanici.EMailAdres = txtMail.Text;
            kManager.update(kullanici);
            kullanici = null;
        }


        public void kullaniciListele()
        {
            dListKullanici.DataSource = kManager.getKullaniciList();
            dListKullanici.DataBind();
        }


        public void kullaniciSil(int id)
        {
            kManager.delete(id);
        }

        protected void dListKullanici_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Label lblId = e.Item.FindControl("lblId") as Label;
            // Button btnDelete = e.Item.FindControl("btnDelete") as Button;
            // Button btnEdit = e.Item.FindControl("btnEdit") as Button;


            if (e.CommandName == "DELETE")
            {
                kullaniciSil(int.Parse(lblId.Text.Trim()));
                kullaniciListele();
            }


            if (e.CommandName == "EDIT")
            {
                kullanici = kManager.findKullanici(int.Parse(lblId.Text.Trim()));
                txtAdi.Text = kullanici.Ad;
                txtSoyadi.Text = kullanici.Soyad;
                txtMail.Text = kullanici.EMailAdres;
                e.Item.BackColor = System.Drawing.Color.LimeGreen;
            }

        }

        protected void btnListele_Click(object sender, EventArgs e)
        {
            this.kullaniciListele();
        }

        protected void btnYeni_Click(object sender, EventArgs e)
        {
            txtAdi.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtAdi.Focus();
        }

    
    }
}