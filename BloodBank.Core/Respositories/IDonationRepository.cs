﻿using BloodBank.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Core.Respositories
{
    public interface IDonationRepository
    {
        Task<List<Donation>> GetDonation();
        Task<int> PostDonation(Donation donation);
        Task<Donation> GetDonationById(int id);
        Task AsDeleted(Donation donation);
    }
}
