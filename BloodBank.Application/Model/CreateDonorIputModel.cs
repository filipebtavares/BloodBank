using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Model
{
    public  class CreateDonorIputModel
    {
        public int Id { get;  set; }
        public string FullName { get;   set; }
        public string Email { get;     set; }
        public DateTime BirthDate { get;   set; }
        public string Genre { get;   set; }
        public double Weight { get;   set; }
        public string BloodType { get;   set; }
        public string RhFactor { get;   set; }

        
    }
}
