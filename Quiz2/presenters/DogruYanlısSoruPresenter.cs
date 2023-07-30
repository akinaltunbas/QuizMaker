using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using Quiz2.views;
using System.Data.Linq;

namespace Quiz2.presenters
{
    class DogruYanlısSoruPresenter
    {
        IDogruYanlısSoruView view;
        SoruBankasıDataContext dbContext;

        public DogruYanlısSoruPresenter(IDogruYanlısSoruView view)
        {
            this.view = view;
            dbContext = new SoruBankasıDataContext();
        }

        public void yükle()
        {
            view.uptadeDogruYanlısSorularGrid(dbContext.DogruYanlısSorus.ToList());
        }

        public void dySoruSil(int ID)
        {
            DogruYanlısSoru yeni = new DogruYanlısSoru();
            yeni.Id = ID;
            dbContext.DogruYanlısSorus.DeleteOnSubmit(dbContext.DogruYanlısSorus.First(s => s.Id == ID));
            dbContext.SubmitChanges();
            view.uptadeDogruYanlısSorularGrid(dbContext.DogruYanlısSorus.ToList());

        }

        public void dySoruEkle(int ktg,int svy,string soru,string d, string y,string dogru,int p)
        {

            DogruYanlısSoru yeni = new DogruYanlısSoru();

            yeni.KategoriId = ktg;
            yeni.SeviyeId = svy;
            yeni.SoruMetni = soru;
            yeni.Dogru = d;
            yeni.Yanlıs = y;
            yeni.DogruCevap = dogru;
            yeni.Puan = p;

            dbContext.DogruYanlısSorus.InsertOnSubmit(yeni);
            dbContext.SubmitChanges();
            view.uptadeDogruYanlısSorularGrid(dbContext.DogruYanlısSorus.ToList());

        }
    }
}
