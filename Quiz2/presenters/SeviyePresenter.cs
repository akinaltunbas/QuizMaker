using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using Quiz2.views;
namespace Quiz2.presenters
{
    class SeviyePresenter
    {
        ISeviyeView view;
        SoruBankasıDataContext dbContext;

       
        public SeviyePresenter(ISeviyeView view)
        {
            this.view = view;
            dbContext = new SoruBankasıDataContext();
        }

        public void seviyeEkle(string derece)
        {

            Seviye yeni = new Seviye();

            yeni.ZorlukDerecesi = derece;

            dbContext.Seviyes.InsertOnSubmit(yeni);
            dbContext.SubmitChanges();
            view.updateSeviyelerGrid(dbContext.Seviyes.ToList());

        }

        public void yükle()
        {
            view.updateSeviyelerGrid(dbContext.Seviyes.ToList());
        }

        public void seviyeSil(int ID)
        {
            Seviye yeni = new Seviye();
            yeni.Id = ID;

            dbContext.Seviyes.DeleteOnSubmit(dbContext.Seviyes.First(s=>s.Id==ID));
            dbContext.SubmitChanges();
            view.updateSeviyelerGrid(dbContext.Seviyes.ToList());
        }

       
    }
}