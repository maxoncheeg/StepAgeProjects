using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LongDistanceService.Model
{
    interface ITable<T> where T: class
    {
        Task<Boolean> AddAsync(T item);
        Task<Boolean> UpdateAsync(T item);
        Task<Boolean> DeleteAsync(int id);
        Task<List<T>> SearchAsync(string name);
    }
}
