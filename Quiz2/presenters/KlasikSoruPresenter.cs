using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using Quiz2.views;
using System.Data.Linq;

namespace Quiz2.presenters
{
    class KlasikSoruPresenter
    {
        IKlasikSoruView view;
        SoruBankasıDataContext dbContext;

        public KlasikSoruPresenter(IKlasikSoruView view)
        {
            this.view=view;
            dbContext = new SoruBankasıDataContext();

        }

        public void klasikSoruEkle(int ktg,int svy,string soru,string cevap,string dogru ,int p)
        {
            KlasikSoru yeni = new KlasikSoru();

            yeni.KategoriId = ktg;
            yeni.SeviyeId = svy;
            yeni.SoruMetni = soru;
            yeni.CevapMetni = cevap;
            yeni.Doğrucevap = dogru;
            yeni.Puan = p;

            dbContext.KlasikSorus.InsertOnSubmit(yeni);
            dbContext.SubmitChanges();

            view.updateKlasikSorularGrid(dbContext.KlasikSorus.ToList());
        }

        public void yükle()
        {
            view.updateKlasikSorularGrid(dbContext.KlasikSorus.ToList());
        }

        public void klasikSoruSil(int ID)
        {
            KlasikSoru yeni = new KlasikSoru();
            yeni.Id = ID;

            dbContext.KlasikSorus.DeleteOnSubmit(dbContext.KlasikSorus.First(s=>s.Id==ID));
            dbContext.SubmitChanges();
            view.updateKlasikSorularGrid(dbContext.KlasikSorus.ToList());

        }
    }
}
