using System.Collections;
using System.Collections.Generic;
using Models;

namespace HandIn1Family.Data
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int todoId);
    }
}