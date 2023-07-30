using Quiz2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Quiz2.views
{
  public  interface IKategoriView
    {
      void updateKategorilerGrid(IList<Kategori> liste);
    }
}
