using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public  class ViaCepViewModel
    {
        public string Cep { get; set; }
        public string PublicPlace { get; set; }
        public string District { get; set; }
        public string Locality { get; set; }
        public string Uf { get; set; }
        public string Ddd { get; set; }
    }
}
