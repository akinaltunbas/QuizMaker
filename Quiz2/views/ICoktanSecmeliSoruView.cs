using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using Quiz2.models;

namespace Quiz2.views
{
   public interface ICoktanSecmeliSoruView
    {
       void updateCoktanSecmeliSorularGrid(IList<CoktanSecmeliSoru>liste);
    }
}
