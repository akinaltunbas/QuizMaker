using Quiz2.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using System.Data.Linq;

namespace Quiz2.presenters
{
   public class KategoriPresenter
    {
       IKategoriView view;
       SoruBankasıDataContext dbContext;

       public KategoriPresenter(IKategoriView view)
       {
           this.view = view;
           dbContext = new SoruBankasıDataContext();

       }

       public void kategoriEkle(string isim)
       {
           Kategori yeni = new Kategori();

           yeni.Ad = isim;

           dbContext.Kategoris.InsertOnSubmit(yeni);
           dbContext.SubmitChanges();

           view.updateKategorilerGrid(dbContext.Kategoris.ToList());

       }
       public void yükle()
       {
           view.updateKategorilerGrid(dbContext.Kategoris.ToList());
       }

       public void kategoriSil(int ID)
       {
           Seviye yeni = new Seviye();
           yeni.Id = ID;

           dbContext.Kategoris.DeleteOnSubmit(dbContext.Kategoris.First(s=>s.Id==ID));
           dbContext.SubmitChanges();
           view.updateKategorilerGrid(dbContext.Kategoris.ToList());
       }
    }
}
