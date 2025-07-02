using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Respositories
{
    public interface IDonorRespository
    {
        Task<List<Donor>> GetDonors(string search);
        Task<Donor> GetDonorById(int id);
        Task<int> PostDonor(Donor donor);
        Task UpdateDonor(Donor donor);
        Task<bool> DonorExists(int id);
    }
}
