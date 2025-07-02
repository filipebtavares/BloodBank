using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Respositories
{
    public interface IBloodStockRepository
    {
        Task<BloodStock> GetBloodStockById(int id);
        Task<int> PostBloodStock(BloodStock bloodStock);
        Task UpdateBloodStock(BloodStock bloodStock);
        Task<bool> BloodStockExists(int id);
    }
}
