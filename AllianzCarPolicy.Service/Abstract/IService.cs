using System;
using System.Collections.Generic;
using System.Text;

namespace AllianzCarPolicy.Service.Abstract
{
    public interface IService<T> where T : class
    {
        bool Save(T obj, ref string message);
        bool Remove(T obj);
        bool Remove(long id);
        T GetById(long Id);
        IEnumerable<T> GetAll();
       //  DataTablesResponse SearchApi(IDataTablesRequest requestModel);
    }
}
