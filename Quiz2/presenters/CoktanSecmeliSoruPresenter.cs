using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using Quiz2.views;
using System.Data.Linq;

namespace Quiz2.presenters
{
    class CoktanSecmeliSoruPresenter
    {
        ICoktanSecmeliSoruView view;
        SoruBankasıDataContext dbContext;

        public CoktanSecmeliSoruPresenter(ICoktanSecmeliSoruView view)
        {
            this.view = view;
            dbContext = new SoruBankasıDataContext();
        }

        public void coktanSecmeliSoruEkle(int ktg,int svy,string soru,string a,string b,string c,string d,string dogru,int p)
        {
            CoktanSecmeliSoru yeni = new CoktanSecmeliSoru();

            yeni.KategoriId = ktg;
            yeni.SeviyeId = svy;
            yeni.SoruMetni = soru;
            yeni.A = a;
            yeni.B = b;
            yeni.C = c;
            yeni.D = d;
            yeni.DogruCevap = dogru;
            yeni.Puan = p;

            dbContext.CoktanSecmeliSorus.InsertOnSubmit(yeni);
            dbContext.SubmitChanges();

            view.updateCoktanSecmeliSorularGrid(dbContext.CoktanSecmeliSorus.ToList());

        }

        public void yükle()
        {
            view.updateCoktanSecmeliSorularGrid(dbContext.CoktanSecmeliSorus.ToList());
        }

        public void coktanSecmeliSoruSil(int ID)
        {
            CoktanSecmeliSoru yeni = new CoktanSecmeliSoru();
            yeni.Id = ID;

            dbContext.CoktanSecmeliSorus.DeleteOnSubmit(dbContext.CoktanSecmeliSorus.First(s=>s.Id==ID));
            dbContext.SubmitChanges();
            view.updateCoktanSecmeliSorularGrid(dbContext.CoktanSecmeliSorus.ToList());

        }
    }
}
