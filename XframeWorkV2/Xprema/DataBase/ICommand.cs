using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.DataBase
{
  public interface ICommand
    {
      bool Add(object obj);
      bool Edit(object obj);
      bool Delete(int ID);
      List<object> GetAll();
    }
}
