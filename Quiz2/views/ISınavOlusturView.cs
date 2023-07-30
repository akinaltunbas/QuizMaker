using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz2.models;

namespace Quiz2.views
{
   public interface ISınavOlusturView
    {
       void sınavZorlukDerecesiHesapla();
       void sınavSoruCesidiHesapla();
       void sınavPuanıHesapla();

    }
}
