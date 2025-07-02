using BloodBank.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Service
{
    public  interface ICepService
    {
        Task<AddressViewModel> GetCep(string cep);
    }
}
