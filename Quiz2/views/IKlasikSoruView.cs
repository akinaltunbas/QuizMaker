using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;
using System.Data.Linq;

namespace Quiz2.views
{
   public interface IKlasikSoruView
    {
       void updateKlasikSorularGrid(IList<KlasikSoru>liste);
    }
}
